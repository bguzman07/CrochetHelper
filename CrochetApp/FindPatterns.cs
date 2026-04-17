using CrochetApp2._0.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CrochetApp2._0
{
    public partial class FindPatterns : Form
    {
    #region Variables
        private RavelryResponse data;
        private int rowIndex = 0;

        // Paging variables
        private const int MaxRows = 13;
        private int totalRows = 0;
        private int pages = 0;
        private int pageNumber = 1;
        private string sortBy = "";
    #endregion

    #region On Load
        public FindPatterns()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Connects form to Ravelry API and displays information in the DGV
        /// </summary>
        private async void CrochetHelper_Load(object sender, EventArgs e)
        {
            try
            {
                // Gets access from ravelRy API 
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(30);

                var byteArray = Encoding.ASCII.GetBytes("read-be67bc58b74385a21b88a0ed00ac3755:PJ1c2jhoS3Jm8BiTeasgKeXBInTHU7jFBHufmQJ0");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                // MessageBox.Show("Sending request..."); 

                var response = await client.GetAsync("https://api.ravelry.com/patterns/search.json?craft=crochet");
                // MessageBox.Show($"Status: {response.StatusCode}"); 

                string result = await response.Content.ReadAsStringAsync();
                // MessageBox.Show("Got response!"); 

                data = JsonConvert.DeserializeObject<RavelryResponse>(result);

                if (this.IsDisposed)
                    return;
                else
                    UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            } 
        }

    #endregion

    #region List

        #region Events

        /// <summary>
        /// Sets row index when cell is clicked
        /// </summary>
        private void dgvRPatterns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        /// <summary>
        /// Directs user to the Ravelry pattern on their browser based on the selected cell
        /// </summary>
        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (rowIndex > -1)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"https://www.ravelry.com/patterns/library/{dgvRPatterns.Rows[rowIndex].Cells[3].Value}",
                    UseShellExecute = true
                });
            }
        }

        /// <summary>
        /// Sets the sortBy variable according to selected index
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
                sortBy = "designer";
            }
            if (cbSort.SelectedIndex == 3)
            {
                sortBy = "free";
            }

            UpdateList();
        }

        /// <summary>
        /// Displays the first page in DGV
        /// </summary>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            UpdateList();
        }

        /// <summary>
        /// Displays the previous page in DGV
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageNumber -= 1;
            UpdateList();
        }

        /// <summary>
        /// Displays the next page in DGV
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            UpdateList();
        }

        /// <summary>
        /// Displays the last page in DGV
        /// </summary>
        private void btnLast_Click(object sender, EventArgs e)
        {
            pageNumber = pages;
            UpdateList();
        }

        /// <summary>
        /// Closes form
        /// </summary>
        private async void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Updates the items in the DGV
        /// </summary>
        private void UpdateList()
        {
            totalRows = data.patterns.Count;
            pages = totalRows / MaxRows;
            if (totalRows % MaxRows != 0)
            {
                pages++;
            }
            DisplayListPage();
        }

        /// <summary>
        /// Displays the page of items in the DGV
        /// </summary>
        private void DisplayListPage()
        {
            int skip = MaxRows * (pageNumber - 1);
            int take = MaxRows;

            if (pageNumber == MaxRows)
                take = totalRows - skip;

            if (totalRows <= MaxRows)
                take = totalRows;

            SetDataSource(skip, take);

            FormatList();
            EnableDisableButtons();

            lbPages.Text = pageNumber + "/" + pages;
        }

        /// <summary>
        /// Sets the data source based on the sortBy variable
        /// </summary>
        /// <param name="skip">Number of rows to skip</param>
        /// <param name="take">Number of rows to display</param>
        private void SetDataSource(int skip, int take)
        {
            if (sortBy == "alphaAscend")
            {
                dgvRPatterns.DataSource = data.patterns
                    .Select(p => new
                    {
                        p.free,
                        p.id,
                        p.name,
                        p.permalink,
                        DesignerId = p.designer?.id,
                        DesignerName = p.designer?.name
                    })
                    .OrderBy(p => p.name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else if (sortBy == "alphaDescend")
            {
                dgvRPatterns.DataSource = data.patterns
                    .Select(p => new
                    {
                        p.free,
                        p.id,
                        p.name,
                        p.permalink,
                        DesignerId = p.designer?.id,
                        DesignerName = p.designer?.name
                    })
                    .OrderByDescending(p => p.name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else if (sortBy == "designer")
            {
                dgvRPatterns.DataSource = data.patterns
                    .Select(p => new
                    {
                        p.free,
                        p.id,
                        p.name,
                        p.permalink,
                        DesignerId = p.designer?.id,
                        DesignerName = p.designer?.name
                    })
                    .OrderBy(p => p.DesignerName)
                    .ThenBy(p => p.DesignerId)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else if (sortBy == "free")
            {
                dgvRPatterns.DataSource = data.patterns
                    .Select(p => new
                    {
                        p.free,
                        p.id,
                        p.name,
                        p.permalink,
                        DesignerId = p.designer?.id,
                        DesignerName = p.designer?.name
                    })
                    .OrderByDescending(p => p.free)
                    .ThenBy(p => p.name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else
            {
                dgvRPatterns.DataSource = data.patterns
                    .Select(p => new
                    {
                        p.free,
                        p.id,
                        p.name,
                        p.permalink,
                        DesignerId = p.designer?.id,
                        DesignerName = p.designer?.name
                    })
                    .OrderBy(p => p.name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
        }

        /// <summary>
        /// Designs the layout for DGV
        /// </summary>
        private void FormatList()
        {
            dgvRPatterns.EnableHeadersVisualStyles = false;

            dgvRPatterns.Columns[0].HeaderText = "Free";
            dgvRPatterns.Columns[0].Width = 50;

            dgvRPatterns.Columns[1].Visible = false;

            dgvRPatterns.Columns[2].HeaderText = "Pattern Name";
            dgvRPatterns.Columns[2].Width = 305;

            dgvRPatterns.Columns[3].Visible = false;
            dgvRPatterns.Columns[4].Visible = false;

            dgvRPatterns.Columns[5].HeaderText = "Designer";
            dgvRPatterns.Columns[5].Width = 164;

            CrochetHelper.StyleDGV(dgvRPatterns);
        }

        /// <summary>
        /// Enables/disables the arrow buttons based on current page number
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

    }
}
