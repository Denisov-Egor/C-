namespace WinFormsApp4
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
            menuStrip2 = new MenuStrip();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            сложениеToolStripMenuItem = new ToolStripMenuItem();
            разностьToolStripMenuItem = new ToolStripMenuItem();
            суммаToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { операцииToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сложениеToolStripMenuItem, разностьToolStripMenuItem, суммаToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(73, 20);
            операцииToolStripMenuItem.Text = "операции";
            операцииToolStripMenuItem.Click += операцииToolStripMenuItem_Click;
            // 
            // сложениеToolStripMenuItem
            // 
            сложениеToolStripMenuItem.Name = "сложениеToolStripMenuItem";
            сложениеToolStripMenuItem.Size = new Size(180, 22);
            сложениеToolStripMenuItem.Text = "выход";
            сложениеToolStripMenuItem.Click += сложениеToolStripMenuItem_Click;
            // 
            // разностьToolStripMenuItem
            // 
            разностьToolStripMenuItem.Name = "разностьToolStripMenuItem";
            разностьToolStripMenuItem.Size = new Size(180, 22);
            разностьToolStripMenuItem.Text = "разность";
            разностьToolStripMenuItem.Click += разностьToolStripMenuItem_Click;
            // 
            // суммаToolStripMenuItem
            // 
            суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            суммаToolStripMenuItem.Size = new Size(180, 22);
            суммаToolStripMenuItem.Text = "сумма";
            суммаToolStripMenuItem.Click += суммаToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(587, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 310);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem сложениеToolStripMenuItem;
        private ToolStripMenuItem разностьToolStripMenuItem;
        private ToolStripMenuItem суммаToolStripMenuItem;
        private ListBox listBox1;
        private Label label1;
        public TextBox textBox1;
    }
}
