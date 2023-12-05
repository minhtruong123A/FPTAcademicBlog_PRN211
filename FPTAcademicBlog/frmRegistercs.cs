using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FPTAcademicBlog
{
    public partial class frmRegistercs : Form
    {
        IBlogrepository repository =new Blogrepository();
        public frmRegistercs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                TblUser user = new TblUser()
                {
                    UserId = txtUserId.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    RoleId = txtRoleId.Text,
                    Birthdate = null,
                    Award=0,
                    NumberOfPosts=0,
                    Status=1,
                    Description=null,
                    Major=txtPassword.Text,
                    Image = null,
                };
                repository.Register(user);
                frmlogin frmlogin = new frmlogin();
                frmlogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password not equal with ConfirmPassword");
            }

        }
    }
}
