using MyNetwork;
using System.Net;

namespace Tictactoe
{
    public partial class MultiForm : Form
    {

        enum PType : byte
        {
            GameAccept = 1,
            GameStart = 2,  
            SyncTurn = 3,   
            Click = 4,     
            SyncMap = 5,    
            GameOver = 6    
        }

        private bool _myTurn = false;
        private byte _mySymbol = 0; 

        private NetworkServer _server;
        private NetworkClient _client;

        private readonly object _lock = new();
        private Dictionary<int, bool> _acceptedClients = new();
        private List<int> _playerIds = new();
        private int _uidTurn;
        private int[,] _gameBoard = new int[3, 3];
        private bool _isClosingManually = false;

        public MultiForm()
        {
            InitializeComponent();
            CenterToScreen();

            portBox.Maximum = IPEndPoint.MaxPort;
            portBox.Minimum = IPEndPoint.MinPort;
            ipBox.Text = "127.0.0.1";
            portBox.Value = 8888;

            _server = new NetworkServer { ShowLogs = true, ShowLogsTime = true };
            _client = new NetworkClient { ShowLogs = true, ShowLogsTime = true };

            _server.OnClientConnected += HandleClientConnection;
            _server.OnPacketReceived += HandleServerPacket;
            _client.OnPacketReceived += HandleClientPacket;
            _server.OnClientDisconnected += HandleServerDisconnect;
            _client.OnClientDisconnected += HandleClientDisconnect;

            label3.Text = "Ready to start";
        }

        #region UI Handlers

        private void host_Click(object sender, EventArgs e)
        {
            if (_server.ServerRunning)
            {
                StopAll();
            }
            else
            {
                IPEndPoint endp = GetValidEndPoint();
                if (endp == null) return;

                if (_server.Start(endp.Address, endp.Port, 2))
                {
                    if (_client.Connect(endp.Address, endp.Port, 5, 500))
                    {
                        hostButton.BackColor = Color.Green;
                        clientButton.Enabled = false;
                        startButton.Enabled = true;
                    }
                }
                else MessageBox.Show("Failed to start server");
            }
        }

        private void cli_Click(object sender, EventArgs e)
        {
            if (_client.Connected && !_server.ServerRunning)
            {
                StopAll();
            }
            else
            {
                IPEndPoint endp = GetValidEndPoint();
                if (endp == null) return;

                if (_client.Connect(endp.Address, endp.Port, 5, 500))
                {
                    clientButton.BackColor = Color.Green;
                    hostButton.Enabled = false;
                    startButton.Enabled = true;
                }
            }
        }

        private void start3_Click(object sender, EventArgs e)
        {
            if (_client.Connected)
            {
                _client.SendPacket((byte)PType.GameAccept);
                startButton.Enabled = false;
                label3.Text = "Waiting for other player...";
            }
        }

        private void StopAll()
        {
            _isClosingManually = true;
            _client.Disconnect();
            _server.Stop();
            lock (_lock)
            {
                _acceptedClients.Clear();
                _playerIds.Clear();
            }
            hostButton.BackColor = Color.White;
            clientButton.BackColor = Color.White;
            hostButton.Enabled = true;
            clientButton.Enabled = true;
            startButton.Enabled = false;
            label3.Text = "Disconnected";
            _isClosingManually = false; 
        }

        #endregion

        #region Server Logic

        private void HandleClientConnection(NetworkClient client)
        {
            lock (_lock)
            {
                _acceptedClients.TryAdd(client.UID, false);
            }
        }

        private void HandleServerPacket(NetworkClient client, byte packetType, byte[]? packetData)
        {
            PType type = (PType)packetType;
            lock (_lock)
            {
                switch (type)
                {
                    case PType.GameAccept:
                        HandleServerAccept(client);
                        break;

                    case PType.Click:
                        HandleServerClick(client, packetData);
                        break;
                }
            }
        }

        private void HandleServerAccept(NetworkClient client)
        {
            _acceptedClients[client.UID] = true;
            if (_acceptedClients.Count == 2 && _acceptedClients.Values.All(v => v))
            {
                _playerIds = _acceptedClients.Keys.ToList();
                _gameBoard = new int[3, 3];
                Random random = new Random();
                _uidTurn = _playerIds[random.Next(2)]; 
                byte firstPlayerSymbol = 1;
                byte secondPlayerSymbol = 2;
                if (_uidTurn == _playerIds[0])
                {
                    _server.SendPacket(PacketTarget.SpecificClient, (byte)PType.GameStart, [firstPlayerSymbol], _playerIds[0]);
                    _server.SendPacket(PacketTarget.SpecificClient, (byte)PType.GameStart, [secondPlayerSymbol], _playerIds[1]);
                }
                else
                {
                    _server.SendPacket(PacketTarget.SpecificClient, (byte)PType.GameStart, [firstPlayerSymbol], _playerIds[1]);
                    _server.SendPacket(PacketTarget.SpecificClient, (byte)PType.GameStart, [secondPlayerSymbol], _playerIds[0]);
                }
                SendServerTurnUpdate();
            }
        }

