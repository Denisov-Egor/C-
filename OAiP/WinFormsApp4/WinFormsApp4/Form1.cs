namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }
    }
}
