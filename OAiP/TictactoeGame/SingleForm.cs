using MyNetwork;
using System.Net;

namespace Tictactoe
{
    public partial class SingleForm : Form
    {

        private static int count;

        private enum Turn
        {
            PlayerF,
            PlayerS,
            Bot,
            None
        }
        private Turn _turn = Turn.None;
        private bool _withBot = false;
        private int _difficulty = 0;

        public SingleForm(bool withBot, int diffc)
        {
            _withBot = withBot;
            _difficulty = diffc;
            InitializeComponent();
            CenterToScreen();
            InitGameLayout();
            _turn = Turn.PlayerF;
        }

        private void InitGameLayout()
        {
            tableLayout.Controls.Clear();
            tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            for (int i = 0; i < tableLayout.RowCount; i++)
            {
                for (int j = 0; j < tableLayout.ColumnCount; j++)
                {
                    PictureBox img = new()
                    {
                        Dock = DockStyle.Fill,
                        Image = null,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = new Point(j, i)
                    };
                    img.Click += handleClick;
                    tableLayout.Controls.Add(img, j, i);
                }
            }
        }

        private void handleClick(object? sender, EventArgs e)
        {
            if (_turn == Turn.None || _turn == Turn.Bot) return;
            if (sender is not PictureBox pb || pb.Image != null) return;
            Image currentImg = (_turn == Turn.PlayerF) ? Assets.Cross : Assets.Zero;
            bool gameOver = applyTurn(pb, currentImg);
            if (!gameOver)
            {
                _turn = getNextTurn(_turn);
                if (_turn == Turn.Bot)
                {
                    makeBotMove();
                }
            }
        }

        private bool applyTurn(PictureBox pb, Image img)
        {
            pb.Image = img;
            if (checkWin())
            {
                if(MessageBox.Show(_turn == Turn.PlayerF ? "Ю Вин!" : "Ю луз!") == DialogResult.OK)
                {
                    this.Close();
                }
                _turn = Turn.None;
                return true;
            }
            if (isFieldFull())
            {
                if (MessageBox.Show("Ничья") == DialogResult.OK)
                {
                    this.Close();
                }
                _turn = Turn.None;
                return true;
            }
            return false;
        }

        private async void makeBotMove()
        {
            await Task.Delay(300);
            PictureBox targetCell = null;
            if (_difficulty == -1)
            {
                Point bestMove = GetTheBestBotMove();
                targetCell = tableLayout.GetControlFromPosition(bestMove.X, bestMove.Y) as PictureBox;
            }
            if (targetCell == null && (_difficulty == 0 || _difficulty == 1))
            {
                targetCell = findBestMove(Assets.Zero);
            }
            if (targetCell == null && _difficulty == 0)
            {
                targetCell = findBestMove(Assets.Cross);
            }
            if (targetCell == null && (_difficulty == 0 || _difficulty == 1))
            {
                var center = tableLayout.GetControlFromPosition(1, 1) as PictureBox;
                if (center != null && center.Image == null)
                    targetCell = center;
            }
            if (targetCell == null)
            {
                var emptyCells = tableLayout.Controls.OfType<PictureBox>()
                                                     .Where(p => p.Image == null)
                                                     .ToList();
                if (emptyCells.Count > 0)
                {
                    Random rnd = new Random();
                    targetCell = emptyCells[rnd.Next(emptyCells.Count)];
                }
            }
            if (targetCell != null)
            {
                if (!applyTurn(targetCell, Assets.Zero))
                {
                    _turn = Turn.PlayerF;
                }
            }
        }

        private PictureBox findBestMove(Image targetSymbol)
        {
            int[][][] lines =
            [
                [[0,0], [1,0], [2,0]],
                [[0,1], [1,1], [2,1]],
                [[0,2], [1,2], [2,2]],
                [[0,0], [0,1], [0,2]],
                [[1,0], [1,1], [1,2]],
                [[2,0], [2,1], [2,2]],
                [[0,0], [1,1], [2,2]],
                [[0,2], [1,1], [2,0]]
            ];
            foreach (var line in lines)
            {
                int countTarget = 0;
                PictureBox emptyCell = null;
                foreach (var coord in line)
                {
                    var pb = tableLayout.GetControlFromPosition(coord[0], coord[1]) as PictureBox;
                    if (pb.Image == targetSymbol) countTarget++;
                    else if (pb.Image == null) emptyCell = pb;
                    else countTarget--;
                }
                if (countTarget == 2 && emptyCell != null)
                {
                    return emptyCell;
                }
            }
            return null;
        }

