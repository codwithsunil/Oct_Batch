namespace WinFormsApp
{
    partial class BookView
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
            dataGridBook = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBook).BeginInit();
            SuspendLayout();
            // 
            // dataGridBook
            // 
            dataGridBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBook.Location = new Point(12, 125);
            dataGridBook.Name = "dataGridBook";
            dataGridBook.RowHeadersWidth = 62;
            dataGridBook.Size = new Size(776, 225);
            dataGridBook.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(63, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridBook);
            Name = "BookView";
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)dataGridBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridBook;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}