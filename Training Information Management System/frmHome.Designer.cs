namespace TIMS
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonTrainee = new System.Windows.Forms.ToolStripDropDownButton();
            this.manageTraineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTraineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTraineeCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPayment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.traineeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeCourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeSummaryByRegistrationDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeSummaryByGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeSummaryByAcademicLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeSummaryByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentSummaryByPaymentDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentSummaryByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.listViewNotification = new System.Windows.Forms.ListView();
            this.columnHeaderFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastPaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonTrainee,
            this.toolStripSeparator1,
            this.toolStripButtonCourse,
            this.toolStripSeparator2,
            this.toolStripButtonTraineeCourse,
            this.toolStripSeparator8,
            this.toolStripButtonPayment,
            this.toolStripSeparator3,
            this.toolStripButtonReport,
            this.toolStripSeparator6,
            this.toolStripButtonAbout,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1362, 132);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonTrainee
            // 
            this.toolStripDropDownButtonTrainee.BackColor = System.Drawing.Color.White;
            this.toolStripDropDownButtonTrainee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonTrainee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTraineeToolStripMenuItem,
            this.searchTraineeToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripDropDownButtonTrainee.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonTrainee.Image")));
            this.toolStripDropDownButtonTrainee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButtonTrainee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonTrainee.Name = "toolStripDropDownButtonTrainee";
            this.toolStripDropDownButtonTrainee.Size = new System.Drawing.Size(263, 129);
            this.toolStripDropDownButtonTrainee.Text = "Manage Trainee";
            this.toolStripDropDownButtonTrainee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // manageTraineeToolStripMenuItem
            // 
            this.manageTraineeToolStripMenuItem.Name = "manageTraineeToolStripMenuItem";
            this.manageTraineeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageTraineeToolStripMenuItem.Text = "ሰልጣኝ መከታተያ";
            this.manageTraineeToolStripMenuItem.Click += new System.EventHandler(this.manageTraineeToolStripMenuItem_Click);
            // 
            // searchTraineeToolStripMenuItem
            // 
            this.searchTraineeToolStripMenuItem.Name = "searchTraineeToolStripMenuItem";
            this.searchTraineeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchTraineeToolStripMenuItem.Text = "ሰልጣኝ መፈለጊያ";
            this.searchTraineeToolStripMenuItem.Click += new System.EventHandler(this.searchTraineeToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageUserToolStripMenuItem.Text = "የተጠቃሚ መከታተያ";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 132);
            // 
            // toolStripButtonCourse
            // 
            this.toolStripButtonCourse.BackColor = System.Drawing.Color.White;
            this.toolStripButtonCourse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCourse.Image")));
            this.toolStripButtonCourse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCourse.Name = "toolStripButtonCourse";
            this.toolStripButtonCourse.Size = new System.Drawing.Size(254, 129);
            this.toolStripButtonCourse.Text = "ስልጠናዎች መከታተያ";
            this.toolStripButtonCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCourse.Click += new System.EventHandler(this.toolStripButtonCourse_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 132);
            // 
            // toolStripButtonTraineeCourse
            // 
            this.toolStripButtonTraineeCourse.BackColor = System.Drawing.Color.White;
            this.toolStripButtonTraineeCourse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTraineeCourse.Image")));
            this.toolStripButtonTraineeCourse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTraineeCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTraineeCourse.Name = "toolStripButtonTraineeCourse";
            this.toolStripButtonTraineeCourse.Size = new System.Drawing.Size(254, 129);
            this.toolStripButtonTraineeCourse.Text = "የሰልጣኞች ስልጠና መከታተያ";
            this.toolStripButtonTraineeCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTraineeCourse.Click += new System.EventHandler(this.toolStripButtonTraineeCourse_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 132);
            // 
            // toolStripButtonPayment
            // 
            this.toolStripButtonPayment.BackColor = System.Drawing.Color.White;
            this.toolStripButtonPayment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPayment.Image")));
            this.toolStripButtonPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPayment.Name = "toolStripButtonPayment";
            this.toolStripButtonPayment.Size = new System.Drawing.Size(254, 129);
            this.toolStripButtonPayment.Text = "ክፍያ መከታተያ";
            this.toolStripButtonPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPayment.Click += new System.EventHandler(this.toolStripButtonPayment_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 132);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.BackColor = System.Drawing.Color.White;
            this.toolStripButtonReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traineeListToolStripMenuItem,
            this.traineeCourseListToolStripMenuItem,
            this.traineePaymentToolStripMenuItem,
            this.traineeSummaryByRegistrationDateToolStripMenuItem,
            this.traineeSummaryByGenderToolStripMenuItem,
            this.traineeSummaryByAcademicLevelToolStripMenuItem,
            this.traineeSummaryByCourseToolStripMenuItem,
            this.paymentSummaryByPaymentDateToolStripMenuItem,
            this.paymentSummaryByCourseToolStripMenuItem});
            this.toolStripButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReport.Image")));
            this.toolStripButtonReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(263, 129);
            this.toolStripButtonReport.Text = "ሪፖርቶች";
            this.toolStripButtonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // traineeListToolStripMenuItem
            // 
            this.traineeListToolStripMenuItem.Name = "traineeListToolStripMenuItem";
            this.traineeListToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeListToolStripMenuItem.Text = "የሰልጣኞች ዝርዝር";
            this.traineeListToolStripMenuItem.Click += new System.EventHandler(this.traineeListToolStripMenuItem_Click);
            // 
            // traineeCourseListToolStripMenuItem
            // 
            this.traineeCourseListToolStripMenuItem.Name = "traineeCourseListToolStripMenuItem";
            this.traineeCourseListToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeCourseListToolStripMenuItem.Text = "የሰልጣኞች ስልጠና ዝርዝር";
            this.traineeCourseListToolStripMenuItem.Click += new System.EventHandler(this.traineeCourseListToolStripMenuItem_Click);
            // 
            // traineePaymentToolStripMenuItem
            // 
            this.traineePaymentToolStripMenuItem.Name = "traineePaymentToolStripMenuItem";
            this.traineePaymentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineePaymentToolStripMenuItem.Text = "የሰልጣኞች ክፍያ ዝርዝር";
            this.traineePaymentToolStripMenuItem.Click += new System.EventHandler(this.traineePaymentToolStripMenuItem_Click);
            // 
            // traineeSummaryByRegistrationDateToolStripMenuItem
            // 
            this.traineeSummaryByRegistrationDateToolStripMenuItem.Name = "traineeSummaryByRegistrationDateToolStripMenuItem";
            this.traineeSummaryByRegistrationDateToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeSummaryByRegistrationDateToolStripMenuItem.Text = "የሰልጣኞች ማጠቃለያ በቀን";
            this.traineeSummaryByRegistrationDateToolStripMenuItem.Click += new System.EventHandler(this.traineeSummaryByRegistrationDateToolStripMenuItem_Click);
            // 
            // traineeSummaryByGenderToolStripMenuItem
            // 
            this.traineeSummaryByGenderToolStripMenuItem.Name = "traineeSummaryByGenderToolStripMenuItem";
            this.traineeSummaryByGenderToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeSummaryByGenderToolStripMenuItem.Text = "የሰልጣኞች ማጠቃለያ በጾታ";
            this.traineeSummaryByGenderToolStripMenuItem.Click += new System.EventHandler(this.traineeSummaryByGenderToolStripMenuItem_Click);
            // 
            // traineeSummaryByAcademicLevelToolStripMenuItem
            // 
            this.traineeSummaryByAcademicLevelToolStripMenuItem.Name = "traineeSummaryByAcademicLevelToolStripMenuItem";
            this.traineeSummaryByAcademicLevelToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeSummaryByAcademicLevelToolStripMenuItem.Text = "የሰልጣኞች ማጠቃለያ በትምህርት ደረጃ";
            this.traineeSummaryByAcademicLevelToolStripMenuItem.Click += new System.EventHandler(this.traineeSummaryByAcademicLevelToolStripMenuItem_Click);
            // 
            // traineeSummaryByCourseToolStripMenuItem
            // 
            this.traineeSummaryByCourseToolStripMenuItem.Name = "traineeSummaryByCourseToolStripMenuItem";
            this.traineeSummaryByCourseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.traineeSummaryByCourseToolStripMenuItem.Text = "የሰልጣኞች ማጠቃለያ በስልጠና";
            this.traineeSummaryByCourseToolStripMenuItem.Click += new System.EventHandler(this.traineeSummaryByCourseToolStripMenuItem_Click);
            // 
            // paymentSummaryByPaymentDateToolStripMenuItem
            // 
            this.paymentSummaryByPaymentDateToolStripMenuItem.Name = "paymentSummaryByPaymentDateToolStripMenuItem";
            this.paymentSummaryByPaymentDateToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.paymentSummaryByPaymentDateToolStripMenuItem.Text = "የክፍያ ማጠቃለያ በቀን";
            this.paymentSummaryByPaymentDateToolStripMenuItem.Click += new System.EventHandler(this.paymentSummaryByPaymentDateToolStripMenuItem_Click);
            // 
            // paymentSummaryByCourseToolStripMenuItem
            // 
            this.paymentSummaryByCourseToolStripMenuItem.Name = "paymentSummaryByCourseToolStripMenuItem";
            this.paymentSummaryByCourseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.paymentSummaryByCourseToolStripMenuItem.Text = "የክፍያ ማጠቃለያ በስልጠና";
            this.paymentSummaryByCourseToolStripMenuItem.Click += new System.EventHandler(this.paymentSummaryByCourseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 132);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.BackColor = System.Drawing.Color.White;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(254, 129);
            this.toolStripButtonAbout.Text = "ስለሰራው ድርጅት";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 132);
            // 
            // listViewNotification
            // 
            this.listViewNotification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFullname,
            this.columnHeaderTitle,
            this.columnHeaderLastPaymentDate,
            this.columnHeaderTotalCost,
            this.columnHeaderTotalPaid,
            this.columnHeaderTotalLeft});
            this.listViewNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNotification.Location = new System.Drawing.Point(0, 269);
            this.listViewNotification.Name = "listViewNotification";
            this.listViewNotification.Size = new System.Drawing.Size(1362, 161);
            this.listViewNotification.TabIndex = 2;
            this.listViewNotification.UseCompatibleStateImageBehavior = false;
            this.listViewNotification.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFullname
            // 
            this.columnHeaderFullname.Text = "ሙሉ ስም";
            this.columnHeaderFullname.Width = 251;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "የስልጠና ርእስ";
            this.columnHeaderTitle.Width = 341;
            // 
            // columnHeaderLastPaymentDate
            // 
            this.columnHeaderLastPaymentDate.Text = "መጨረሻ የተከፈለበት ቀን";
            this.columnHeaderLastPaymentDate.Width = 177;
            // 
            // columnHeaderTotalCost
            // 
            this.columnHeaderTotalCost.Text = "ጠቅላላ የሚከፈል";
            this.columnHeaderTotalCost.Width = 171;
            // 
            // columnHeaderTotalPaid
            // 
            this.columnHeaderTotalPaid.Text = "ጠቅላላ የተከፈለ";
            this.columnHeaderTotalPaid.Width = 148;
            // 
            // columnHeaderTotalLeft
            // 
            this.columnHeaderTotalLeft.Text = "የሚከፈል ቀሪ";
            this.columnHeaderTotalLeft.Width = 210;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "ተጠቃሚ ቀይር";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1362, 430);
            this.Controls.Add(this.listViewNotification);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "የሰልጣኝ መረጃ መከታተያ ሲስተም";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCourse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonTraineeCourse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonReport;
        private System.Windows.Forms.ToolStripMenuItem traineeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeCourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeSummaryByRegistrationDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeSummaryByGenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeSummaryByAcademicLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeSummaryByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentSummaryByPaymentDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentSummaryByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTrainee;
        private System.Windows.Forms.ToolStripMenuItem searchTraineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTraineeToolStripMenuItem;
        private System.Windows.Forms.ListView listViewNotification;
        private System.Windows.Forms.ColumnHeader columnHeaderFullname;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderLastPaymentDate;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalCost;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalPaid;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalLeft;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}