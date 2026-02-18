using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double r = 0;
            if (checkBox1.Checked) r = a + b;
            if (checkBox2.Checked) r = a - b;
            textBox3.Text = Convert.ToString(r);

        }
    }
}
