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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Please enter title");
                return false;
            }
            else if (txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Please enter description");
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
                    BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
                    BusinessEntity.CourseEntity course = new BusinessEntity.CourseEntity();
                    course.Title = txtTitle.Text;
                    course.Description = txtDescription.Text;

                    courseManager.Save(course);
                    MessageBox.Show("Course Information Saved Successfully.");
                    LoadCourses();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Save Failed, Please try again.");
            }
        }

        private void LoadCourses()
        {
            BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
            List<BusinessEntity.CourseEntity> courseEntities = courseManager.GetAll();

            listViewCourse.Items.Clear();
            if (courseEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.CourseEntity courseEntity in courseEntities)
                {
                    ListViewItem item = new ListViewItem(courseEntity.ID.ToString());
                    item.SubItems.Add(courseEntity.Title);

                    listViewCourse.Items.Add(item);
                }
            }
        }

        private void listViewCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCourse.SelectedItems.Count > 0)
            {
                int courseID = int.Parse(listViewCourse.SelectedItems[0].SubItems[0].Text);
                BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
                BusinessEntity.CourseEntity course = courseManager.GetSingle(courseID);

                txtTitle.Text = course.Title;
                txtDescription.Text = course.Description;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewCourse.SelectedItems.Count > 0)
            {
                try
                {
                    if (IsValid())
                    {
                        int courseID = int.Parse(listViewCourse.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
                        BusinessEntity.CourseEntity oldCourse = courseManager.GetSingle(courseID);

                        BusinessEntity.CourseEntity newCourse = new BusinessEntity.CourseEntity();

                        newCourse.ID = courseID;
                        newCourse.Title = txtTitle.Text;
                        newCourse.Description = txtDescription.Text;

                        courseManager.Update(newCourse);

                        MessageBox.Show("Course Information Updated Successfully.");
                        LoadCourses();
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
                MessageBox.Show("Please select course from the list first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCourse.SelectedItems.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if(result == DialogResult.OK)
                    {
                        int courseID = int.Parse(listViewCourse.SelectedItems[0].SubItems[0].Text);
                        BusinessLogic.CourseManager courseManager = new BusinessLogic.CourseManager();
                        BusinessEntity.CourseEntity oldCourse = courseManager.GetSingle(courseID);

                        courseManager.Delete(oldCourse);
                        MessageBox.Show("Course Information Deleted Successfully.");
                        LoadCourses();
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
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;

        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
    }
}
