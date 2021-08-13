using Newtonsoft.Json;
using PoC.BrachControl.DTO;
using PoC.BranchControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PoC.BrachControl
{
    public partial class BranchControlForm : Form
    {
        private const string _fileName = "branch_control.json";
        private readonly string _currentPath = "";
        private bool dataGridViewHasChanges;

        public BranchControlForm()
        {
            _currentPath = Path.Combine(Directory.GetCurrentDirectory(), _fileName);

            InitializeComponent();
        }

        private void BranchControlForm_Load(object sender, EventArgs e)
        {
            this.SetFilters();
            this.LoadDataGridView();
            this.dataGridViewHasChanges = false;
        }

        private void SetFilters()
        {
            this.dateTimePicker_CreatedBetween.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_CreatedBetweenAnd.Value = DateTime.Now;
        }

        private void LoadDataGridView()
        {
            List<BranchDTO> branches = this.GetAllBranchesFromFile();

            if (checkBox_FilterActiveOnly.Checked)
            {
                branches = branches.Where(x => x.Active == true).ToList();
            }

            if (!string.IsNullOrWhiteSpace(textBox_FilterName.Text))
            {
                branches = branches.Where(x => x.Name.Contains(textBox_FilterName.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(textBox_FilterOrigin.Text))
            {
                branches = branches.Where(x => x.Origin.Contains(textBox_FilterOrigin.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }

            branches = branches.Where(x => x.CreatedDate >= dateTimePicker_CreatedBetween.Value
                                        && x.CreatedDate <= dateTimePicker_CreatedBetweenAnd.Value).ToList();

            lblBranchesCount.Text = branches.Count.ToString();
            dataGridView_Branches.DataSource = branches;
            SetDataGridViewLayout();
        }

        private void SetDataGridViewLayout()
        {
            dataGridView_Branches.Columns["ReleaseDev"].Visible = false;
            dataGridView_Branches.Columns["ReleaseTst"].Visible = false;
            dataGridView_Branches.Columns["ReleasePp"].Visible = false;
            dataGridView_Branches.Columns["ReleaseProd"].Visible = false;
            dataGridView_Branches.Columns["Scripts"].Visible = false;

            int totalWidth = dataGridView_Branches.Width;

            int widthLittle = (int)(totalWidth * 0.04);
            int widthSmall = (int)(totalWidth * 0.05);
            int widthMedium = (int)(totalWidth * 0.07);
            int widthLarge = (int)(totalWidth * 0.24);

            dataGridView_Branches.Columns["Id"].Width = widthLittle;
            dataGridView_Branches.Columns["Name"].Width = widthLarge;
            dataGridView_Branches.Columns["Notes"].Width = widthLarge;
            dataGridView_Branches.Columns["Origin"].Width = widthLarge;
            dataGridView_Branches.Columns["CreatedDate"].Width = widthMedium;
            dataGridView_Branches.Columns["Active"].Width = widthSmall;
            dataGridView_Branches.Columns["HasScripts"].Width = widthMedium;
            dataGridView_Branches.Columns["Env"].Width = widthSmall;
            //dataGridView_Branches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private List<BranchDTO> GetBranchesFromGrid()
        {
            var branches = new List<BranchDTO>();

            foreach (DataGridViewRow row in dataGridView_Branches.Rows)
            {
                BranchDTO branch = row.DataBoundItem as BranchDTO;
                branches.Add(branch);
            }

            return branches;
        }

        private List<BranchDTO> GetAllBranchesFromFile()
        {
            List<BranchDTO> branches = null;

            try
            {
                FileStream fileStream = File.Open(_currentPath, FileMode.OpenOrCreate);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string json = reader.ReadToEnd();
                    branches = JsonConvert.DeserializeObject<List<BranchDTO>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return branches ?? new List<BranchDTO>();
        }

        private void SaveFile(BranchDTO branch)
        {
            List<BranchDTO> branches = this.GetBranchesFromGrid();
            List<BranchDTO> allbranches = this.GetAllBranchesFromFile();

            branches.AddRange(allbranches.Where(ab => !(branches.Any(b => b.Id == ab.Id))));

            if (branch != null)
            {
                if (branch.Id == 0)
                {
                    branch.Id = branches.Any() ? branches.Max(x => x.Id) + 1 : 1;
                    branches.Add(branch);
                }
                else
                {
                    BranchDTO currentBranch = branches.FirstOrDefault(x => x.Id == branch.Id);
                    currentBranch = branch;
                }
            }

            File.WriteAllText(_currentPath, JsonConvert.SerializeObject(branches.OrderBy(x => x.Id).ToList()));

            MessageBox.Show("All current informations saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenBranchDetail(BranchDTO branch)
        {
            BranchDetailForm branchDetailForm;

            if (branch != null)
            {
                branchDetailForm = new BranchDetailForm(branch);
            }
            else
            {
                branchDetailForm = new BranchDetailForm();
            }

            if (branchDetailForm.ShowDialog() == DialogResult.OK)
            {
                branch = branchDetailForm.branch;

                this.SaveFile(branch);
                this.LoadDataGridView();
            }
        }

        private void EditBranchDetail(int rowIndex)
        {
            BranchDTO branch = dataGridView_Branches.Rows[rowIndex].DataBoundItem as BranchDTO;
            this.OpenBranchDetail(branch);
        }

        private void button_AddBranch_Click(object sender, EventArgs e)
        {
            this.OpenBranchDetail(null);
        }

        private void button_FilterSearch_Click(object sender, EventArgs e)
        {
            this.LoadDataGridView();
        }

        private void dataGridView_Branches_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditBranchDetail(e.RowIndex);
        }

        private void dataGridView_Branches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.EditBranchDetail(e.RowIndex);
            }
        }

        private void button_SaveAll_Click(object sender, EventArgs e)
        {
            this.SaveFile(null);
            this.dataGridViewHasChanges = false;
        }

        private void BranchControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                this.button_AddBranch_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                this.button_SaveAll_Click(sender, e);
            }
        }

        private void dataGridView_Branches_Changed(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewHasChanges = true;
        }

        private void dataGridView_Branches_Changed(object sender, EventArgs e)
        {
            this.dataGridViewHasChanges = true;
        }

        private void BranchControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dataGridViewHasChanges)
            {
                DialogResult result = MessageBox.Show("There are no saved changes. Do you want to save the changes?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                e.Cancel = (result == DialogResult.Yes);
            }
        }
    }
}
