namespace CrochetApp2._0
{
    partial class FindPatterns
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
            dgvRPatterns = new DataGridView();
            btnClose = new Button();
            btnGoTo = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            lbPages = new Label();
            cbSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvRPatterns).BeginInit();
            SuspendLayout();
            // 
            // dgvRPatterns
            // 
            dgvRPatterns.AllowUserToAddRows = false;
            dgvRPatterns.AllowUserToDeleteRows = false;
            dgvRPatterns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRPatterns.Location = new Point(12, 12);
            dgvRPatterns.Name = "dgvRPatterns";
            dgvRPatterns.ReadOnly = true;
            dgvRPatterns.RowHeadersWidth = 51;
            dgvRPatterns.RowTemplate.Height = 29;
            dgvRPatterns.Size = new Size(572, 405);
            dgvRPatterns.TabIndex = 0;
            dgvRPatterns.CellClick += dgvRPatterns_CellClick;
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.DimGray;
            btnClose.Location = new Point(500, 423);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(84, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnGoTo
            // 
            btnGoTo.ForeColor = Color.DimGray;
            btnGoTo.Location = new Point(12, 423);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new Size(114, 29);
            btnGoTo.TabIndex = 0;
            btnGoTo.Text = "Go to Pattern";
            btnGoTo.UseVisualStyleBackColor = true;
            btnGoTo.Click += btnGoTo_Click;
            // 
            // btnFirst
            // 
            btnFirst.ForeColor = Color.DimGray;
            btnFirst.Location = new Point(260, 423);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 29);
            btnFirst.TabIndex = 2;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.ForeColor = Color.DimGray;
            btnPrevious.Location = new Point(304, 423);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(38, 29);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.ForeColor = Color.DimGray;
            btnNext.Location = new Point(348, 423);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(38, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.ForeColor = Color.DimGray;
            btnLast.Location = new Point(392, 423);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 29);
            btnLast.TabIndex = 5;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // lbPages
            // 
            lbPages.AutoSize = true;
            lbPages.ForeColor = Color.DimGray;
            lbPages.Location = new Point(436, 427);
            lbPages.Name = "lbPages";
            lbPages.Size = new Size(31, 20);
            lbPages.TabIndex = 7;
            lbPages.Text = "1/1";
            // 
            // cbSort
            // 
            cbSort.ForeColor = Color.DimGray;
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "A-Z", "Z-A", "Designer", "Free" });
            cbSort.Location = new Point(147, 424);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(107, 28);
            cbSort.TabIndex = 1;
            cbSort.Tag = "";
            cbSort.Text = "Sort By";
            cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
            // 
            // FindPatterns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 463);
            Controls.Add(cbSort);
            Controls.Add(lbPages);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnGoTo);
            Controls.Add(btnClose);
            Controls.Add(dgvRPatterns);
            Name = "FindPatterns";
            Text = "Ravelry Patterns";
            Load += CrochetHelper_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRPatterns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRPatterns;
        private Button btnClose;
        private Button btnGoTo;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Label lbPages;
        private ComboBox cbSort;
    }
}
