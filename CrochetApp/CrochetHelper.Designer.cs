namespace CrochetApp2._0
{
    partial class CrochetHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrochetHelper));
            btnRowCount = new Button();
            btnChangeRow = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnFindPatterns = new Button();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            btnLast = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbChangeRow = new TextBox();
            tbPattern = new TextBox();
            tbCurrentRow = new TextBox();
            dgvUserPatterns = new DataGridView();
            label5 = new Label();
            cbSort = new ComboBox();
            lbPages = new Label();
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserPatterns).BeginInit();
            SuspendLayout();
            // 
            // btnRowCount
            // 
            btnRowCount.BackColor = SystemColors.Window;
            btnRowCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRowCount.ForeColor = Color.DimGray;
            btnRowCount.Location = new Point(12, 39);
            btnRowCount.Name = "btnRowCount";
            btnRowCount.Size = new Size(94, 39);
            btnRowCount.TabIndex = 0;
            btnRowCount.Text = "0/0";
            btnRowCount.UseVisualStyleBackColor = false;
            btnRowCount.Click += btnRowCount_Click;
            // 
            // btnChangeRow
            // 
            btnChangeRow.BackColor = SystemColors.Window;
            btnChangeRow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeRow.ForeColor = Color.DimGray;
            btnChangeRow.Location = new Point(254, 37);
            btnChangeRow.Name = "btnChangeRow";
            btnChangeRow.Size = new Size(56, 29);
            btnChangeRow.TabIndex = 2;
            btnChangeRow.Text = "Go!";
            btnChangeRow.UseVisualStyleBackColor = false;
            btnChangeRow.Click += btnChangeRow_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(12, 435);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.DimGray;
            btnEdit.Location = new Point(79, 435);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(61, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(738, 435);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(73, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DimGray;
            btnSave.Location = new Point(659, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Location = new Point(146, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFindPatterns
            // 
            btnFindPatterns.BackColor = Color.White;
            btnFindPatterns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFindPatterns.ForeColor = Color.DimGray;
            btnFindPatterns.Location = new Point(299, 192);
            btnFindPatterns.Name = "btnFindPatterns";
            btnFindPatterns.Size = new Size(126, 29);
            btnFindPatterns.TabIndex = 9;
            btnFindPatterns.Text = "Find Patterns";
            btnFindPatterns.UseVisualStyleBackColor = false;
            btnFindPatterns.Click += btnFindPatterns_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.White;
            btnFirst.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.ForeColor = Color.DimGray;
            btnFirst.Location = new Point(213, 434);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(38, 29);
            btnFirst.TabIndex = 10;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.ForeColor = Color.DimGray;
            btnPrevious.Location = new Point(257, 434);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(38, 29);
            btnPrevious.TabIndex = 11;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.DimGray;
            btnNext.Location = new Point(301, 434);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(38, 29);
            btnNext.TabIndex = 12;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.White;
            btnLast.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.ForeColor = Color.DimGray;
            btnLast.Location = new Point(345, 434);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(38, 29);
            btnLast.TabIndex = 13;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 12;
            label1.Text = "Row Count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(123, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 13;
            label2.Text = "Change Row:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(445, 9);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 14;
            label3.Text = "Selected Pattern:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 15;
            label4.Text = "Current Row:";
            // 
            // tbChangeRow
            // 
            tbChangeRow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbChangeRow.ForeColor = SystemColors.ControlDarkDark;
            tbChangeRow.Location = new Point(123, 39);
            tbChangeRow.Name = "tbChangeRow";
            tbChangeRow.Size = new Size(125, 27);
            tbChangeRow.TabIndex = 1;
            // 
            // tbPattern
            // 
            tbPattern.BackColor = Color.White;
            tbPattern.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPattern.ForeColor = SystemColors.ControlDarkDark;
            tbPattern.Location = new Point(445, 37);
            tbPattern.Multiline = true;
            tbPattern.Name = "tbPattern";
            tbPattern.ReadOnly = true;
            tbPattern.ScrollBars = ScrollBars.Vertical;
            tbPattern.Size = new Size(369, 391);
            tbPattern.TabIndex = 17;
            tbPattern.Text = resources.GetString("tbPattern.Text");
            // 
            // tbCurrentRow
            // 
            tbCurrentRow.BackColor = SystemColors.Window;
            tbCurrentRow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbCurrentRow.ForeColor = SystemColors.ControlDarkDark;
            tbCurrentRow.Location = new Point(12, 109);
            tbCurrentRow.Multiline = true;
            tbCurrentRow.Name = "tbCurrentRow";
            tbCurrentRow.ReadOnly = true;
            tbCurrentRow.Size = new Size(413, 69);
            tbCurrentRow.TabIndex = 18;
            // 
            // dgvUserPatterns
            // 
            dgvUserPatterns.AllowUserToAddRows = false;
            dgvUserPatterns.AllowUserToDeleteRows = false;
            dgvUserPatterns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserPatterns.Location = new Point(12, 227);
            dgvUserPatterns.Name = "dgvUserPatterns";
            dgvUserPatterns.ReadOnly = true;
            dgvUserPatterns.RowHeadersWidth = 51;
            dgvUserPatterns.RowTemplate.Height = 29;
            dgvUserPatterns.Size = new Size(413, 201);
            dgvUserPatterns.TabIndex = 19;
            dgvUserPatterns.CellClick += dgvUserPatterns_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 196);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 20;
            label5.Text = "Your Patterns:";
            // 
            // cbSort
            // 
            cbSort.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSort.ForeColor = Color.DimGray;
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "A-Z", "Z-A", "Old-New", "New-Old" });
            cbSort.Location = new Point(127, 193);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(103, 28);
            cbSort.TabIndex = 8;
            cbSort.Text = "Sort By";
            cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
            // 
            // lbPages
            // 
            lbPages.AutoSize = true;
            lbPages.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPages.ForeColor = Color.DimGray;
            lbPages.Location = new Point(394, 439);
            lbPages.Name = "lbPages";
            lbPages.Size = new Size(31, 20);
            lbPages.TabIndex = 22;
            lbPages.Text = "1/1";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(94, 140, 103);
            btnInfo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.WhiteSmoke;
            btnInfo.Location = new Point(780, 5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(31, 29);
            btnInfo.TabIndex = 23;
            btnInfo.Text = "?";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // CrochetHelper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(827, 476);
            Controls.Add(btnInfo);
            Controls.Add(lbPages);
            Controls.Add(cbSort);
            Controls.Add(label5);
            Controls.Add(dgvUserPatterns);
            Controls.Add(tbCurrentRow);
            Controls.Add(tbPattern);
            Controls.Add(tbChangeRow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnFindPatterns);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnChangeRow);
            Controls.Add(btnRowCount);
            Location = new Point(200, 300);
            Name = "CrochetHelper";
            StartPosition = FormStartPosition.Manual;
            Text = "Crochet Helper";
            Load += CrochetHelper_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserPatterns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRowCount;
        private Button btnChangeRow;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnExit;
        private Button btnSave;
        private Button btnDelete;
        private Button btnFindPatterns;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbChangeRow;
        private TextBox tbPattern;
        private TextBox tbCurrentRow;
        private DataGridView dgvUserPatterns;
        private Label label5;
        private ComboBox cbSort;
        private Label lbPages;
        private Button btnInfo;
    }
}