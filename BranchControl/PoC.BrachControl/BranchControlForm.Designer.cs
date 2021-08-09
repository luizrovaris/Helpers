
namespace PoC.BrachControl
{
    partial class BranchControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchControlForm));
            this.groupBox_Branches = new System.Windows.Forms.GroupBox();
            this.dataGridView_Branches = new System.Windows.Forms.DataGridView();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_FilterOrigin = new System.Windows.Forms.TextBox();
            this.label_FilterOrigin = new System.Windows.Forms.Label();
            this.label_CreatedBetweenAnd = new System.Windows.Forms.Label();
            this.dateTimePicker_CreatedBetweenAnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_CreatedBetween = new System.Windows.Forms.DateTimePicker();
            this.label_FilterCreatedBetween = new System.Windows.Forms.Label();
            this.checkBox_FilterActiveOnly = new System.Windows.Forms.CheckBox();
            this.button_FilterSearch = new System.Windows.Forms.Button();
            this.textBox_FilterName = new System.Windows.Forms.TextBox();
            this.label_FilterName = new System.Windows.Forms.Label();
            this.button_AddBranch = new System.Windows.Forms.Button();
            this.button_SaveAll = new System.Windows.Forms.Button();
            this.lblBranchesCount = new System.Windows.Forms.Label();
            this.groupBox_Branches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branches)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Branches
            // 
            this.groupBox_Branches.Controls.Add(this.dataGridView_Branches);
            this.groupBox_Branches.Location = new System.Drawing.Point(12, 187);
            this.groupBox_Branches.Name = "groupBox_Branches";
            this.groupBox_Branches.Size = new System.Drawing.Size(1560, 557);
            this.groupBox_Branches.TabIndex = 0;
            this.groupBox_Branches.TabStop = false;
            this.groupBox_Branches.Text = "Branches";
            // 
            // dataGridView_Branches
            // 
            this.dataGridView_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Branches.Location = new System.Drawing.Point(7, 30);
            this.dataGridView_Branches.Name = "dataGridView_Branches";
            this.dataGridView_Branches.RowHeadersVisible = false;
            this.dataGridView_Branches.RowHeadersWidth = 62;
            this.dataGridView_Branches.RowTemplate.Height = 33;
            this.dataGridView_Branches.Size = new System.Drawing.Size(1547, 515);
            this.dataGridView_Branches.TabIndex = 0;
            this.dataGridView_Branches.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Branches_CellContentDoubleClick);
            this.dataGridView_Branches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Branches_CellDoubleClick);
            this.dataGridView_Branches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Branches_Changed);
            this.dataGridView_Branches.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_Branches_Changed);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.textBox_FilterOrigin);
            this.groupBox_Filter.Controls.Add(this.label_FilterOrigin);
            this.groupBox_Filter.Controls.Add(this.label_CreatedBetweenAnd);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_CreatedBetweenAnd);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_CreatedBetween);
            this.groupBox_Filter.Controls.Add(this.label_FilterCreatedBetween);
            this.groupBox_Filter.Controls.Add(this.checkBox_FilterActiveOnly);
            this.groupBox_Filter.Controls.Add(this.button_FilterSearch);
            this.groupBox_Filter.Controls.Add(this.textBox_FilterName);
            this.groupBox_Filter.Controls.Add(this.label_FilterName);
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(1560, 113);
            this.groupBox_Filter.TabIndex = 1;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox_FilterOrigin
            // 
            this.textBox_FilterOrigin.Location = new System.Drawing.Point(135, 67);
            this.textBox_FilterOrigin.Name = "textBox_FilterOrigin";
            this.textBox_FilterOrigin.Size = new System.Drawing.Size(454, 31);
            this.textBox_FilterOrigin.TabIndex = 8;
            // 
            // label_FilterOrigin
            // 
            this.label_FilterOrigin.AutoSize = true;
            this.label_FilterOrigin.Location = new System.Drawing.Point(7, 70);
            this.label_FilterOrigin.Name = "label_FilterOrigin";
            this.label_FilterOrigin.Size = new System.Drawing.Size(65, 25);
            this.label_FilterOrigin.TabIndex = 7;
            this.label_FilterOrigin.Text = "Origin:";
            // 
            // label_CreatedBetweenAnd
            // 
            this.label_CreatedBetweenAnd.AutoSize = true;
            this.label_CreatedBetweenAnd.Location = new System.Drawing.Point(924, 70);
            this.label_CreatedBetweenAnd.Name = "label_CreatedBetweenAnd";
            this.label_CreatedBetweenAnd.Size = new System.Drawing.Size(49, 25);
            this.label_CreatedBetweenAnd.TabIndex = 6;
            this.label_CreatedBetweenAnd.Text = "And:";
            // 
            // dateTimePicker_CreatedBetweenAnd
            // 
            this.dateTimePicker_CreatedBetweenAnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreatedBetweenAnd.Location = new System.Drawing.Point(979, 67);
            this.dateTimePicker_CreatedBetweenAnd.Name = "dateTimePicker_CreatedBetweenAnd";
            this.dateTimePicker_CreatedBetweenAnd.Size = new System.Drawing.Size(352, 31);
            this.dateTimePicker_CreatedBetweenAnd.TabIndex = 4;
            // 
            // dateTimePicker_CreatedBetween
            // 
            this.dateTimePicker_CreatedBetween.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_CreatedBetween.Location = new System.Drawing.Point(979, 30);
            this.dateTimePicker_CreatedBetween.Name = "dateTimePicker_CreatedBetween";
            this.dateTimePicker_CreatedBetween.Size = new System.Drawing.Size(352, 31);
            this.dateTimePicker_CreatedBetween.TabIndex = 3;
            // 
            // label_FilterCreatedBetween
            // 
            this.label_FilterCreatedBetween.AutoSize = true;
            this.label_FilterCreatedBetween.Location = new System.Drawing.Point(825, 30);
            this.label_FilterCreatedBetween.Name = "label_FilterCreatedBetween";
            this.label_FilterCreatedBetween.Size = new System.Drawing.Size(148, 25);
            this.label_FilterCreatedBetween.TabIndex = 4;
            this.label_FilterCreatedBetween.Text = "Created Between:";
            // 
            // checkBox_FilterActiveOnly
            // 
            this.checkBox_FilterActiveOnly.AutoSize = true;
            this.checkBox_FilterActiveOnly.Checked = true;
            this.checkBox_FilterActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FilterActiveOnly.Location = new System.Drawing.Point(595, 71);
            this.checkBox_FilterActiveOnly.Name = "checkBox_FilterActiveOnly";
            this.checkBox_FilterActiveOnly.Size = new System.Drawing.Size(128, 29);
            this.checkBox_FilterActiveOnly.TabIndex = 2;
            this.checkBox_FilterActiveOnly.Text = "Active Only";
            this.checkBox_FilterActiveOnly.UseVisualStyleBackColor = true;
            // 
            // button_FilterSearch
            // 
            this.button_FilterSearch.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_FilterSearch.Image = ((System.Drawing.Image)(resources.GetObject("button_FilterSearch.Image")));
            this.button_FilterSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_FilterSearch.Location = new System.Drawing.Point(1422, 56);
            this.button_FilterSearch.Name = "button_FilterSearch";
            this.button_FilterSearch.Size = new System.Drawing.Size(132, 50);
            this.button_FilterSearch.TabIndex = 5;
            this.button_FilterSearch.Text = "Search";
            this.button_FilterSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_FilterSearch.UseVisualStyleBackColor = true;
            this.button_FilterSearch.Click += new System.EventHandler(this.button_FilterSearch_Click);
            // 
            // textBox_FilterName
            // 
            this.textBox_FilterName.Location = new System.Drawing.Point(135, 30);
            this.textBox_FilterName.Name = "textBox_FilterName";
            this.textBox_FilterName.Size = new System.Drawing.Size(588, 31);
            this.textBox_FilterName.TabIndex = 1;
            // 
            // label_FilterName
            // 
            this.label_FilterName.AutoSize = true;
            this.label_FilterName.Location = new System.Drawing.Point(7, 31);
            this.label_FilterName.Name = "label_FilterName";
            this.label_FilterName.Size = new System.Drawing.Size(121, 25);
            this.label_FilterName.TabIndex = 0;
            this.label_FilterName.Text = "Branch Name:";
            // 
            // button_AddBranch
            // 
            this.button_AddBranch.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddBranch.Image = ((System.Drawing.Image)(resources.GetObject("button_AddBranch.Image")));
            this.button_AddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddBranch.Location = new System.Drawing.Point(12, 131);
            this.button_AddBranch.Name = "button_AddBranch";
            this.button_AddBranch.Size = new System.Drawing.Size(132, 50);
            this.button_AddBranch.TabIndex = 6;
            this.button_AddBranch.Tag = "";
            this.button_AddBranch.Text = "Add";
            this.button_AddBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddBranch.UseVisualStyleBackColor = true;
            this.button_AddBranch.Click += new System.EventHandler(this.button_AddBranch_Click);
            // 
            // button_SaveAll
            // 
            this.button_SaveAll.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SaveAll.Image = ((System.Drawing.Image)(resources.GetObject("button_SaveAll.Image")));
            this.button_SaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_SaveAll.Location = new System.Drawing.Point(1440, 750);
            this.button_SaveAll.Name = "button_SaveAll";
            this.button_SaveAll.Size = new System.Drawing.Size(132, 50);
            this.button_SaveAll.TabIndex = 12;
            this.button_SaveAll.Text = "Save";
            this.button_SaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SaveAll.UseVisualStyleBackColor = true;
            this.button_SaveAll.Click += new System.EventHandler(this.button_SaveAll_Click);
            // 
            // lblBranchesCount
            // 
            this.lblBranchesCount.AutoSize = true;
            this.lblBranchesCount.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBranchesCount.Location = new System.Drawing.Point(19, 750);
            this.lblBranchesCount.Name = "lblBranchesCount";
            this.lblBranchesCount.Size = new System.Drawing.Size(19, 25);
            this.lblBranchesCount.TabIndex = 13;
            this.lblBranchesCount.Text = "-";
            // 
            // BranchControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 812);
            this.Controls.Add(this.lblBranchesCount);
            this.Controls.Add(this.button_SaveAll);
            this.Controls.Add(this.button_AddBranch);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.groupBox_Branches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BranchControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BranchControlForm_FormClosing);
            this.Load += new System.EventHandler(this.BranchControlForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BranchControlForm_KeyDown);
            this.groupBox_Branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branches)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Branches;
        private System.Windows.Forms.DataGridView dataGridView_Branches;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Button button_FilterSearch;
        private System.Windows.Forms.TextBox textBox_FilterName;
        private System.Windows.Forms.Label label_FilterName;
        private System.Windows.Forms.CheckBox checkBox_FilterActiveOnly;
        private System.Windows.Forms.Label label_CreatedBetweenAnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreatedBetweenAnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CreatedBetween;
        private System.Windows.Forms.Label label_FilterCreatedBetween;
        private System.Windows.Forms.Button button_AddBranch;
        private System.Windows.Forms.Button button_SaveAll;
        private System.Windows.Forms.Label lblBranchesCount;
        private System.Windows.Forms.TextBox textBox_FilterOrigin;
        private System.Windows.Forms.Label label_FilterOrigin;
    }
}

