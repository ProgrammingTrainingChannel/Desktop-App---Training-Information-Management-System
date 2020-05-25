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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtUsername.Text == string.Empty)
            {
                lblMessage.Text = "Please enter username";
                return false;
            }
            else if (txtPassword.Text == string.Empty)
            {
                lblMessage.Text = "Please enter password";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    string password = ClassSecurity.HashString(txtPassword.Text);
                    
                    BusinessLogic.UserManager userManager = new BusinessLogic.UserManager();
                    bool status = userManager.LoginUser(txtUsername.Text, password);

                    if (status == false)
                    {
                        lblMessage.Text = "Username or Password is not correct, please try again.";
                    }
                    else
                    {
                        this.Hide();
                        frmHome frm = new TIMS.frmHome();
                        frm.Tag = txtUsername.Text;
                        frm.Show();
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
