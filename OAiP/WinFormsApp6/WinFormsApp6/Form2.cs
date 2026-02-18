using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(listBox1.Items[0].ToString());
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (max < Convert.ToInt32(listBox1.Items[i].ToString()))
                    max = Convert.ToInt32(listBox1.Items[i].ToString());
            textBox1.Text += Convert.ToString(max);

        }
    }
}
