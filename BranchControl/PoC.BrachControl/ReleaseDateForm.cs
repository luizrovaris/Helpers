using System;
using System.Windows.Forms;

namespace PoC.BranchControl
{
    public partial class ReleaseDateForm : Form
    {
        public DateTime? SelectedDate;

        public ReleaseDateForm()
        {
            InitializeComponent();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            this.SelectedDate = dateTimePicker_SelectDate.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Clean_Click(object sender, EventArgs e)
        {
            this.SelectedDate = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
