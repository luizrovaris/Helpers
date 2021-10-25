using PoC.BrachControl.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoC.BranchControl
{
    public partial class BranchDetailForm : Form
    {
        public BranchDTO branch;
        private const string _defaultDateValue = "No Release Date";

        public BranchDetailForm(BranchDTO branch)
        {
            InitializeComponent();
            this.branch = branch;
            this.SetDetailValues(this.branch);
        }

        public BranchDetailForm()
        {
            InitializeComponent(); 
            
            linkLabel_BranchDetailReleaseDev.Text = _defaultDateValue;
            linkLabel_BranchDetailReleaseTst.Text = _defaultDateValue;
            linkLabel_BranchDetailReleasePp.Text = _defaultDateValue;
            linkLabel_BranchDetailReleaseProd.Text = _defaultDateValue;
        }

        private void BranchDetailForm_Load(object sender, EventArgs e)
        {            
        }

        private void SetDetailValues(BranchDTO branch)
        {
            textBox_BranchDetailName.Text = this.branch.Name;
            textBox_BranchDetailOrigin.Text = this.branch.Origin;
            richTextBox_BranchDetailNotes.Text = this.branch.Notes;
            dateTimePicker_BranchDetailCreatedDate.Value = this.branch.CreatedDate;
            linkLabel_BranchDetailReleaseDev.Text = this.SetNullabelDateTime(this.branch.ReleaseDev);
            linkLabel_BranchDetailReleaseTst.Text = this.SetNullabelDateTime(this.branch.ReleaseTst);
            linkLabel_BranchDetailReleasePp.Text = this.SetNullabelDateTime(this.branch.ReleasePp);
            linkLabel_BranchDetailReleaseProd.Text = this.SetNullabelDateTime(this.branch.ReleaseProd);
            checkBox_BranchDetailActive.Checked = this.branch.Active;
            richTextBoxScripts.Text = branch.Scripts;
            richTextBoxConfigs.Text = branch.Configs;
        }

        private DateTime? GetNullabelDateTime(LinkLabel component)
        {
            DateTime? value = null;

            if (component.Text != _defaultDateValue)
            {
                value = Convert.ToDateTime(component.Text);
            }

            return value;
        }

        public string SetNullabelDateTime(DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd/MM/yyyy") : _defaultDateValue;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(textBox_BranchDetailName.Text))
            {
                isValid = false;
                textBox_BranchDetailName.BackColor = Color.FromArgb(255, 192, 192);
            }
            if (string.IsNullOrEmpty(textBox_BranchDetailOrigin.Text))
            {
                isValid = false;
                textBox_BranchDetailOrigin.BackColor = Color.FromArgb(255, 192, 192);
            }

            if (isValid)
            {
                if (this.branch == null)
                {
                    this.branch = new BranchDTO();
                }

                this.branch.Name = textBox_BranchDetailName.Text;
                this.branch.Origin = textBox_BranchDetailOrigin.Text;
                this.branch.Notes = richTextBox_BranchDetailNotes.Text;
                this.branch.CreatedDate = dateTimePicker_BranchDetailCreatedDate.Value.Date;
                this.branch.ReleaseDev = this.GetNullabelDateTime(linkLabel_BranchDetailReleaseDev);
                this.branch.ReleaseTst = this.GetNullabelDateTime(linkLabel_BranchDetailReleaseTst);
                this.branch.ReleasePp = this.GetNullabelDateTime(linkLabel_BranchDetailReleasePp);
                this.branch.ReleaseProd = this.GetNullabelDateTime(linkLabel_BranchDetailReleaseProd);
                this.branch.Active = checkBox_BranchDetailActive.Checked;
                this.branch.Scripts = richTextBoxScripts.Text;
                this.branch.Configs = richTextBoxConfigs.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Required fields can not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel_BranchDetailRelease_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dateForm = new ReleaseDateForm();
            LinkLabel linkLabel = (LinkLabel)sender;

            if (dateForm.ShowDialog() == DialogResult.OK)
            {
                DateTime? selectedDate = dateForm?.SelectedDate;
                linkLabel.Text = selectedDate.HasValue ? selectedDate.Value.ToString("dd/MM/yyyy") : _defaultDateValue;
            }

            if (linkLabel.Name == linkLabel_BranchDetailReleaseProd.Name)
            {
                checkBox_BranchDetailActive.Checked = false;
            }
        }
    }
}
