namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            операцияToolStripMenuItem = new ToolStripMenuItem();
            суммаToolStripMenuItem = new ToolStripMenuItem();
            разностьToolStripMenuItem = new ToolStripMenuItem();
            выхходToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { операцияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // операцияToolStripMenuItem
            // 
            операцияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { суммаToolStripMenuItem, разностьToolStripMenuItem, выхходToolStripMenuItem });
            операцияToolStripMenuItem.Name = "операцияToolStripMenuItem";
            операцияToolStripMenuItem.Size = new Size(72, 20);
            операцияToolStripMenuItem.Text = "операция";
            // 
            // суммаToolStripMenuItem
            // 
            суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            суммаToolStripMenuItem.Size = new Size(180, 22);
            суммаToolStripMenuItem.Text = "сумма";
            суммаToolStripMenuItem.Click += суммаToolStripMenuItem_Click;
            // 
            // разностьToolStripMenuItem
            // 
            разностьToolStripMenuItem.Name = "разностьToolStripMenuItem";
            разностьToolStripMenuItem.Size = new Size(180, 22);
            разностьToolStripMenuItem.Text = "разность";
            разностьToolStripMenuItem.Click += разностьToolStripMenuItem_Click;
            // 
            // выхходToolStripMenuItem
            // 
            выхходToolStripMenuItem.Name = "выхходToolStripMenuItem";
            выхходToolStripMenuItem.Size = new Size(180, 22);
            выхходToolStripMenuItem.Text = "выхход";
            выхходToolStripMenuItem.Click += выхходToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 274);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "результат: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem операцияToolStripMenuItem;
        private ToolStripMenuItem суммаToolStripMenuItem;
        private ToolStripMenuItem разностьToolStripMenuItem;
        private ToolStripMenuItem выхходToolStripMenuItem;
        private Label label1;
        public TextBox textBox1;
    }
}
