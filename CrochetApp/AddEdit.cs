using CrochetApp2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrochetApp2._0
{
    public partial class AddEdit : Form
    {
        public AddEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets UI values based on inputed pattern
        /// </summary>
        private void AddEdit_Load(object sender, EventArgs e)
        {
            UserPattern? pattern = this.Tag as UserPattern;

            if (pattern != null)
            {
                tbName.Text = pattern.Name;
                tbPattern.Text = pattern.Pattern;
                cbxRowCount.Checked = pattern.UseRowCounter;

                // checks if pattern is being added
                if (pattern.Name == "")
                    this.Text = "Add Pattern";
                else
                    this.Text = "Edit Pattern";
            }
        }

        /// <summary>
        /// Creates new pattern, makes sure it's valid, then sends the data back to CrochetHelper form
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserPattern newPattern = new UserPattern(tbName.Text, tbPattern.Text, cbxRowCount.Checked);
            string msg = Validation.IsValidPattern(newPattern);

            if (msg != "")
            {
                MessageBox.Show(msg, "Input Error");
            }
            else
            {
                if (!cbxRowCount.Checked) { newPattern.Rows = new List<string>(); }
                this.Tag = newPattern;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Closes form without adding/editing pattern
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
