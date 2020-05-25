using Microsoft.Reporting.WinForms;
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
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            ShowReport();

            this.reportViewer1.RefreshReport();
        }

        private void ShowReport()
        {
            string[] parameter = (string[])this.Tag;

            //show trainee list report
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.TIMSDBConnectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(parameter[1], connection);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            reportViewer1.Reset();

            this.reportViewer1.LocalReport.DataSources.Clear();

            if (parameter[0] == "TraineeList")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineeList";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeList.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeList.rdlc";
            }
            else if (parameter[0] == "TraineeCourseList")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineeCourseList";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeCourseList.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeCourseList.rdlc";
            }
            else if (parameter[0] == "TraineePaymentList")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineePaymentList";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineePaymentList.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineePaymentList.rdlc";
            }
            else if (parameter[0] == "TraineeSummaryByRegistrationDate")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineeSummaryByRegistrationDate";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeSummaryByRegistrationDate.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeSummaryByRegistrationDate.rdlc";
            }
            else if (parameter[0] == "TraineeSummaryByGender")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineeSummaryByGender";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeSummaryByGender.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeSummaryByGender.rdlc";
            }
            else if (parameter[0] == "TraineeSummaryByAcademicLevel")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DatasetTraineeSummaryByAcademicLevel";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeSummaryByAcademicLevel.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeSummaryByAcademicLevel.rdlc";
            }
            else if (parameter[0] == "TraineeSummaryByCourse")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DataSetTraineeSummaryByCourse";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineeSummaryByCourse.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineeSummaryByCourse.rdlc";
            }
            else if (parameter[0] == "PaymentSummaryByPaymentDate")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DataSetTraineePaymentSummaryByPaymentDate";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineePaymentSummaryByPaymentDate.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineePaymentSummaryByPaymentDate.rdlc";
            }
            else if (parameter[0] == "PaymentSummaryByCourse")
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Value = ds.Tables[0];
                reportDataSource.Name = "DataSetTraineePaymentSummaryByCourse";

                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Reports\\rptTraineePaymentSummaryByCourse.rdlc";
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "rptTraineePaymentSummaryByCourse.rdlc";
            }
        }
    }
}
