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
    public partial class frmSearchTrainee : Form
    {
        public frmSearchTrainee()
        {
            InitializeComponent();
        }

        private void btnSearchTrainee_Click(object sender, EventArgs e)
        {
            BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
            List<BusinessEntity.TraineeEntity> traineeEntities;

            traineeEntities = traineeManager.GetAll();
            if (cboSearchGender.Text != string.Empty && cboSearchGender.Text != "All")
            {
                traineeEntities = traineeEntities.Where(x=>x.GenderEntity.Title == cboSearchGender.Text).ToList();
            }

            if (txtSearchFullname.Text != string.Empty)
            {
                traineeEntities = traineeEntities.Where(x => x.Fullname.ToLower().Contains(txtSearchFullname.Text.ToLower())).ToList();
            }

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
                    item.SubItems.Add(traineeEntity.PhoneNumber);

                    listViewTrainee.Items.Add(item);
                }
            }
        }

        private void listViewTrainee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTrainee.SelectedItems.Count > 0)
            {
                int traineeID = int.Parse(listViewTrainee.SelectedItems[0].SubItems[0].Text);

                BusinessLogic.TraineeManager traineeManager = new BusinessLogic.TraineeManager();
                BusinessEntity.TraineeEntity trainee = traineeManager.GetSingle(traineeID);

                txtFullname.Text = trainee.Fullname;
                dtpBirthDate.Text = trainee.BirthDate.ToString();
                cboGender.Text = trainee.GenderEntity.Title;
                cboAcademicLevel.Text = trainee.AcademicLevelEntity.Title;
                txtAddress.Text = trainee.Address;
                txtPhoneNumber.Text = trainee.PhoneNumber;

                this.pictureBoxPhoto.Image = this.GetDataToImage(trainee.Photo);
                this.pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void frmSearchTrainee_Load(object sender, EventArgs e)
        {
            BusinessLogic.GenderManager genderManager = new BusinessLogic.GenderManager();
            List<BusinessEntity.GenderEntity> genders = genderManager.GetAll();

            cboGender.DataSource = genders;
            cboGender.ValueMember = "ID";
            cboGender.DisplayMember = "Title";

            cboSearchGender.DataSource = genders;
            cboSearchGender.ValueMember = "ID";
            cboSearchGender.DisplayMember = "Title";
        }
    }
}
