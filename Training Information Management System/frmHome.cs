using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMS
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void toolStripButtonTrainee_Click(object sender, EventArgs e)
        {
            frmTrainee frmTrainee = new frmTrainee();
            frmTrainee.ShowDialog();
        }

        private void toolStripButtonCourse_Click(object sender, EventArgs e)
        {
            frmCourse frmCourse = new frmCourse();
            frmCourse.ShowDialog();

        }

        private void toolStripButtonTraineeCourse_Click(object sender, EventArgs e)
        {
            frmTraineeCourse frmTraineeCourse = new frmTraineeCourse();
            frmTraineeCourse.Tag = this.Tag.ToString();

            frmTraineeCourse.ShowDialog();
        }

        private void toolStripButtonPayment_Click(object sender, EventArgs e)
        {
            frmTraineePayment frmTraineePayment = new frmTraineePayment();
            frmTraineePayment.Tag = this.Tag.ToString();
            frmTraineePayment.ShowDialog();
        }

        private void toolStripButtonMessage_Click(object sender, EventArgs e)
        {
            frmTraineeMessage frmTraineeMessage = new frmTraineeMessage();
            frmTraineeMessage.ShowDialog();

        }

        private void genderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGender frmGender = new frmGender();
            frmGender.ShowDialog();
        }

        private void academicLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademicLevel frmAcademicLevel = new frmAcademicLevel();
            frmAcademicLevel.ShowDialog();
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
            frmReportViewer frmReportViewer = new frmReportViewer();
            frmReportViewer.ShowDialog();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void traineeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportCriteria frm = new TIMS.frmReportCriteria();
            frm.Tag = "TraineeList";
            frm.ShowDialog();
        }

        private void traineeCourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportCriteria frm = new TIMS.frmReportCriteria();
            frm.Tag = "TraineeCourseList";
            frm.ShowDialog();
        }

        private void traineePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportCriteria frm = new TIMS.frmReportCriteria();
            frm.Tag = "TraineePaymentList";
            frm.ShowDialog();
        }

        private void traineeSummaryByRegistrationDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryReportCriteria frm = new TIMS.frmSummaryReportCriteria();
            frm.Tag = "SummaryByRegistrationDate";
            frm.ShowDialog();
        }

        private void traineeSummaryByGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryReportCriteria frm = new TIMS.frmSummaryReportCriteria();
            frm.Tag = "SummaryByGender";
            frm.ShowDialog();
        }

        private void traineeSummaryByAcademicLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryReportCriteria frm = new TIMS.frmSummaryReportCriteria();
            frm.Tag = "SummaryByAcademicLevel";
            frm.ShowDialog();
        }

        private void traineeSummaryByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryReportCriteria frm = new TIMS.frmSummaryReportCriteria();
            frm.Tag = "SummaryByCourse";
            frm.ShowDialog();
        }

        private void paymentSummaryByPaymentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentSummaryReportCriteria frm = new TIMS.frmPaymentSummaryReportCriteria();
            frm.Tag = "SummaryByPaymentDate";
            frm.ShowDialog();
        }

        private void paymentSummaryByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentSummaryReportCriteria frm = new TIMS.frmPaymentSummaryReportCriteria();
            frm.Tag = "SummaryByCourse";
            frm.ShowDialog();
        }

        private void searchTraineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchTrainee frm = new TIMS.frmSearchTrainee();
            frm.ShowDialog();
        }

        private void manageTraineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainee frm = new TIMS.frmTrainee();
            frm.Tag = this.Tag.ToString();
            frm.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManager frm = new frmUserManager();
            frm.ShowDialog();
        }

        public void ApplySecurityRoles(string username)
        {
            BusinessLogic.UserRoleManager userRoleManager = new BusinessLogic.UserRoleManager();
            List<BusinessEntity.UserRoleEntity> userRoles = userRoleManager.GetAll().Where(x=>x.User.Username == username).ToList();

            //Officer
            manageTraineeToolStripMenuItem.Enabled = false;
            searchTraineeToolStripMenuItem.Enabled = false;

            //Administrator
            manageUserToolStripMenuItem.Enabled = false;

            //Administrator
            toolStripButtonCourse.Enabled = false;

            //Officer
            toolStripButtonTraineeCourse.Enabled = false;

            //Cashier
            toolStripButtonPayment.Enabled = false;

            //reports
            //Officer, Manager, Cashier
            traineeListToolStripMenuItem.Enabled = false;
            traineeCourseListToolStripMenuItem.Enabled = false;
            traineePaymentToolStripMenuItem.Enabled = false;

            //Manager
            traineeSummaryByRegistrationDateToolStripMenuItem.Enabled = false;
            traineeSummaryByGenderToolStripMenuItem.Enabled = false;
            traineeSummaryByAcademicLevelToolStripMenuItem.Enabled = false;
            traineeSummaryByCourseToolStripMenuItem.Enabled = false;

            //Cashier, Manager
            paymentSummaryByPaymentDateToolStripMenuItem.Enabled = false;
            paymentSummaryByCourseToolStripMenuItem.Enabled = false;

            if (userRoles.Where(x => x.Role.Name == "Administrator").Count() > 0)
            {
                manageUserToolStripMenuItem.Enabled = true;

                toolStripButtonCourse.Enabled = true;
            }

            if (userRoles.Where(x => x.Role.Name == "Manager").Count() > 0)
            {
                traineeListToolStripMenuItem.Enabled = true;
                traineeCourseListToolStripMenuItem.Enabled = true;
                traineePaymentToolStripMenuItem.Enabled = true;

                traineeSummaryByRegistrationDateToolStripMenuItem.Enabled = true;
                traineeSummaryByGenderToolStripMenuItem.Enabled = true;
                traineeSummaryByAcademicLevelToolStripMenuItem.Enabled = true;
                traineeSummaryByCourseToolStripMenuItem.Enabled = true;

                paymentSummaryByPaymentDateToolStripMenuItem.Enabled = true;
                paymentSummaryByCourseToolStripMenuItem.Enabled = true;
            }

            if (userRoles.Where(x => x.Role.Name == "Officer").Count() > 0)
            {
                manageTraineeToolStripMenuItem.Enabled = true;
                searchTraineeToolStripMenuItem.Enabled = true;

                toolStripButtonTraineeCourse.Enabled = true;

                traineeListToolStripMenuItem.Enabled = true;
                traineeCourseListToolStripMenuItem.Enabled = true;
                traineePaymentToolStripMenuItem.Enabled = true;
            }

            if (userRoles.Where(x => x.Role.Name == "Cashier").Count() > 0)
            {
                toolStripButtonPayment.Enabled = true;

                traineeListToolStripMenuItem.Enabled = true;
                traineeCourseListToolStripMenuItem.Enabled = true;
                traineePaymentToolStripMenuItem.Enabled = true;

                paymentSummaryByPaymentDateToolStripMenuItem.Enabled = true;
                paymentSummaryByCourseToolStripMenuItem.Enabled = true;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.TIMSDBConnectionString);
                string query = "SELECT Fullname, Title, LastPaymentDate, TotalCost, TotalPaid, TotalLeft FROM View_PaymentNotification";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetDateTime(2).ToShortDateString());
                    item.SubItems.Add(reader.GetDecimal(3).ToString());
                    item.SubItems.Add(reader.GetDecimal(4).ToString());
                    item.SubItems.Add(reader.GetDecimal(5).ToString());

                    listViewNotification.Items.Add(item);
                }

                ApplySecurityRoles(this.Tag.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
