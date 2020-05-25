namespace TIMS
{
    partial class frmSummaryReportCriteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryReportCriteria));
            this.groupBoxTraineeList = new System.Windows.Forms.GroupBox();
            this.cboGroupBy = new System.Windows.Forms.ComboBox();
            this.chkRegistrationDateTo = new System.Windows.Forms.CheckBox();
            this.chkRegistrationDateFrom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRegistrationDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistrationDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.groupBoxTraineeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTraineeList
            // 
            this.groupBoxTraineeList.Controls.Add(this.cboGroupBy);
            this.groupBoxTraineeList.Controls.Add(this.chkRegistrationDateTo);
            this.groupBoxTraineeList.Controls.Add(this.chkRegistrationDateFrom);
            this.groupBoxTraineeList.Controls.Add(this.label2);
            this.groupBoxTraineeList.Controls.Add(this.dtpRegistrationDateTo);
            this.groupBoxTraineeList.Controls.Add(this.dtpRegistrationDateFrom);
            this.groupBoxTraineeList.Controls.Add(this.label3);
            this.groupBoxTraineeList.Controls.Add(this.label1);
            this.groupBoxTraineeList.Location = new System.Drawing.Point(11, 11);
            this.groupBoxTraineeList.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTraineeList.Name = "groupBoxTraineeList";
            this.groupBoxTraineeList.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTraineeList.Size = new System.Drawing.Size(537, 98);
            this.groupBoxTraineeList.TabIndex = 6;
            this.groupBoxTraineeList.TabStop = false;
            // 
            // cboGroupBy
            // 
            this.cboGroupBy.FormattingEnabled = true;
            this.cboGroupBy.Items.AddRange(new object[] {
            "All",
            "Registration Date",
            "Academic Level",
            "Gender",
            "Course"});
            this.cboGroupBy.Location = new System.Drawing.Point(90, 21);
            this.cboGroupBy.Name = "cboGroupBy";
            this.cboGroupBy.Size = new System.Drawing.Size(429, 21);
            this.cboGroupBy.TabIndex = 8;
            // 
            // chkRegistrationDateTo
            // 
            this.chkRegistrationDateTo.AutoSize = true;
            this.chkRegistrationDateTo.Location = new System.Drawing.Point(335, 74);
            this.chkRegistrationDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.chkRegistrationDateTo.Name = "chkRegistrationDateTo";
            this.chkRegistrationDateTo.Size = new System.Drawing.Size(15, 14);
            this.chkRegistrationDateTo.TabIndex = 7;
            this.chkRegistrationDateTo.UseVisualStyleBackColor = true;
            // 
            // chkRegistrationDateFrom
            // 
            this.chkRegistrationDateFrom.AutoSize = true;
            this.chkRegistrationDateFrom.Location = new System.Drawing.Point(90, 74);
            this.chkRegistrationDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.chkRegistrationDateFrom.Name = "chkRegistrationDateFrom";
            this.chkRegistrationDateFrom.Size = new System.Drawing.Size(15, 14);
            this.chkRegistrationDateFrom.TabIndex = 7;
            this.chkRegistrationDateFrom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "እስከ ቀን:";
            // 
            // dtpRegistrationDateTo
            // 
            this.dtpRegistrationDateTo.Location = new System.Drawing.Point(335, 50);
            this.dtpRegistrationDateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRegistrationDateTo.Name = "dtpRegistrationDateTo";
            this.dtpRegistrationDateTo.Size = new System.Drawing.Size(184, 20);
            this.dtpRegistrationDateTo.TabIndex = 2;
            // 
            // dtpRegistrationDateFrom
            // 
            this.dtpRegistrationDateFrom.Location = new System.Drawing.Point(90, 50);
            this.dtpRegistrationDateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRegistrationDateFrom.Name = "dtpRegistrationDateFrom";
            this.dtpRegistrationDateFrom.Size = new System.Drawing.Size(184, 20);
            this.dtpRegistrationDateFrom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ማጠቃለያ መረጃ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ከቀን：";
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.White;
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Image = ((System.Drawing.Image)(resources.GetObject("btnShowReport.Image")));
            this.btnShowReport.Location = new System.Drawing.Point(11, 113);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(537, 71);
            this.btnShowReport.TabIndex = 8;
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // frmSummaryReportCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 193);
            this.Controls.Add(this.groupBoxTraineeList);
            this.Controls.Add(this.btnShowReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSummaryReportCriteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "የሰልጣኝ ማጠቃለያ ረፖርት መምረጫ";
            this.Load += new System.EventHandler(this.frmSummaryReportCriteria_Load);
            this.groupBoxTraineeList.ResumeLayout(false);
            this.groupBoxTraineeList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTraineeList;
        private System.Windows.Forms.CheckBox chkRegistrationDateTo;
        private System.Windows.Forms.CheckBox chkRegistrationDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDateTo;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.ComboBox cboGroupBy;
        private System.Windows.Forms.Label label3;
    }
}