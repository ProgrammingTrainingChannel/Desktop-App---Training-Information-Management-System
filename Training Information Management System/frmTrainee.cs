using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMS
{
    public partial class frmTrainee : Form
    {
        public frmTrainee()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtFullname.Text == string.Empty)
            {
                MessageBox.Show("Please enter fullname");
                return false;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please enter address");
                return false;
            }
            else if (txtPhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Please enter phone number");
                return false;
            }
            else if (cboGender.Text == string.Empty)
            {
                MessageBox.Show("Please enter gender");
                return false;
            }
            else if (cboAcademicLevel.Text == string.Empty)
            {
                MessageBox.Show("Please enter academic level");
                return false;
            }
            else if (cboBranch.Text == string.Empty)
            {
                MessageBox.Show("Please enter branch");
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
                    BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
                    BusinessEntity.TraineeEntity trainee = new BusinessEntity.TraineeEntity();
                    trainee.Fullname = txtFullname.Text;
                    trainee.BirthDate = dtpBirthDate.Value;
                    trainee.GenderEntity = new BusinessEntity.GenderEntity();
                    trainee.GenderEntity.ID = int.Parse(cboGender.SelectedValue.ToString());
                    trainee.AcademicLevelEntity = new BusinessEntity.AcademicLevelEntity();
                    trainee.AcademicLevelEntity.ID = int.Parse(cboAcademicLevel.SelectedValue.ToString());
                    trainee.BranchEntity = new BusinessEntity.BranchEntity();
                    trainee.BranchEntity.ID = int.Parse(cboBranch.SelectedValue.ToString());
                    trainee.Address = txtAddress.Text;
                    trainee.PhoneNumber = txtPhoneNumber.Text;
                    trainee.CreatedBy = this.Tag.ToString();
                    trainee.CreatedDate = DateTime.Now;

                    int traineeID = traineeManager.Save(trainee);
                    if (txtPhotoLocation.Text != string.Empty)
                    {
                        UpdateTraineePhoto(traineeID, txtPhotoLocation.Text);
                    }

                    MessageBox.Show("Trainee Information Saved Successfully.");
                    LoadTrainees();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Save Failed, Please try again.");
            }
        }

        private void frmTrainee_Load(object sender, EventArgs e)
        {
            LoadTrainees();

            BusinessLogic.GenderManager genderManager = new BusinessLogic.GenderManager();
            List<BusinessEntity.GenderEntity> genders = genderManager.GetAll();

            cboGender.DataSource = genders;
            cboGender.ValueMember = "ID";
            cboGender.DisplayMember = "Title";

            BusinessLogic.AcademicLevelManager academicLevelManager = new BusinessLogic.AcademicLevelManager();
            List<BusinessEntity.AcademicLevelEntity> academicLevels = academicLevelManager.GetAll();

            cboAcademicLevel.DataSource = academicLevels;
            cboAcademicLevel.ValueMember = "ID";
            cboAcademicLevel.DisplayMember = "Title";

            BusinessLogic.BranchManager branchManager = new BusinessLogic.BranchManager();
            List<BusinessEntity.BranchEntity> branches = branchManager.GetAll();

            cboBranch.DataSource = branches;
            cboBranch.ValueMember = "ID";
            cboBranch.DisplayMember = "Name";
        }

        private void LoadTrainees()
        {
            BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
            List<BusinessEntity.TraineeEntity> traineeEntities = traineeManager.GetAll();

            listViewTrainee.Items.Clear();
            if (traineeEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.TraineeEntity traineeEntity in traineeEntities)
                {
                    ListViewItem item = new ListViewItem(traineeEntity.ID.ToString());
                    item.SubItems.Add(traineeEntity.Fullname);
                    item.SubItems.Add(traineeEntity.BirthDate.ToString());
                    item.SubItems.Add(traineeEntity.GenderEntity.Title);
                    item.SubItems.Add(traineeEntity.AcademicLevelEntity.Title);
                    item.SubItems.Add(traineeEntity.BranchEntity.Name);
                    item.SubItems.Add(traineeEntity.Address);
                    item.SubItems.Add(traineeEntity.PhoneNumber);

                    listViewTrainee.Items.Add(item);
                }
            }
        }

        private void listViewTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewTrainee.SelectedItems.Count > 0)
            {
                txtFullname.Text = listViewTrainee.SelectedItems[0].SubItems[1].Text;
                dtpBirthDate.Text = listViewTrainee.SelectedItems[0].SubItems[2].Text;
                cboGender.Text = listViewTrainee.SelectedItems[0].SubItems[3].Text;
                cboAcademicLevel.Text = listViewTrainee.SelectedItems[0].SubItems[4].Text;
                cboBranch.Text = listViewTrainee.SelectedItems[0].SubItems[5].Text;
                txtAddress.Text = listViewTrainee.SelectedItems[0].SubItems[6].Text;
                txtPhoneNumber.Text = listViewTrainee.SelectedItems[0].SubItems[7].Text;

                int traineeID = int.Parse(listViewTrainee.SelectedItems[0].SubItems[0].Text);
                BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
                BusinessEntity.TraineeEntity trainee = traineeManager.GetSingle(traineeID);

                this.pictureBoxPhoto.Image = this.GetDataToImage(trainee.Photo);
                this.pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewTrainee.SelectedItems.Count > 0)
            {
                try
                {
                    if (IsValid())
                    {
                        int traineeID = int.Parse(listViewTrainee.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
                        BusinessEntity.TraineeEntity oldTrainee = traineeManager.GetSingle(traineeID);

                        BusinessEntity.TraineeEntity newTrainee = new BusinessEntity.TraineeEntity();

                        newTrainee.ID = traineeID;
                        newTrainee.Fullname = txtFullname.Text;
                        newTrainee.BirthDate = dtpBirthDate.Value;
                        newTrainee.GenderEntity = new BusinessEntity.GenderEntity();
                        newTrainee.GenderEntity.ID = int.Parse(cboGender.SelectedValue.ToString());
                        newTrainee.AcademicLevelEntity = new BusinessEntity.AcademicLevelEntity();
                        newTrainee.AcademicLevelEntity.ID = int.Parse(cboAcademicLevel.SelectedValue.ToString());
                        newTrainee.BranchEntity = new BusinessEntity.BranchEntity();
                        newTrainee.BranchEntity.ID = int.Parse(cboBranch.SelectedValue.ToString());
                        newTrainee.Address = txtAddress.Text;
                        newTrainee.PhoneNumber = txtPhoneNumber.Text;
                        newTrainee.CreatedBy = oldTrainee.CreatedBy;
                        newTrainee.CreatedDate = oldTrainee.CreatedDate;
                        newTrainee.UpdatedBy = this.Tag.ToString();
                        newTrainee.UpdatedDate = DateTime.Now;

                        traineeManager.Update(newTrainee);
                        if (txtPhotoLocation.Text != string.Empty)
                        {
                            UpdateTraineePhoto(newTrainee.ID, txtPhotoLocation.Text);
                        }

                        MessageBox.Show("Trainee Information Updated Successfully.");
                        LoadTrainees();
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
                MessageBox.Show("Please select trainee from the list first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTrainee.SelectedItems.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        int traineeID = int.Parse(listViewTrainee.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
                        BusinessEntity.TraineeEntity oldTrainee = traineeManager.GetSingle(traineeID);

                        traineeManager.Delete(oldTrainee);
                        MessageBox.Show("Trainee Information Deleted Successfully.");
                        LoadTrainees();
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

        public Image GetDataToImage(byte[] pData)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                return (converter.ConvertFrom(pData) as Image);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }

        public void UpdateTraineePhoto(int traineeID, string fileName)
        {
            Image img = Image.FromFile(fileName);
            byte[] buffer = this.ImageToByteArray(img);

            BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
            BusinessEntity.TraineeEntity trainee = traineeManager.GetSingle(traineeID);
            trainee.Photo = buffer;
            traineeManager.Update(trainee);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFullname.Text = string.Empty;
            dtpBirthDate.Text = DateTime.Today.ToString();
            cboGender.Text = string.Empty;
            cboAcademicLevel.Text = string.Empty;
            cboBranch.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;

            txtPhotoLocation.Text = string.Empty;
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtPhotoLocation.Text = dialog.FileName;
            }
        }
    }
}
