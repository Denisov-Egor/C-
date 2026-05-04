namespace Tictactoe
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            singleButton = new Button();
            multiButton = new Button();
            label1 = new Label();
            withBotCheck = new CheckBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // singleButton
            // 
            singleButton.Location = new Point(10, 29);
            singleButton.Margin = new Padding(3, 4, 3, 4);
            singleButton.Name = "singleButton";
            singleButton.Size = new Size(266, 67);
            singleButton.TabIndex = 0;
            singleButton.Text = "Start";
            singleButton.UseVisualStyleBackColor = true;
            singleButton.Click += singleButton_Click;
            // 
            // multiButton
            // 
            multiButton.Location = new Point(24, 29);
            multiButton.Margin = new Padding(3, 4, 3, 4);
            multiButton.Name = "multiButton";
            multiButton.Size = new Size(266, 67);
            multiButton.TabIndex = 1;
            multiButton.Text = "Play";
            multiButton.UseVisualStyleBackColor = true;
            multiButton.Click += connectButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(336, 12);
            label1.Name = "label1";
            label1.Size = new Size(211, 60);
            label1.TabIndex = 2;
            label1.Text = "TicTacToe";
            // 
            // withBotCheck
            // 
            withBotCheck.AutoSize = true;
            withBotCheck.Location = new Point(10, 104);
            withBotCheck.Margin = new Padding(3, 4, 3, 4);
            withBotCheck.Name = "withBotCheck";
            withBotCheck.Size = new Size(86, 24);
            withBotCheck.TabIndex = 3;
            withBotCheck.Text = "with Bot";
            withBotCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(singleButton);
            groupBox1.Controls.Add(withBotCheck);
            groupBox1.Location = new Point(3, 144);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(414, 588);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Single";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 137);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(multiButton);
            groupBox2.Location = new Point(424, 144);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(458, 588);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "MultiPlayer";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 784);
            Name = "MainMenu";
            Text = "MainMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button singleButton;
        private Button multiButton;
        private Label label1;
        private CheckBox withBotCheck;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
    }
}