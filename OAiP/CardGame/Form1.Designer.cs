namespace WinFormsApp485867
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
            table = new TableLayoutPanel();
            SuspendLayout();
            // 
            // table
            // 
            table.ColumnCount = 6;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            table.Dock = DockStyle.Fill;
            table.Location = new Point(0, 0);
            table.Margin = new Padding(3, 4, 3, 4);
            table.Name = "table";
            table.RowCount = 6;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            table.Size = new Size(1049, 871);
            table.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 871);
            Controls.Add(table);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel table;
    }
}
