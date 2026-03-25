using System.Runtime.CompilerServices;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp7
{


    public partial class MatchingGame : Form
    {

        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
        {
            "b", "b", "v", "v", "w", "w", "z", "z",
            "!", "!", "N", "N", ",", ",", "k", "k",
        };

        Label firstClicked = null;

        Label secondClicked = null;
        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public MatchingGame()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Если таймер запущен – игнорируем клики
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Если значок уже открыт (чёрный цвет) – игнорируем
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // Первый клик
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black; // показываем значок
                    return;
                }

                // Второй клик
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Сразу после открытия второго значка проверяем, не выиграл ли игрок
                CheckForWinner();

                // Проверяем, совпадают ли значки
                if (firstClicked.Text == secondClicked.Text)
                {
                    // Совпали – оставляем открытыми, сбрасываем ссылки и выходим (таймер не запускаем)
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // Если не совпали – запускаем таймер, чтобы скрыть через 0.75 секунды
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Остановить таймер
            timer1.Stop();

            // Скрыть оба значка (цвет текста делаем равным цвету фона)
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Сбросить ссылки для следующего хода
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            // Перебираем все элементы управления в TableLayoutPanel
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    // Если цвет значка совпадает с фоном – значит он ещё скрыт
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return; // не все открыты, выходим
                }
            }

            // Если дошли сюда – все значки открыты
            MessageBox.Show("Вы открыли все пары! Поздравляем!", "Победа!");
            Close(); // закрываем форму (можно заменить на перезапуск, если хочешь)
        }
    }
}
