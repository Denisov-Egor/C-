namespace Tictactoe
{
    partial class MultiForm
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
            tableLayout = new TableLayoutPanel();
            hostButton = new Button();
            label1 = new Label();
            ipBox = new TextBox();
            portBox = new NumericUpDown();
            label2 = new Label();
            clientButton = new Button();
            startButton = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)portBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.Size = new Size(784, 761);
            tableLayout.TabIndex = 0;
            // 
            // hostButton
            // 
            hostButton.Location = new Point(882, 183);
            hostButton.Name = "hostButton";
            hostButton.Size = new Size(124, 33);
            hostButton.TabIndex = 1;
            hostButton.Text = "Host";
            hostButton.UseVisualStyleBackColor = true;
            hostButton.Click += host_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(882, 136);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "IP";
            // 
            // ipBox
            // 
            ipBox.Location = new Point(882, 154);
            ipBox.Name = "ipBox";
            ipBox.Size = new Size(165, 23);
            ipBox.TabIndex = 3;
            // 
            // portBox
            // 
            portBox.Location = new Point(1053, 154);
            portBox.Name = "portBox";
            portBox.Size = new Size(88, 23);
            portBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1053, 136);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // clientButton
            // 
            clientButton.Location = new Point(1017, 183);
            clientButton.Name = "clientButton";
            clientButton.Size = new Size(124, 33);
            clientButton.TabIndex = 6;
            clientButton.Text = "Connect to";
            clientButton.UseVisualStyleBackColor = true;
            clientButton.Click += cli_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(882, 263);
            startButton.Name = "startButton";
            startButton.Size = new Size(259, 50);
            startButton.TabIndex = 7;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += start3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(984, 325);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // MultiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(label3);
            Controls.Add(startButton);
            Controls.Add(clientButton);
            Controls.Add(label2);
            Controls.Add(portBox);
            Controls.Add(ipBox);
            Controls.Add(label1);
            Controls.Add(hostButton);
            Controls.Add(tableLayout);
            MinimumSize = new Size(1280, 800);
            Name = "MultiForm";
            Text = "Form1";
            FormClosing += MultiForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)portBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Button hostButton;
        private Label label1;
        private TextBox ipBox;
        private NumericUpDown portBox;
        private Label label2;
        private Button clientButton;
        private Button startButton;
        private Label label3;
    }
}