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
    public partial class frmTraineeCourse : Form
    {
        public frmTraineeCourse()
        {
            InitializeComponent();
        }

        private void frmTraineeCourse_Load(object sender, EventArgs e)
        {
            this.Tag = "Bereket";

            LoadTraineeCourses();

            BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
            List<BusinessEntity.TraineeEntity> trainees = traineeManager.GetAll();

            cboTrainee.DataSource = trainees;
            cboTrainee.ValueMember = "ID";
            cboTrainee.DisplayMember = "Fullname";

            BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
            List<BusinessEntity.CourseEntity> courses = courseManager.GetAll();

            cboCourse.DataSource = courses;
            cboCourse.ValueMember = "ID";
            cboCourse.DisplayMember = "Title";
        }


        private void LoadTraineeCourses()
        {
            BusinessLogic.TraineeCourseManager traineeCourseManager = new BusinessLogic.TraineeCourseManager();
            List<BusinessEntity.TraineeCourseEntity> traineeCourseEntities = traineeCourseManager.GetAll();

            listViewTraineeCourse.Items.Clear();
            if (traineeCourseEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.TraineeCourseEntity traineeCourseEntity in traineeCourseEntities)
                {
                    ListViewItem item = new ListViewItem(traineeCourseEntity.ID.ToString());
                    item.SubItems.Add(traineeCourseEntity.TraineeEntity.Fullname);
                    item.SubItems.Add(traineeCourseEntity.CourseEntity.Title);
                    item.SubItems.Add(traineeCourseEntity.RegistrationDate.ToString());
                    item.SubItems.Add(traineeCourseEntity.Duration);
                    item.SubItems.Add(traineeCourseEntity.Cost.ToString());

                    listViewTraineeCourse.Items.Add(item);
                }
            }
        }

        private void listViewTraineeCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTraineeCourse.SelectedItems.Count > 0)
            {
                cboTrainee.Text = listViewTraineeCourse.SelectedItems[0].SubItems[1].Text;
                cboCourse.Text = listViewTraineeCourse.SelectedItems[0].SubItems[2].Text;
                dtpRegistrationDate.Text = listViewTraineeCourse.SelectedItems[0].SubItems[3].Text;
                cboDuration.Text = listViewTraineeCourse.SelectedItems[0].SubItems[4].Text;
                txtCost.Text = listViewTraineeCourse.SelectedItems[0].SubItems[5].Text;
            }
        }

        private bool IsValid()
        {
            if (cboTrainee.Text == string.Empty)
            {
                MessageBox.Show("Please enter trainee");
                return false;
            }
            else if (cboCourse.Text == string.Empty)
            {
                MessageBox.Show("Please enter course");
                return false;
            }
            else if (cboDuration.Text == string.Empty)
            {
                MessageBox.Show("Please enter duration");
                return false;
            }
            else if (txtCost.Text == string.Empty)
            {
                MessageBox.Show("Please enter cost");
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
                    BusinessLogic.TraineeCourseManager traineeCourseManager = new BusinessLogic.TraineeCourseManager();
                    BusinessEntity.TraineeCourseEntity traineeCourse = new BusinessEntity.TraineeCourseEntity();
                    traineeCourse.TraineeEntity = new BusinessEntity.TraineeEntity();
                    traineeCourse.TraineeEntity.ID = int.Parse(cboTrainee.SelectedValue.ToString());
                    traineeCourse.CourseEntity = new BusinessEntity.CourseEntity();
                    traineeCourse.CourseEntity.ID = int.Parse(cboCourse.SelectedValue.ToString());

                    traineeCourse.RegistrationDate = dtpRegistrationDate.Value;
                    traineeCourse.Duration = cboDuration.Text;
                    traineeCourse.Cost = decimal.Parse(txtCost.Text);
                    traineeCourse.CreatedBy = this.Tag.ToString();
                    traineeCourse.CreatedDate = DateTime.Now;

                    int traineeCourseID = traineeCourseManager.Save(traineeCourse);
                    ///////////////////////// manage trainee payment for initial payment

                    BusinessLogic.TraineePaymentManager traineePaymentManager = new BusinessLogic.TraineePaymentManager();
                    BusinessEntity.TraineePaymentEntity traineePayment = new BusinessEntity.TraineePaymentEntity();
                    traineePayment.TraineeCourseEntity = new BusinessEntity.TraineeCourseEntity();
                    traineePayment.TraineeCourseEntity.ID = traineeCourseID;

                    traineePayment.PaymentDate = dtpRegistrationDate.Value;
                    traineePayment.PaymentAmount = decimal.Parse(txtInitialPayment.Text);
                    traineePayment.CreatedBy = this.Tag.ToString();
                    traineePayment.CreatedDate = DateTime.Now;

                    traineePaymentManager.Save(traineePayment);

                    /////////////////////////

                    MessageBox.Show("Trainee's Course Information Saved Successfully.");
                    LoadTraineeCourses();
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
            if (listViewTraineeCourse.SelectedItems.Count > 0)
            {
                try
                {
                    if (IsValid())
                    {
                        int traineeCourseID = int.Parse(listViewTraineeCourse.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineeCourseManager traineeCourseManager = new BusinessLogic.TraineeCourseManager();
                        BusinessEntity.TraineeCourseEntity oldTraineeCourse = traineeCourseManager.GetSingle(traineeCourseID);

                        BusinessEntity.TraineeCourseEntity newTraineeCourse = new BusinessEntity.TraineeCourseEntity();

                        newTraineeCourse.ID = traineeCourseID;
                        newTraineeCourse.TraineeEntity = new BusinessEntity.TraineeEntity();
                        newTraineeCourse.TraineeEntity.ID = int.Parse(cboTrainee.SelectedValue.ToString());
                        newTraineeCourse.CourseEntity = new BusinessEntity.CourseEntity();
                        newTraineeCourse.CourseEntity.ID = int.Parse(cboCourse.SelectedValue.ToString());

                        newTraineeCourse.RegistrationDate = dtpRegistrationDate.Value;
                        newTraineeCourse.Duration = cboDuration.Text;
                        newTraineeCourse.Cost = decimal.Parse(txtCost.Text);

                        newTraineeCourse.CreatedBy = oldTraineeCourse.CreatedBy;
                        newTraineeCourse.CreatedDate = oldTraineeCourse.CreatedDate;
                        newTraineeCourse.UpdatedBy = this.Tag.ToString();
                        newTraineeCourse.UpdatedDate = DateTime.Now;

                        traineeCourseManager.Update(newTraineeCourse);

                        MessageBox.Show("Trainee's Course Information Updated Successfully.");
                        LoadTraineeCourses();
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
            if (listViewTraineeCourse.SelectedItems.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        int traineeCourseID = int.Parse(listViewTraineeCourse.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineeCourseManager traineeCourseManager = new BusinessLogic.TraineeCourseManager();
                        BusinessEntity.TraineeCourseEntity oldTraineeCourse = traineeCourseManager.GetSingle(traineeCourseID);

                        traineeCourseManager.Delete(oldTraineeCourse);
                        MessageBox.Show("Trainee's Course Information Deleted Successfully.");
                        LoadTraineeCourses();
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
                MessageBox.Show("Please select trainee from the list first.");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboTrainee.Text = string.Empty;
            cboCourse.Text = string.Empty;
            dtpRegistrationDate.Value = DateTime.Today;
            cboDuration.Text = string.Empty;
            txtCost.Text = string.Empty;
        }
    }
}
