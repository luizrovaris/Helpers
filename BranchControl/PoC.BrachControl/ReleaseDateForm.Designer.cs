
namespace PoC.BranchControl
{
    partial class ReleaseDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseDateForm));
            this.button_Select = new System.Windows.Forms.Button();
            this.groupBox_ReleaseDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.button_Clean = new System.Windows.Forms.Button();
            this.groupBox_ReleaseDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Select
            // 
            this.button_Select.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Select.Image = ((System.Drawing.Image)(resources.GetObject("button_Select.Image")));
            this.button_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Select.Location = new System.Drawing.Point(189, 97);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(132, 50);
            this.button_Select.TabIndex = 12;
            this.button_Select.Text = "Select";
            this.button_Select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // groupBox_ReleaseDate
            // 
            this.groupBox_ReleaseDate.Controls.Add(this.dateTimePicker_SelectDate);
            this.groupBox_ReleaseDate.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ReleaseDate.Name = "groupBox_ReleaseDate";
            this.groupBox_ReleaseDate.Size = new System.Drawing.Size(309, 79);
            this.groupBox_ReleaseDate.TabIndex = 13;
            this.groupBox_ReleaseDate.TabStop = false;
            this.groupBox_ReleaseDate.Text = "Select a release date";
            // 
            // dateTimePicker_SelectDate
            // 
            this.dateTimePicker_SelectDate.Location = new System.Drawing.Point(6, 30);
            this.dateTimePicker_SelectDate.Name = "dateTimePicker_SelectDate";
            this.dateTimePicker_SelectDate.Size = new System.Drawing.Size(291, 31);
            this.dateTimePicker_SelectDate.TabIndex = 0;
            // 
            // button_Clean
            // 
            this.button_Clean.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Clean.Image = ((System.Drawing.Image)(resources.GetObject("button_Clean.Image")));
            this.button_Clean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Clean.Location = new System.Drawing.Point(12, 97);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(132, 50);
            this.button_Clean.TabIndex = 14;
            this.button_Clean.Text = "Clean";
            this.button_Clean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // ReleaseDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 155);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.groupBox_ReleaseDate);
            this.Controls.Add(this.button_Select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Date";
            this.groupBox_ReleaseDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.GroupBox groupBox_ReleaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SelectDate;
        private System.Windows.Forms.Button button_Clean;
    }
}