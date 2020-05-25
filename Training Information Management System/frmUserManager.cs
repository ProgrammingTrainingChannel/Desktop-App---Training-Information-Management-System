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
    public partial class frmUserManager : Form
    {
        public frmUserManager()
        {
            InitializeComponent();
        }

        private bool IsValidUser()
        {
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter username");
                return false;
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter password");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidUserRole()
        {
            if (cboUser.Text == string.Empty)
            {
                MessageBox.Show("Please select user");
                return false;
            }
            else if (cboRole.Text == string.Empty)
            {
                MessageBox.Show("Please select role");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidUser())
                {
                    BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
                    BusinessEntity.UserEntity user = new BusinessEntity.UserEntity();
                    user.Username = txtUsername.Text;
                    user.Password = ClassSecurity.HashString(txtPassword.Text).ToString();

                    userManager.Save(user);

                    MessageBox.Show("User Information Saved Successfully.");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Save Failed, Please try again.");
            }
        }

        private void LoadUsers()
        {
            BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
            List<BusinessEntity.UserEntity> userEntities = userManager.GetAll();

            listViewUser.Items.Clear();
            if (userEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.UserEntity userEntity in userEntities)
                {
                    ListViewItem item = new ListViewItem(userEntity.ID.ToString());
                    item.SubItems.Add(userEntity.Username);
                    item.SubItems.Add(userEntity.Password);

                    listViewUser.Items.Add(item);
                }
            }
        }

        private void LoadUserRoles()
        {
            BusinessLogic.UserRoleManager userRoleManager = new BusinessLogic.UserRoleManager();
            List<BusinessEntity.UserRoleEntity> userRoleEntities = userRoleManager.GetAll();

            listViewUserRole.Items.Clear();
            if (userRoleEntities == null)
            {
                MessageBox.Show("Sorry database error occured, please try again.");
            }
            else
            {
                foreach (BusinessEntity.UserRoleEntity userRoleEntity in userRoleEntities)
                {
                    ListViewItem item = new ListViewItem(userRoleEntity.ID.ToString());
                    item.SubItems.Add(userRoleEntity.User.Username);
                    item.SubItems.Add(userRoleEntity.Role.Name);

                    listViewUserRole.Items.Add(item);
                }
            }
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
            List<BusinessEntity.UserEntity> users = userManager.GetAll();

            cboUser.DataSource = users;
            cboUser.ValueMember = "ID";
            cboUser.DisplayMember = "Username";

            BusinessLogic.RoleManager roleManager = new BusinessLogic.RoleManager();
            List<BusinessEntity.RoleEntity> roles = roleManager.GetAll();

            cboRole.DataSource = roles;
            cboRole.ValueMember = "ID";
            cboRole.DisplayMember = "Name";

            LoadUsers();
            LoadUserRoles();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidUser())
                {
                    BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
                    BusinessEntity.UserEntity newUser = new BusinessEntity.UserEntity();

                    newUser.ID = int.Parse(listViewUser.SelectedItems[0].SubItems[0].Text);
                    newUser.Username = txtUsername.Text;
                    newUser.Password = ClassSecurity.HashString(txtPassword.Text).ToString();

                    userManager.Update(newUser);

                    MessageBox.Show("User Information Updated Successfully.");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Update Failed, Please try again.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUser.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
                        BusinessEntity.UserEntity newUser = new BusinessEntity.UserEntity();

                        newUser.ID = int.Parse(listViewUser.SelectedItems[0].SubItems[0].Text);
                        newUser.Username = txtUsername.Text;
                        newUser.Password = txtPassword.Text;

                        userManager.Delete(newUser);

                        MessageBox.Show("User Information Deleted Successfully.");
                        LoadUsers();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user from the list first.");
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Delete Failed, Please try again.");
            }
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidUserRole())
                {
                    BusinessLogic.UserRoleManager userRoleManager = new BusinessLogic.UserRoleManager();
                    BusinessEntity.UserRoleEntity userRole = new BusinessEntity.UserRoleEntity();
                    userRole.User = new BusinessEntity.UserEntity();
                    userRole.User.ID = int.Parse(cboUser.SelectedValue.ToString());
                    userRole.Role = new BusinessEntity.RoleEntity();
                    userRole.Role.ID = int.Parse(cboRole.SelectedValue.ToString());

                    userRoleManager.Save(userRole);

                    MessageBox.Show("UserRole Information Saved Successfully.");
                    LoadUserRoles();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Save Failed, Please try again.");
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidUserRole())
                {
                    BusinessLogic.UserRoleManager userRoleManager = new BusinessLogic.UserRoleManager();
                    BusinessEntity.UserRoleEntity newUserRole = new BusinessEntity.UserRoleEntity();

                    newUserRole.ID = int.Parse(listViewUser.SelectedItems[0].SubItems[0].Text);
                    newUserRole.User = new BusinessEntity.UserEntity();
                    newUserRole.User.ID = int.Parse(cboUser.SelectedValue.ToString());
                    newUserRole.Role = new BusinessEntity.RoleEntity();
                    newUserRole.Role.ID = int.Parse(cboRole.SelectedValue.ToString());

                    userRoleManager.Update(newUserRole);

                    MessageBox.Show("UserRole Information Updated Successfully.");
                    LoadUserRoles();
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Update Failed, Please try again.");
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUserRole.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Training Information Management System", MessageBoxButtons.YesNo);
                    if (result == DialogResult.OK)
                    {
                        BusinessLogic.UserRoleManager userRoleManager = new BusinessLogic.UserRoleManager();
                        BusinessEntity.UserRoleEntity newUserRole = new BusinessEntity.UserRoleEntity();

                        newUserRole.ID = int.Parse(listViewUser.SelectedItems[0].SubItems[0].Text);

                        userRoleManager.Delete(newUserRole);

                        MessageBox.Show("UserRole Information Deleted Successfully.");
                        LoadUserRoles();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a userRole from the list first.");
                }
            }
            catch (Exception ex)
            {
                //save to log table
                MessageBox.Show("Delete Failed, Please try again.");
            }
        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewUser.SelectedItems.Count > 0)
            {
                txtUsername.Text = listViewUser.SelectedItems[0].SubItems[1].Text;
                //txtPassword.Text = listViewUser.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void listViewUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUserRole.SelectedItems.Count > 0)
            {
                cboUser.Text = listViewUserRole.SelectedItems[0].SubItems[1].Text;
                cboRole.Text = listViewUserRole.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
