namespace WinFormsApp485867
{
    public partial class Form1 : Form
    {
        private readonly string[] _keys = { "bird", "buterfly", "cap", "car", "flower", "ship", "show", "sun","horse","pig","cow","cat","minidog","dog","tree","leas","kuvsh","malinka" };
        private readonly Dictionary<string, Image> _images = new();
        private List<CellData> _cells = new();
        private CellData _firstClicked = null;
        private CellData _secondClicked = null;
        private Panel _winPanel;
        private System.Windows.Forms.Timer _mismatchTimer;

        class CellData
        {
            public Label Label { get; set; }
            public string Key { get; set; }
            public bool IsMatched { get; set; }
            public bool IsShown { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            LoadImages();
            InitMismatchTimer();
            InitWinScreen();
            InitGame();
        }

        private void LoadImages()
        {
            foreach (var key in _keys)
            {
                string path = Path.Combine(Application.StartupPath, $"{key}.png");
                if (File.Exists(path))
                    _images[key] = Image.FromFile(path);
            }
        }

        private void InitMismatchTimer()
        {
            _mismatchTimer = new System.Windows.Forms.Timer { Interval = 700 };
            _mismatchTimer.Tick += (s, e) =>
            {
                _mismatchTimer.Stop();
                _firstClicked.IsShown = false;
                _secondClicked.IsShown = false;
                UpdateCellVisual(_firstClicked);
                UpdateCellVisual(_secondClicked);
                _firstClicked = null;
                _secondClicked = null;
                table.Enabled = true; 
            };
        }

        public void InitGame()
        {
            table.Controls.Clear();
            _cells.Clear();
            _winPanel.Visible = false;
            _firstClicked = null;
            _secondClicked = null;
            var gameKeys = _keys.Concat(_keys).OrderBy(x => Guid.NewGuid()).ToList();
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table.Enabled = true;
            for (int i = 0; i < gameKeys.Count; i++)
            {
                var cell = new CellData { Key = gameKeys[i] };
                var lb = new Label
                {
                    //Text = cell.Key,
                    Dock = DockStyle.Fill,
                    Tag = cell,
                    Cursor = Cursors.Hand,
                    ImageAlign = ContentAlignment.MiddleCenter
                };
                lb.Click += LabelLogic;
                cell.Label = lb;
                _cells.Add(cell);
                table.Controls.Add(lb, i % 6, i / 6);
            }
        }

        private void LabelLogic(object sender, EventArgs e)
        {
            if (sender is not Label lb || lb.Tag is not CellData clickedCell) return;
            if (clickedCell.IsShown || clickedCell.IsMatched || _mismatchTimer.Enabled) return;
            clickedCell.IsShown = true;
            UpdateCellVisual(clickedCell);
            if (_firstClicked == null)
            {
                _firstClicked = clickedCell;
            }
            else
            {
                _secondClicked = clickedCell;
                CheckMatch();
            }
        }

        private void CheckMatch()
        {
            if (_firstClicked.Key == _secondClicked.Key)
            {
                _firstClicked.IsMatched = true;
                _secondClicked.IsMatched = true;
                _firstClicked = null;
                _secondClicked = null;
                if (_cells.All(c => c.IsMatched)) ShowWinScreen();
            }
            else
            {
                table.Enabled = false; 
                _mismatchTimer.Start();
            }
        }

        private void UpdateCellVisual(CellData cell)
        {
            if (cell.IsShown || cell.IsMatched)
            {
                if (_images.ContainsKey(cell.Key))
                    cell.Label.Image = _images[cell.Key];
                else
                    cell.Label.Text = cell.Key; 
            }
            else
            {
                cell.Label.Image = null;
                cell.Label.Text = "";
            }
        }

        private void ShowWinScreen()
        {
            _winPanel.Visible = true;
            _winPanel.BringToFront();
        }

        private void InitWinScreen()
        {
            _winPanel = new Panel { Dock = DockStyle.Fill, Visible = false, BackColor = Color.White };
            var pb = new PictureBox { Dock = DockStyle.Fill };
            pb.Paint += (s, e) => {
                using var font = new Font("Calibri", 60f, FontStyle.Bold);
                var size = e.Graphics.MeasureString("YOU WIN!", font);
                e.Graphics.DrawString("YOU WIN!", font, Brushes.Orange,
                    (pb.Width - size.Width) / 2, (pb.Height - size.Height) / 2);
            };
            var btnRestart = new Button
            {
                Text = "Restart Game",
                Size = new Size(200, 50),
                Location = new Point((Width) / 2, Height - 200),
                Font = new Font("Calibri", 20f)
            };        
            btnRestart.Click += (s, e) => InitGame();
            _winPanel.Controls.Add(pb);
            _winPanel.Controls.Add(btnRestart);
            _winPanel.Controls.SetChildIndex(btnRestart, 0);       
            Controls.Add(_winPanel);
        }
    }
}