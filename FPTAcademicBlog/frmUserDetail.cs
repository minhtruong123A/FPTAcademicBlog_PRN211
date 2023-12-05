using BusinessObjects;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmUserDetail : Form
    {
        public IBlogrepository Userrepository { get; set; }
        public TblUser UserInfor { get; set; }

        public frmUserDetail()
        {
            InitializeComponent();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            txtImage.Text = UserInfor.Image;
            txtUserID.Text = UserInfor.UserId;
            txtUserName.Text = UserInfor.UserName;
            txtRoleID.Text = UserInfor.RoleId;
            txtPassword.Text = UserInfor.Password;
            txtDescription.Text = UserInfor.Description;
            txtBirthdate.Text = UserInfor.Birthdate;
            txtAward.Text = UserInfor.Award.ToString();
            txtStatus.Text = UserInfor.Status.ToString();
            txtMajor.Text = UserInfor.Major;
            txtNumberOfPosts.Text = UserInfor.NumberOfPosts.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TblUser userAccountInfo = new TblUser()
            {
                Image = txtImage.Text,
                UserId = txtUserID.Text,
                UserName = txtUserName.Text,
                RoleId = txtRoleID.Text,
                Password = txtPassword.Text,
                Description = txtDescription.Text,
                Birthdate = txtBirthdate.Text,
                Award = int.Parse(txtAward.Text),
                Status = int.Parse(txtStatus.Text),
                Major = txtMajor.Text,
                NumberOfPosts = int.Parse(txtNumberOfPosts.Text),
            };
            Userrepository.UpdateUser(userAccountInfo);
            MessageBox.Show("Update Ok !");
            this.Close();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {

        }
    }
}
