using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp4567
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private TextBox[] mas;
        private Label[] Firstmas;
        private Label[] Secmas;
        private Game[] mas2;
        private Random Rand;
        private Timer timer;
        private int remainingSecond = 30;
        public Form1()
        {

            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
            InizializateGame();


        }
        public void InizializateGame()
        {
            mas = new TextBox[] { textBox1, textBox2, textBox3, textBox4 };
            Firstmas = new Label[] { label111, label222, label333, label444 };
            Secmas = new Label[] { label85, label86, label87, label88 };


            Rand = new Random();
            mas2 = new Game[] {
                new Game(Rand.Next(1, 100), Rand.Next(1, 100)),
                new Game(Rand.Next(1, 100), Rand.Next(1, 100)),
                new Game(Rand.Next(1, 10), Rand.Next(1, 10)),
                new Game(Rand.Next(1, 100), Rand.Next(1, 15))
            };
            for (int i = 0; i < mas2.Length; i++)
            {
                Firstmas[i].Text = mas2[i].First.ToString();
                Secmas[i].Text = mas2[i].Second.ToString();
            }
            mas2[0].Result = mas2[0].First + mas2[0].Second;
            mas2[1].Result = mas2[1].First - mas2[1].Second;
            mas2[2].Result = mas2[2].First * mas2[2].Second;
            while (true)
            {
                if (mas2[3].First % mas2[3].Second == 0)
                {
                    mas2[3].Result = mas2[3].First / mas2[3].Second;
                    Firstmas[3].Text = mas2[3].First.ToString();
                    break;
                }
                else mas2[3].First += 1;

            }
            
            Console.WriteLine(mas2[0].Result);
            Console.WriteLine(mas2[1].Result);
            Console.WriteLine(mas2[2].Result);
            Console.WriteLine(mas2[3].Result);
        }
        public void RestartGame()
        {
            remainingSecond = 30;
          
            InizializateGame();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i].Text = "";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (mas == null || mas2 == null)
            {
                MessageBox.Show("неправильные ответы!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(mas[i].Text))
                {
                    MessageBox.Show($"Заполните поле {i + 1}!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mas[i].Focus();
                    return;
                }
            }
            try
            {
                
                if (Convert.ToInt32(mas[0].Text) == mas2[0].Result &&
                    Convert.ToInt32(mas[1].Text) == mas2[1].Result &&
                    Convert.ToInt32(mas[2].Text) == mas2[2].Result &&
                    Convert.ToInt32(mas[3].Text) == mas2[3].Result)
                {
                    DialogResult result = MessageBox.Show(
                           "Все ответы правильные!",
                           "Победа!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                     "Вы проиграли хотите начать заного?",
                     "Сообщение",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Yes)
                    {
                        RestartGame();
                    }
                    else Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                  "Пожалуйста, введите корректные числа!",
                  "Ошибка ввода",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(
                  "Ответы не правильные",
                  "Вы проиграли",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingSecond > 0)
            {
                remainingSecond--;
            }
            else
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show(
                           "Вы не успели, проигрыш",
                           "Проигрыш",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    RestartGame();
                }
                else Close();
            }
           labelTimer.Text = "Секунд осталось "+remainingSecond.ToString();
        }
    }
}
class Game
{
    public int First;
    public int Second;
    public int Result;
    public Game(int first, int second)
    {
        this.First = first;
        this.Second = second;
    }
}