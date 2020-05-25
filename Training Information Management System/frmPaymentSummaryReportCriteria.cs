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
    public partial class frmPaymentSummaryReportCriteria : Form
    {
        public frmPaymentSummaryReportCriteria()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            this.Hide();

            string[] input = new string[2];

            frmReportViewer frm = new frmReportViewer();
            string query = "";

            if (cboGroupBy.Text == "Payment Date")
            {
                input[0] = "PaymentSummaryByPaymentDate";
                query += " SELECT PaymentDate, SUM(PaymentAmount) AS PaymentAmount FROM View_TraineePaymentByPaymentDate GROUP BY PaymentDate HAVING 1=1 ";
            }
            else if (cboGroupBy.Text == "Course")
            {
                input[0] = "PaymentSummaryByCourse";
                query += " SELECT Course, SUM(PaymentAmount) AS PaymentAmount FROM View_TraineePaymentByCourse GROUP BY Course HAVING 1=1 ";
            }

            if (chkPaymentDateFrom.Checked)
            {
                query += " AND PaymentDate >= '" + dtpPaymentDateFrom.Value.ToShortDateString() + "'";
            }
            if (chkPaymentDateTo.Checked)
            {
                query += " AND PaymentDate <= '" + dtpPaymentDateTo.Value.ToShortDateString() + "'";
            }

            input[1] = query;

            frm.Tag = input;
            frm.ShowDialog();
        }

        private void frmPaymentSummaryReportCriteria_Load(object sender, EventArgs e)
        {
            cboGroupBy.Enabled = false;
            if (this.Tag.ToString() == "SummaryByPaymentDate")
            {
                cboGroupBy.Text = "Payment Date";
            }
            else if (this.Tag.ToString() == "SummaryByCourse")
            {
                cboGroupBy.Text = "Course";
            }
        }
    }
}