        private Turn getNextTurn(Turn current)
        {
            if (_withBot)
            {
                if (current == Turn.PlayerF)
                {
                    return Turn.Bot;
                }
            }
            else
            {
                if (current == Turn.PlayerF)
                {
                    return Turn.PlayerS;
                }
            }
            return Turn.PlayerF;
        }

        private bool checkWin()
        {
            int[,] map = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (tableLayout.GetControlFromPosition(col, row) is PictureBox pb)
                    {
                        if (pb.Image == Assets.Cross) map[row, col] = 2;
                        else if (pb.Image == Assets.Zero) map[row, col] = 1;
                        else map[row, col] = 0;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (map[i, 0] != 0 && map[i, 0] == map[i, 1] && map[i, 1] == map[i, 2])
                {
                    return true;
                }
                if (map[0, i] != 0 && map[0, i] == map[1, i] && map[1, i] == map[2, i])
                {
                    return true;
                }

            }
            if (map[1, 1] != 0)
            {
                if (map[0, 0] == map[1, 1] && map[1, 1] == map[2, 2])
                {
                    return true;
                }
                if (map[0, 2] == map[1, 1] && map[1, 1] == map[2, 0])
                {
                    return true;
                }
            }
            return false;
        }

        private bool isFieldFull()
        {
            foreach (Control c in tableLayout.Controls)
            {
                if (c is PictureBox pb && pb.Image == null) return false;
            }
            return true;
        }

        private int[,] GetBoardMatrix()
        {
            int[,] res = new int[3, 3];
            for (int y = 0; y < 3; y++)
                for (int x = 0; x < 3; x++)
                {
                    var pb = tableLayout.GetControlFromPosition(x, y) as PictureBox;
                    if (pb.Image == Assets.Cross) res[y, x] = 2;
                    else if (pb.Image == Assets.Zero) res[y, x] = 1;
                    else res[y, x] = 0;
                }
            return res;
        }

        private Point GetTheBestBotMove()
        {
            int[,] board = GetBoardMatrix();
            int bestVal = -1000;
            Point bestMove = new Point(-1, -1);
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        board[i, j] = 1;
                        int moveVal = Minimax(board, 0, false);
                        board[i, j] = 0;
                        if (moveVal > bestVal)
                        {
                            bestMove = new Point(j, i);
                            bestVal = moveVal;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            return bestMove;           
        }

        private int Minimax(int[,] board, int depth, bool isMax)
        {
            count++;
            int score = EvaluateBoard(board);
            if (score == 10) return score - depth;
            if (score == -10) return score + depth;
            if (IsMovesLeft(board) == false) return 0;
            if (isMax)
            {
                int best = -1000;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (board[i, j] == 0)
                        {
                            board[i, j] = 1;
                            best = Math.Max(best, Minimax(board, depth + 1, !isMax));
                            board[i, j] = 0;
                        }
                return best;
            }
            else
            {
                int best = 1000;
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (board[i, j] == 0)
                        {
                            board[i, j] = 2;
                            best = Math.Min(best, Minimax(board, depth + 1, !isMax));
                            board[i, j] = 0;
                        }
                return best;
            }
        }

        private bool IsMovesLeft(int[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == 0) return true;
            return false;
        }

        private int EvaluateBoard(int[,] b)
        {
            for (int i = 0; i < 3; i++)
            {
                if (b[i, 0] == b[i, 1] && b[i, 1] == b[i, 2])
                {
                    if (b[i, 0] == 1) return 10;
                    if (b[i, 0] == 2) return -10;
                }
                if (b[0, i] == b[1, i] && b[1, i] == b[2, i])
                {
                    if (b[0, i] == 1) return 10;
                    if (b[0, i] == 2) return -10;
                }
            }
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == 1) return 10;
                if (b[0, 0] == 2) return -10;
            }
            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == 1) return 10;
                if (b[0, 2] == 2) return -10;
            }
            return 0;
        }
    }
}
