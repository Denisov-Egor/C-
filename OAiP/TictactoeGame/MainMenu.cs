using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CenterToScreen();
            Assets.Load();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange("UnReal", "God", "Hard", "Easy");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 1;
        }

        private void singleButton_Click(object sender, EventArgs e)
        {
            SingleForm form = new SingleForm(withBotCheck.Checked, comboBox1.SelectedIndex - 1);
            form.FormClosed += (s, e) => { this.Show(); this.Invalidate(); };
            this.Hide();
            form.ShowDialog(this);          
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            MultiForm form = new MultiForm();
            form.FormClosed += (s, e) => { this.Show(); this.Invalidate(); };
            this.Hide();
            form.ShowDialog(this);
            
        }
    }
}
