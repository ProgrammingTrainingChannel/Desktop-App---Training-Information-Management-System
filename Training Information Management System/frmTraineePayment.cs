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
    public partial class frmTraineePayment : Form
    {
        public frmTraineePayment()
        {
            InitializeComponent();
        }

        private void frmTraineePayment_Load(object sender, EventArgs e)
        {
            this.Tag = "Bereket";

            LoadTraineePayments();

            BusinessLogic.TraineeCourseManager traineeCourseManager = new BusinessLogic.TraineeCourseManager();
            List<BusinessEntity.TraineeCourseCostEntity> traineeCourseCosts = traineeCourseManager.GetAllTraineeCourseCost();

            cboTraineeCourse.DataSource = traineeCourseCosts;
            cboTraineeCourse.ValueMember = "ID";
            cboTraineeCourse.DisplayMember = "TraineeCourseDetail";
        }

        private void LoadTraineePayments()
        {
            BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
            List<BusinessEntity.TraineePaymentEntity> traineePaymentEntities = traineePaymentManager.GetAll();

            listViewTraineePayment.Items.Clear();
            if (traineePaymentEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.TraineePaymentEntity traineePaymentEntity in traineePaymentEntities)
                {
                    ListViewItem item = new ListViewItem(traineePaymentEntity.ID.ToString());
                    item.SubItems.Add(traineePaymentEntity.TraineeCourseEntity.TraineeEntity.Fullname);
                    item.SubItems.Add(traineePaymentEntity.TraineeCourseEntity.CourseEntity.Title);
                    item.SubItems.Add(traineePaymentEntity.PaymentDate.ToString());
                    item.SubItems.Add(traineePaymentEntity.PaymentAmount.ToString());

                    listViewTraineePayment.Items.Add(item);
                }
            }
        }

        private void listViewTraineePayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTraineePayment.SelectedItems.Count > 0)
            {
                int traineePaymentID = int.Parse(listViewTraineePayment.SelectedItems[0].SubItems[0].Text);
                BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
                BusinessEntity.TraineePaymentEntity traineePayment = traineePaymentManager.GetSingle(traineePaymentID);

                cboTraineeCourse.Text = string.Empty;
                cboTraineeCourse.SelectedText = traineePayment.TraineeCourseEntity.TraineeEntity.Fullname + "  ( " + traineePayment.TraineeCourseEntity.CourseEntity.Title + "  -  "  + traineePayment.TraineeCourseEntity.Duration + "  -  " + traineePayment.TraineeCourseEntity.Cost + "  )";
                dtpPaymentDate.Text = traineePayment.PaymentDate.ToString();
                txtPaymentAmount.Text = traineePayment.PaymentAmount.ToString();
            }
        }

        private bool IsValid()
        {
            if (cboTraineeCourse.Text == string.Empty)
            {
                MessageBox.Show("Please enter trainee course");
                return false;
            }
            else if (txtPaymentAmount.Text == string.Empty)
            {
                MessageBox.Show("Please enter payment amount");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
                    BusinessEntity.TraineePaymentEntity traineePayment = new BusinessEntity.TraineePaymentEntity();
                    traineePayment.TraineeCourseEntity = new BusinessEntity.TraineeCourseEntity();
                    traineePayment.TraineeCourseEntity.ID = int.Parse(cboTraineeCourse.SelectedValue.ToString());

                    traineePayment.PaymentDate = dtpPaymentDate.Value;
                    traineePayment.PaymentAmount = decimal.Parse(txtPaymentAmount.Text);
                    traineePayment.CreatedBy = this.Tag.ToString();
                    traineePayment.CreatedDate = DateTime.Now;

                    traineePaymentManager.Save(traineePayment);
                    MessageBox.Show("Trainee Course's Payment Information Saved Successfully.");
                    LoadTraineePayments();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Save Failed, Please try again.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewTraineePayment.SelectedItems.Count > 0)
            {
                try
                {
                    if (IsValid())
                    {
                        int traineePaymentID = int.Parse(listViewTraineePayment.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
                        BusinessEntity.TraineePaymentEntity oldTraineePayment = traineePaymentManager.GetSingle(traineePaymentID);

                        BusinessEntity.TraineePaymentEntity newTraineePayment = new BusinessEntity.TraineePaymentEntity();

                        newTraineePayment.ID = traineePaymentID;
                        newTraineePayment.TraineeCourseEntity = new BusinessEntity.TraineeCourseEntity();
                        newTraineePayment.TraineeCourseEntity.ID = int.Parse(cboTraineeCourse.SelectedValue.ToString());

                        newTraineePayment.PaymentDate = dtpPaymentDate.Value;
                        newTraineePayment.PaymentAmount = decimal.Parse(txtPaymentAmount.Text);

                        newTraineePayment.CreatedBy = oldTraineePayment.CreatedBy;
                        newTraineePayment.CreatedDate = oldTraineePayment.CreatedDate;
                        newTraineePayment.UpdatedBy = this.Tag.ToString();
                        newTraineePayment.UpdatedDate = DateTime.Now;

                        traineePaymentManager.Update(newTraineePayment);

                        MessageBox.Show("Trainee Course's Payment Information Updated Successfully.");
                        LoadTraineePayments();
                    }
                }
                catch (Exception ex)
                {
                    //save to log table
                    MessageBox.Show("Update Failed, Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select trainee's course from the list first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTraineePayment.SelectedItems.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        int traineePaymentID = int.Parse(listViewTraineePayment.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
                        BusinessEntity.TraineePaymentEntity oldTraineePayment = traineePaymentManager.GetSingle(traineePaymentID);

                        traineePaymentManager.Delete(oldTraineePayment);
                        MessageBox.Show("Trainee Course's Payment Information Deleted Successfully.");
                        LoadTraineePayments();
                    }
                }
                catch (Exception ex)
                {
                    //save to log table
                    MessageBox.Show("Delete Failed, Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select trainee payment from the list first.");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboTraineeCourse.Text = string.Empty;
            dtpPaymentDate.Value = DateTime.Today;
            txtPaymentAmount.Text = string.Empty;
        }

        private void cboTraineeCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
            int traineeCourseID = ((BusinessEntity.TraineeCourseCostEntity)cboTraineeCourse.SelectedItem).ID;
            int result = traineePaymentManager.CalculatePaymentAmountLeft(traineeCourseID, Properties.Settings.Default.TIMSDBConnectionString);

            txtAmountLeft.Text = result.ToString();
        }
    }
}
