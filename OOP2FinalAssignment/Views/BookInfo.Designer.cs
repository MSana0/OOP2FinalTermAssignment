namespace OOP2FinalAssignment.Views
{
    partial class BookInfo
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
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.tBEdition = new System.Windows.Forms.TextBox();
            this.tBAuthor = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBooks
            // 
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(108, 222);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.RowTemplate.Height = 24;
            this.gridBooks.Size = new System.Drawing.Size(594, 195);
            this.gridBooks.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(558, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(198, 45);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(339, 22);
            this.tBSearch.TabIndex = 3;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // tBEdition
            // 
            this.tBEdition.Location = new System.Drawing.Point(198, 162);
            this.tBEdition.Name = "tBEdition";
            this.tBEdition.Size = new System.Drawing.Size(339, 22);
            this.tBEdition.TabIndex = 4;
            // 
            // tBAuthor
            // 
            this.tBAuthor.Location = new System.Drawing.Point(198, 121);
            this.tBAuthor.Name = "tBAuthor";
            this.tBAuthor.Size = new System.Drawing.Size(339, 22);
            this.tBAuthor.TabIndex = 5;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(198, 84);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(339, 22);
            this.tBName.TabIndex = 6;
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBAuthor);
            this.Controls.Add(this.tBEdition);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.gridBooks);
            this.Name = "BookInfo";
            this.Text = "BookInfo";
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.TextBox tBEdition;
        private System.Windows.Forms.TextBox tBAuthor;
        private System.Windows.Forms.TextBox tBName;
    }
}