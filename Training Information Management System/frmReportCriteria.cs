using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMS
{
    public partial class frmReportCriteria : Form
    {
        public frmReportCriteria()
        {
            InitializeComponent();
        }

        private void frmReportCriteria_Load(object sender, EventArgs e)
        {
            PopulateCombobox();

            if (this.Tag.ToString() == "TraineeList")
            {
                groupBoxTraineeList.Enabled = true;
                groupBoxTraineeCourseList.Enabled = false;
                groupBoxTraineePaymentList.Enabled = false;
            }
            else if (this.Tag.ToString() == "TraineeCourseList")
            {
                groupBoxTraineeList.Enabled = false;
                groupBoxTraineeCourseList.Enabled = true;
                groupBoxTraineePaymentList.Enabled = false;
            }
            else if (this.Tag.ToString() == "TraineePaymentList")
            {
                groupBoxTraineeList.Enabled = false;
                groupBoxTraineeCourseList.Enabled = false;
                groupBoxTraineePaymentList.Enabled = true;
            }
        }

        private void PopulateCombobox()
        {
            //populate gender
            BusinessLogic.GenderManager genderManager = new BusinessLogic.GenderManager();
            List<BusinessEntity.GenderEntity> genders = genderManager.GetAll();
            genders.Add(new BusinessEntity.GenderEntity() { ID = 0, Title = "All" });

            cboGender.DataSource = genders.OrderBy(x => x.ID).ToList();
            cboGender.ValueMember = "ID";
            cboGender.DisplayMember = "Title";

            //populate academic level
            BusinessLogic.AcademicLevelManager academicLevelManager = new BusinessLogic.AcademicLevelManager();
            List<BusinessEntity.AcademicLevelEntity> academicLevels = academicLevelManager.GetAll();
            academicLevels.Add(new BusinessEntity.AcademicLevelEntity() { ID = 0, Title = "All" });

            cboAcademicLevel.DataSource = academicLevels.OrderBy(x => x.ID).ToList();
            cboAcademicLevel.ValueMember = "ID";
            cboAcademicLevel.DisplayMember = "Title";

            //populate trainee
            BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
            List<BusinessEntity.TraineeEntity> trainees = traineeManager.GetAll();
            trainees.Add(new BusinessEntity.TraineeEntity() { ID = 0, Fullname = "All" });

            cboTrainee.DataSource = trainees.OrderBy(x => x.ID).ToList();
            cboTrainee.ValueMember = "ID";
            cboTrainee.DisplayMember = "Fullname";

            cboTraineePayment.DataSource = trainees.OrderBy(x => x.ID).ToList();
            cboTraineePayment.ValueMember = "ID";
            cboTraineePayment.DisplayMember = "Fullname";

            //populate course
            BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
            List<BusinessEntity.CourseEntity> courses = courseManager.GetAll();
            courses.Add(new BusinessEntity.CourseEntity() { ID = 0, Title = "All" });

            cboCourse.DataSource = courses.OrderBy(x => x.ID).ToList();
            cboCourse.ValueMember = "ID";
            cboCourse.DisplayMember = "Title";

            cboCoursePayment.DataSource = courses.OrderBy(x => x.ID).ToList();
            cboCoursePayment.ValueMember = "ID";
            cboCoursePayment.DisplayMember = "Title";
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            string[] input = new string[2];
            if (this.Tag.ToString() == "TraineeList")
            {
                frmReportViewer frm = new frmReportViewer();
                string query = "SELECT * FROM View_TraineeList WHERE 1=1 ";

                if (chkBirthDateFrom.Checked)
                {
                    query += " AND BirthDate >= '" + dtpBirthDateFrom.Value.ToShortDateString() + "'";
                }
                if (chkBirthDateTo.Checked)
                {
                    query += " AND BirthDate <= '" + dtpBirthDateTo.Value.ToShortDateString() + "'";
                }

                if (cboGender.Text != "All")
                {
                    query += " AND Gender = '" + cboGender.Text + "'";
                }
                if (cboAcademicLevel.Text != "All")
                {
                    query += " AND AcademicLevel = '" + cboAcademicLevel.Text + "'";
                }

                input[0] = "TraineeList";
                input[1] = query;

                frm.Tag = input;
                frm.ShowDialog();
            }
            else if (this.Tag.ToString() == "TraineeCourseList")
            {
                frmReportViewer frm = new TIMS.frmReportViewer();
                string query = "SELECT * FROM View_TraineeCourseList WHERE 1=1 ";
                if (chkBirthDateFrom.Checked)
                {
                    query += " AND RegistrationDate >= '" + dtpRegistrationDateFrom.Value.ToShortDateString() + "'";
                }
                if (chkBirthDateTo.Checked)
                {
                    query += " AND RegistrationDate <= '" + dtpRegistrationDateTo.Value.ToShortDateString() + "'";
                }

                if (cboTrainee.Text != "All")
                {
                    query += " AND Fullname = '" + cboTrainee.Text + "'";
                }
                if (cboCourse.Text != "All")
                {
                    query += " AND Course = '" + cboCourse.Text + "'";
                }

                input[0] = "TraineeCourseList";
                input[1] = query;

                frm.Tag = input;
                frm.ShowDialog();
            }
            else if (this.Tag.ToString() == "TraineePaymentList")
            {
                frmReportViewer frm = new TIMS.frmReportViewer();
                string query = "SELECT * FROM View_TraineePaymentList WHERE 1=1 ";
                if (chkTraineePaymentFrom.Checked)
                {
                    query += " AND PaymentDate >= '" + dtpTraineePaymentFrom.Value.ToShortDateString() + "'";
                }
                if (chkTraineePaymentTo.Checked)
                {
                    query += " AND PaymentDate <= '" + dtpTraineePaymentTo.Value.ToShortDateString() + "'";
                }

                if (cboTraineePayment.Text != "All")
                {
                    query += " AND Fullname = '" + cboTraineePayment.Text + "'";
                }
                if (cboCoursePayment.Text != "All")
                {
                    query += " AND Course = '" + cboCoursePayment.Text + "'";
                }

                input[0] = "TraineePaymentList";
                input[1] = query;

                frm.Tag = input;
                frm.ShowDialog();
            }
        }
    }
}
