namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            int a = Convert.ToInt32(newForm.textBox1.Text);
            int b = Convert.ToInt32(newForm.textBox2.Text);
            int s = a + b;
            textBox1.Text = Convert.ToString(s);

        }

        private void разностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            int a = Convert.ToInt32(newForm.textBox1.Text);
            int b = Convert.ToInt32(newForm.textBox2.Text);
            int s = a - b;
            textBox1.Text = Convert.ToString(s);

        }

        private void выхходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
