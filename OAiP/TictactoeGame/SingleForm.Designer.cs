namespace Tictactoe
{
    partial class SingleForm
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
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Margin = new Padding(3, 4, 3, 4);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayout.Size = new Size(896, 1015);
            tableLayout.TabIndex = 0;
            // 
            // SingleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 1015);
            Controls.Add(tableLayout);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 1051);
            Name = "SingleForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
    }
}
