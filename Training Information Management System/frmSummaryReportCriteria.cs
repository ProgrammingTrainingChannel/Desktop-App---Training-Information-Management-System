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
    public partial class frmSummaryReportCriteria : Form
    {
        public frmSummaryReportCriteria()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            string[] input = new string[2];
            
            frmReportViewer frm = new frmReportViewer();
            string query = "";

            if (cboGroupBy.Text == "Gender")
            {
                input[0] = "TraineeSummaryByGender";
                query += " SELECT Gender, Count(*) AS Counter FROM View_TraineeSummaryByGender GROUP BY Gender HAVING 1=1 ";
            }
            else if (cboGroupBy.Text == "Academic Level")
            {
                input[0] = "TraineeSummaryByAcademicLevel";
                query += " SELECT AcademicLevel, Count(*) AS Counter FROM View_TraineeSummaryByAcademicLevel GROUP BY AcademicLevel HAVING 1=1 ";
            }
            else if (cboGroupBy.Text == "Registration Date")
            {
                input[0] = "TraineeSummaryByRegistrationDate";
                query += " SELECT RegistrationDate, Count(*) AS Counter FROM View_TraineeSummaryByRegistrationDate GROUP BY RegistrationDate HAVING 1=1 ";
            }
            else if (cboGroupBy.Text == "Course")
            {
                input[0] = "TraineeSummaryByCourse";
                query += " SELECT Course, Count(*) AS Counter FROM View_TraineeSummaryByCourse GROUP BY Course HAVING 1=1 ";
            }

            if (chkRegistrationDateFrom.Checked)
            {
                query += " AND RegistrationDate >= '" + dtpRegistrationDateFrom.Value.ToShortDateString() + "'";
            }
            if (chkRegistrationDateTo.Checked)
            {
                query += " AND RegistrationDate <= '" + dtpRegistrationDateTo.Value.ToShortDateString() + "'";
            }

            input[1] = query;

            frm.Tag = input;
            frm.ShowDialog();
        }

        private void frmSummaryReportCriteria_Load(object sender, EventArgs e)
        {
            cboGroupBy.Enabled = false;
            if (this.Tag.ToString() == "SummaryByRegistrationDate")
            {
                cboGroupBy.Text = "Registration Date";
            }
            else if (this.Tag.ToString() == "SummaryByGender")
            {
                cboGroupBy.Text = "Gender";
            }
            else if (this.Tag.ToString() == "SummaryByAcademicLevel")
            {
                cboGroupBy.Text = "Academic Level";
            }
            else if (this.Tag.ToString() == "SummaryByCourse")
            {
                cboGroupBy.Text = "Course";
            }
        }
    }
}
