namespace TIMS
{
    partial class frmSearchTrainee
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
            this.listViewTrainee = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSearchGender = new System.Windows.Forms.ComboBox();
            this.txtSearchFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAcademicLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchTrainee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewTrainee
            // 
            this.listViewTrainee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFullname,
            this.columnHeaderPhoneNumber});
            this.listViewTrainee.FullRowSelect = true;
            this.listViewTrainee.Location = new System.Drawing.Point(13, 63);
            this.listViewTrainee.Name = "listViewTrainee";
            this.listViewTrainee.Size = new System.Drawing.Size(415, 504);
            this.listViewTrainee.TabIndex = 0;
            this.listViewTrainee.UseCompatibleStateImageBehavior = false;
            this.listViewTrainee.View = System.Windows.Forms.View.Details;
            this.listViewTrainee.SelectedIndexChanged += new System.EventHandler(this.listViewTrainee_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "መለያ";
            this.columnHeaderID.Width = 0;
            // 
            // columnHeaderFullname
            // 
            this.columnHeaderFullname.Text = "ሙሉ ስም";
            this.columnHeaderFullname.Width = 203;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "ስልክ ቁጥር";
            this.columnHeaderPhoneNumber.Width = 179;
            // 
            // cboSearchGender
            // 
            this.cboSearchGender.FormattingEnabled = true;
            this.cboSearchGender.Location = new System.Drawing.Point(74, 13);
            this.cboSearchGender.Name = "cboSearchGender";
            this.cboSearchGender.Size = new System.Drawing.Size(354, 21);
            this.cboSearchGender.TabIndex = 1;
            // 
            // txtSearchFullname
            // 
            this.txtSearchFullname.Location = new System.Drawing.Point(74, 37);
            this.txtSearchFullname.Name = "txtSearchFullname";
            this.txtSearchFullname.Size = new System.Drawing.Size(354, 20);
            this.txtSearchFullname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ጾታ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ሙሉ ስም:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxPhoto);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboAcademicLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(432, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(497, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(328, 17);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(159, 154);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 8;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(102, 155);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ስልክ ቁጥር:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 127);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "አድራሻ:";
            // 
            // cboAcademicLevel
            // 
            this.cboAcademicLevel.FormattingEnabled = true;
            this.cboAcademicLevel.Location = new System.Drawing.Point(101, 100);
            this.cboAcademicLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cboAcademicLevel.Name = "cboAcademicLevel";
            this.cboAcademicLevel.Size = new System.Drawing.Size(223, 21);
            this.cboAcademicLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "የትምህርት ደረጃ:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(102, 72);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(222, 21);
            this.cboGender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ጾታ:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(102, 44);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(222, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "የልደት ቀን:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(102, 17);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(222, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ሙሉ ስም:";
            // 
            // btnSearchTrainee
            // 
            this.btnSearchTrainee.BackColor = System.Drawing.Color.White;
            this.btnSearchTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrainee.Location = new System.Drawing.Point(434, 13);
            this.btnSearchTrainee.Name = "btnSearchTrainee";
            this.btnSearchTrainee.Size = new System.Drawing.Size(495, 43);
            this.btnSearchTrainee.TabIndex = 6;
            this.btnSearchTrainee.Text = "ሰልጣኝ ፈለግ";
            this.btnSearchTrainee.UseVisualStyleBackColor = false;
            this.btnSearchTrainee.Click += new System.EventHandler(this.btnSearchTrainee_Click);
            // 
            // frmSearchTrainee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 579);
            this.Controls.Add(this.btnSearchTrainee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchFullname);
            this.Controls.Add(this.cboSearchGender);
            this.Controls.Add(this.listViewTrainee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchTrainee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ሰልጣኝ መፈለጊያ";
            this.Load += new System.EventHandler(this.frmSearchTrainee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTrainee;
        private System.Windows.Forms.ComboBox cboSearchGender;
        private System.Windows.Forms.TextBox txtSearchFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAcademicLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchTrainee;
        private System.Windows.Forms.ColumnHeader columnHeaderFullname;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
    }
}