        private void HandleServerClick(NetworkClient client, byte[]? data)
        {
            if (data == null || data.Length < 2 || client.UID != _uidTurn) return;
            int x = data[0];
            int y = data[1];
            if (x < 3 && y < 3 && _gameBoard[x, y] == 0)
            {
                int symbol = (_uidTurn == _playerIds[0]) ? 1 : 2;
                _gameBoard[x, y] = symbol;
                _server.SendPacket(PacketTarget.AllClients, (byte)PType.SyncMap, [(byte)x, (byte)y, (byte)symbol]);
                int winner = CheckWinner();
                if (winner != -1)
                {
                    _server.SendPacket(PacketTarget.AllClients, (byte)PType.GameOver, [(byte)winner]);
                    return;
                }
                _uidTurn = (_uidTurn == _playerIds[0]) ? _playerIds[1] : _playerIds[0];
                SendServerTurnUpdate();
            }
        }

        private void SendServerTurnUpdate()
        {
            _server.SendPacket(PacketTarget.SpecificClient, (byte)PType.SyncTurn, [1], _uidTurn);
            _server.SendPacket(PacketTarget.AllExceptSpecific, (byte)PType.SyncTurn, [0], _uidTurn);
        }

        private int CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_gameBoard[i, 0] != 0 && _gameBoard[i, 0] == _gameBoard[i, 1] && _gameBoard[i, 1] == _gameBoard[i, 2]) return _gameBoard[i, 0];
                if (_gameBoard[0, i] != 0 && _gameBoard[0, i] == _gameBoard[1, i] && _gameBoard[1, i] == _gameBoard[2, i]) return _gameBoard[0, i];
            }
            if (_gameBoard[0, 0] != 0 && _gameBoard[0, 0] == _gameBoard[1, 1] && _gameBoard[1, 1] == _gameBoard[2, 2]) return _gameBoard[0, 0];
            if (_gameBoard[0, 2] != 0 && _gameBoard[0, 2] == _gameBoard[1, 1] && _gameBoard[1, 1] == _gameBoard[2, 0]) return _gameBoard[0, 2];
            if (_gameBoard.Cast<int>().All(cell => cell != 0)) return 0; 
            return -1; 
        }

        private void HandleServerDisconnect(NetworkClient disconnectedClient)
        {
            lock (_lock)
            {
                if (_playerIds.Count < 2)
                {
                    if (_acceptedClients.Remove(disconnectedClient.UID))
                    {
                        Console.WriteLine($"Player {disconnectedClient.UID} left during lobby. Removed from dict.");
                    }
                }
                else
                {
                    if (_playerIds.Contains(disconnectedClient.UID))
                    {
                        Console.WriteLine("Player left during game. Notifying others...");
                        _server.SendPacket(PacketTarget.AllClients, (byte)PType.GameOver, [255]);
                    }
                }
            }
        }

        #endregion

        #region Client Logic

        private void HandleClientPacket(NetworkClient client, byte packetType, byte[]? data)
        {
            PType type = (PType)packetType;
            this.Invoke(() =>
            {
                switch (type)
                {
                    case PType.GameStart:
                        _mySymbol = data?[0] ?? 0;
                        InitGameLayout();
                        label3.Text = $"Game Started! You are: {(_mySymbol == 1 ? "X" : "O")}";
                        break;

                    case PType.SyncTurn:
                        _myTurn = data?[0] == 1;
                        label3.Text = _myTurn ? "YOUR TURN" : "Opponent's turn...";
                        break;

                    case PType.SyncMap:
                        if (data != null) UpdateMapUI(data[0], data[1], data[2]);
                        break;

                    case PType.GameOver:
                        int winSym = data?[0] ?? 0;
                        if (winSym == 255)
                        {
                            MessageBox.Show("Opponent disconnected! Closing...");
                            this.Close();
                        }
                        else
                        {
                            string msg = winSym == 0 ? "Draw!" : (winSym == _mySymbol ? "YOU WIN!" : "YOU LOSE!");
                            MessageBox.Show(msg, "Game Over");
                            _myTurn = false;
                            startButton.Enabled = true;
                        }
                        break;
                }
            });
        }

        private void UpdateMapUI(int x, int y, int symbol)
        {
            PictureBox pb = (PictureBox)tableLayout.GetControlFromPosition(x, y);
            if (pb != null)
            {
                pb.Image = symbol == 1 ? Assets.Cross : Assets.Zero;
                pb.Enabled = false; 
            }
        }

        private void processClick(object? sender, EventArgs e)
        {
            if (!_myTurn || sender is not PictureBox pb || pb.Tag is not Point p) return;
            _client.SendPacket((byte)PType.Click, [(byte)p.X, (byte)p.Y]);
        }

        private void HandleClientDisconnect(NetworkClient client)
        {
            if (_isClosingManually) return;
            this.Invoke(() =>
            {
                if (!this.IsDisposed)
                {
                    MessageBox.Show("Connection lost or opponent disconnected. Closing game...");
                    this.Close(); 
                }
            });
        }

        #endregion

        #region GUi

        private void InitGameLayout()
        {
            tableLayout.SuspendLayout();
            tableLayout.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox img = new()
                    {
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = new Point(j, i),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    img.Click += processClick;
                    tableLayout.Controls.Add(img, j, i);
                }
            }
            tableLayout.ResumeLayout();
        }

        private IPEndPoint GetValidEndPoint()
        {
            if (IPAddress.TryParse(ipBox.Text, out IPAddress ip)) return new IPEndPoint(ip, (int)portBox.Value);
            MessageBox.Show("Invalid IP");
            return null;
        }

        private void MultiForm_FormClosing(object sender, FormClosingEventArgs e) => StopAll();

        #endregion
    }
}