using CrochetApp2._0.Models;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace CrochetApp2._0
{
    public partial class CrochetHelper : Form
    {
    #region Starting Variables

        // Local variables for user patterns
        public List<UserPattern> userPatterns = new List<UserPattern>();
        public UserPattern currentPattern = null;

        // Paging variables
        private const int MaxRows = 6;
        private int totalRows = 0;
        private int pages = 0;
        private int pageNumber = 1;
        private string sortBy = "dateDescend";

        // Used to know when to check for patterns with the same name
        public static bool isAdd;

        // Stores the tutorial text
        public string infoMessage = "";

        // Variables used so the user can only open one findPatterns form at a time
        private bool isFindPatterns = false;
        private Form findPatterns = new FindPatterns();

        #endregion Start Variables

    #region On Load
        public CrochetHelper()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the position of the form 300 pixels to the left, displays the user's patterns, and opens the FindPatterns form
        /// </summary>
        private void CrochetHelper_Load(object sender, EventArgs e)
        {
            int centerX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int centerY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(centerX - 300, centerY);

            infoMessage = tbPattern.Text;
            tbPattern.Text = "";
            userPatterns = PatternDB.GetPatterns();
            UpdateList();

            btnFindPatterns_Click(sender, e);
        }

        #endregion

    #region Basic Buttons

        /// <summary>
        /// Opens the Ravelry Patterns form
        /// </summary>
        private void btnFindPatterns_Click(object sender, EventArgs e)
        {
            if (!isFindPatterns || findPatterns.IsDisposed == true)
            {
                isFindPatterns = true;
                findPatterns = new FindPatterns();
                findPatterns.StartPosition = FormStartPosition.Manual;
                findPatterns.Location = new Point(this.Right, this.Top);
                findPatterns.Show();
            }
            else
            {
                isFindPatterns = false;
                findPatterns.Close();
            }
        }

        /// <summary>
        /// Toggles the tutorial text
        /// </summary>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (tbPattern.Text == infoMessage)
            {
                if (currentPattern != null)
                {
                    tbPattern.Text = currentPattern.Pattern;
                }
                else
                {
                    tbPattern.Text = "";
                }
            }
            else
            {
                tbPattern.Text = infoMessage;
            }
        }

        /// <summary>
        /// Saves the patterns with UpdatePatterns()
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePatterns();
        }

        /// <summary>
        /// Saves patterns with UpdatePatterns() and closes form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            UpdatePatterns();
            this.Close();
        }

        #endregion

    #region Row Counter
        // This region consists of the two events that update the row counter feature

        /// <summary>
        /// Goes to next row and sets UI values accordingly
        /// </summary>
        private void btnRowCount_Click(object sender, EventArgs e)
        {
            if (currentPattern != null)
            {
                if (currentPattern.RowIndex != currentPattern.Rows.Count - 1)
                {
                    currentPattern.RowIndex += 1;
                    DisplayPattern(currentPattern);
                }
                else
                {
                    MessageBox.Show("Congrats! You finished the pattern.", "Pattern Finished");
                }
            }
        }

        /// <summary>
        /// Makes sure tbChangeRow is in correct format and sets currentRow.RowIndex to the inputed number
        /// </summary>
        private void btnChangeRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPattern != null)
                {
                    int index = Convert.ToInt32(tbChangeRow.Text);

                    if (index <= currentPattern.Rows.Count && index >= 1)
                    {
                        currentPattern.RowIndex = index - 1;
                        DisplayPattern(currentPattern);
                        PatternDB.SavePatterns(userPatterns);
                    }
                    else
                    {
                        MessageBox.Show($"Please enter an integer within the range of 1 and {currentPattern.Rows.Count}.", "Input Error");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a integer into the Change Row text box.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        #endregion

    #region Database events and methods involving DGV
        #region Events

        /// <summary>
        /// Sets the currentPattern variable to the pattern belonging to the row clicked
        /// </summary>
        private void dgvUserPatterns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePatterns();
            if (e.RowIndex != -1)
            {
                string name = dgvUserPatterns.Rows[e.RowIndex].Cells[0].Value.ToString();
                UserPattern pattern = PatternDB.GetPatternByName(name);

                if (pattern != null)
                {
                    currentPattern = pattern;
                    DisplayPattern(pattern);
                }
            }
        }

        /// <summary>
        /// Sets the sortBy variable according to the selected index and updates the list
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                sortBy = "alphaAscend";
            }
            if (cbSort.SelectedIndex == 1)
            {
                sortBy = "alphaDescend";
            }
            if (cbSort.SelectedIndex == 2)
            {
                sortBy = "dateAscend";
            }
            if (cbSort.SelectedIndex == 3)
            {
                sortBy = "dateDescend";
            }

            UpdateList();
        }

        /// <summary>
        /// Creates a new empty pattern and uses SetPattern()
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            UserPattern pattern = new UserPattern("", "", false);
            SetPattern(pattern);
        }

        /// <summary>
        /// Takes the currentPattern and uses SetPattern()
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentPattern != null)
            {
                isAdd = false;
                SetPattern(currentPattern);
            }
        }

        /// <summary>
        /// Asks user if currentPattern is to be deleted, then removes it from the list and resets the text boxes
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentPattern != null)
            {
                DialogResult button = MessageBox.Show($"Delete {currentPattern.Name}?", "Delete Pattern", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (button == DialogResult.OK)
                {
                    userPatterns.RemoveAll(p => p.Name == currentPattern.Name);
                    PatternDB.SavePatterns(userPatterns);
                    UpdateList();

                    tbPattern.Text = "";
                    tbCurrentRow.Text = "";
                    btnRowCount.Text = "0/0";
                }
            }
            currentPattern = null;
        }

        /// <summary>
        /// Sets the DGV page number to 1
        /// </summary>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            DisplayListPage();
        }

        /// <summary>
        /// Subtracts 1 from the DGV current page number
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageNumber -= 1;
            DisplayListPage();
        }

        /// <summary>
        /// Adds 1 to the DGV current page number
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            DisplayListPage();
        }

        /// <summary>
        /// Sets the current page number to the last page
        /// </summary>
        private void btnLast_Click(object sender, EventArgs e)
        {
            pageNumber = pages;
            DisplayListPage();
        }

        #endregion
        #region Styles and Display methods for DGV

        /// <summary>
        /// Adds the saved patterns to the DGV and calls FormatList()
        /// </summary>
        private void UpdateList()
        {
            totalRows = userPatterns.Count;
            pages = totalRows / 6;
            if (totalRows % 6 != 0)
                pages++;
            DisplayListPage();
        }

        /// <summary>
        /// Displays the current page of the list of items going into the DGV
        /// </summary>
        private void DisplayListPage()
        {
            int skip = MaxRows * (pageNumber - 1);
            int take = MaxRows;

            if (pageNumber == MaxRows)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }

            SetDataSource(skip, take);

            FormatList();
            EnableDisableButtons();

            lbPages.Text = pageNumber + "/" + pages;
        }

        /// <summary>
        /// Sets the data source for the DGV according to the sortBy variable and both the skip and take variables for paging
        /// </summary>
        /// <param name="skip">Number of rows to be skipped</param>
        /// <param name="take">Number of rows to display</param>
        private void SetDataSource(int skip, int take)
        {
            if (sortBy == "alphaAscend")
            {
                dgvUserPatterns.DataSource = PatternDB.GetPatterns()
                .Select(p => new
                {
                    p.Name,
                    p.Pattern,
                    p.RowIndex,
                    p.DateUpdated
                })
                .OrderBy(p => p.Name)
                .Skip(skip)
                .Take(take)
                .ToList();
            }
            if (sortBy == "alphaDescend")
            {
                dgvUserPatterns.DataSource = PatternDB.GetPatterns()
                .Select(p => new
                {
                    p.Name,
                    p.Pattern,
                    p.RowIndex,
                    p.DateUpdated
                })
                .OrderByDescending(p => p.Name)
                .Skip(skip)
                .Take(take)
                .ToList();
            }
            if (sortBy == "dateAscend")
            {
                dgvUserPatterns.DataSource = PatternDB.GetPatterns()
                .Select(p => new
                {
                    p.Name,
                    p.Pattern,
                    p.RowIndex,
                    p.DateUpdated
                })
                .OrderBy(p => p.DateUpdated)
                .Skip(skip)
                .Take(take)
                .ToList();
            }
            if (sortBy == "dateDescend")
            {
                dgvUserPatterns.DataSource = PatternDB.GetPatterns()
                .Select(p => new
                {
                    p.Name,
                    p.Pattern,
                    p.RowIndex,
                    p.DateUpdated
                })
                .OrderByDescending(p => p.DateUpdated)
                .Skip(skip)
                .Take(take)
                .ToList();
            }
        }

        /// <summary>
        /// Designs the layout of the "Your Patterns" data grid view
        /// </summary>
        private void FormatList()
        {
            dgvUserPatterns.EnableHeadersVisualStyles = false;

            dgvUserPatterns.Columns[0].HeaderText = "Name";
            dgvUserPatterns.Columns[0].Width = 212;

            dgvUserPatterns.Columns[1].Visible = false;
            dgvUserPatterns.Columns[2].Visible = false;

            dgvUserPatterns.Columns[3].HeaderText = "Date Updated";
            dgvUserPatterns.Columns[3].Width = 148;

            StyleDGV(dgvUserPatterns);
        }

        /// <summary>
        /// Colors the inputed data grid view
        /// </summary>
        /// <param name="dataGridView">Data grid view to be styled</param>
        public static void StyleDGV(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
            dataGridView.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.DarkSlateGray;
        }

        /// <summary>
        /// Enables and/or disables buttons according to the current page number
        /// </summary>
        private void EnableDisableButtons()
        {
            if (pageNumber == 1)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }

            if (pageNumber == pages)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }

        #endregion 
    #endregion

    #region Methods Using DataBase

            /// <summary>
            /// Updates the userPatterns list and saves the patterns with PatternDB.SavePatterns()
            /// </summary>
            private void UpdatePatterns()
            {
                if (currentPattern != null)
                {
                    int index = userPatterns.FindIndex(p => p.Name == currentPattern.Name);
                    if (index > -1)
                    {
                        userPatterns.RemoveAt(index);
                        userPatterns.Insert(index, currentPattern);
                    }
                }
                PatternDB.SavePatterns(userPatterns);
            }

            /// <summary>
            /// Opens AddEdit form, gets the pattern given by form, and sets all UI values
            /// </summary>
            /// <param name="thisPattern">The pattern that will be inputed into the AddEdit form</param>
            private void SetPattern(UserPattern thisPattern)
            {
                Form AddForm = new AddEdit();
                AddForm.Tag = thisPattern;
                DialogResult result = AddForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    UserPattern? pattern = AddForm.Tag as UserPattern;
                    if (isAdd)
                    {
                        userPatterns.Add(pattern);
                    }
                    else
                    {
                        // checks if pattern with same name exists and replaces it (updates)
                        if (pattern.Name == currentPattern.Name)
                        {
                            int index = userPatterns.FindIndex(p => p.Name == pattern.Name);
                            userPatterns.RemoveAt(index);
                            userPatterns.Insert(index, pattern);
                        }
                        // adds as new pattern
                        else
                        {
                            userPatterns.Add(pattern);
                        }
                    }
                    currentPattern = pattern;

                    DisplayPattern(pattern);
                    PatternDB.SavePatterns(userPatterns);
                    UpdateList();
                }
            }

            /// <summary>
            /// Displays info from the inputed pattern into the according textboxes
            /// </summary>
            /// <param name="pattern">Pattern to be displayed</param>
            private void DisplayPattern(UserPattern pattern)
            {
                tbPattern.Text = pattern.Pattern;
                if (!pattern.UseRowCounter)
                {
                    tbCurrentRow.Enabled = false;
                    btnChangeRow.Enabled = false;
                    btnRowCount.Enabled = false;

                    tbChangeRow.Text = "";
                    tbCurrentRow.Text = "";
                    btnRowCount.Text = "0/0";
                }
                else
                {
                    tbCurrentRow.Enabled = true;
                    btnChangeRow.Enabled = true;
                    btnRowCount.Enabled = true;

                    tbCurrentRow.Text = pattern.Rows[pattern.RowIndex];
                    btnRowCount.Text = pattern.RowIndex + 1 + "/" + pattern.Rows.Count.ToString();
                }
            }
        
            #endregion

    }
}
