namespace CrochetApp2._0
{
    partial class AddEdit
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            tbName = new TextBox();
            tbPattern = new TextBox();
            cbxRowCount = new CheckBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(379, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Pattern Name:";
            // 
            // tbName
            // 
            tbName.Location = new Point(120, 6);
            tbName.Name = "tbName";
            tbName.Size = new Size(353, 27);
            tbName.TabIndex = 0;
            // 
            // tbPattern
            // 
            tbPattern.Location = new Point(12, 39);
            tbPattern.Multiline = true;
            tbPattern.Name = "tbPattern";
            tbPattern.ScrollBars = ScrollBars.Vertical;
            tbPattern.Size = new Size(461, 302);
            tbPattern.TabIndex = 1;
            // 
            // cbxRowCount
            // 
            cbxRowCount.AutoSize = true;
            cbxRowCount.Location = new Point(120, 352);
            cbxRowCount.Name = "cbxRowCount";
            cbxRowCount.Size = new Size(144, 24);
            cbxRowCount.TabIndex = 3;
            cbxRowCount.Text = "Use Row Counter";
            cbxRowCount.UseVisualStyleBackColor = true;
            // 
            // AddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 386);
            Controls.Add(cbxRowCount);
            Controls.Add(tbPattern);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "AddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit";
            Load += AddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private TextBox tbName;
        private TextBox tbPattern;
        private CheckBox cbxRowCount;
    }
}