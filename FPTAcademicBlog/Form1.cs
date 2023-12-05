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
    public partial class Form1 : Form
    {
        IBlogrepository repository = new Blogrepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void loadUserList()
        {
            try
            {
                var customerList = repository.GetTblUserList();
                BindingSource source = new BindingSource();
                source.DataSource = customerList;

                txtUserID.DataBindings.Clear();
                txtUserID.DataBindings.Add("Text", source, "UserId");

                dgvUser.DataSource = null;
                dgvUser.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of customers");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgvUser.Rows[e.RowIndex];

                DataGridViewRow selectedRow = dgvUser.Rows[e.RowIndex];

                object image = selectedRow.Cells["Image"].Value;
                object userId = selectedRow.Cells["UserId"].Value;
                object userName = selectedRow.Cells["UserName"].Value;
                object roleId = selectedRow.Cells["RoleId"].Value;
                object password = selectedRow.Cells["Password"].Value;
                object description = selectedRow.Cells["Description"].Value;
                object birthdate = selectedRow.Cells["Birthdate"].Value;
                object award = selectedRow.Cells["Award"].Value;
                object status = selectedRow.Cells["Status"].Value;
                object major = selectedRow.Cells["Major"].Value;
                object numberOfPosts = selectedRow.Cells["NumberOfPosts"].Value;

                TblUser cartoon = new TblUser()
                {
                    Image = image?.ToString(),
                    UserId = userId?.ToString(),
                    UserName = userName?.ToString(),
                    RoleId = roleId?.ToString(),
                    Password = password?.ToString(),
                    Description = description?.ToString(),
                    Birthdate = birthdate?.ToString(),
                    Award = award != null ? Convert.ToInt32(award) : 0,
                    Status = status != null ? Convert.ToInt32(status) : 0,
                    Major = major?.ToString(),
                    NumberOfPosts = numberOfPosts != null ? Convert.ToInt32(numberOfPosts) : 0
                };


                frmUserDetail frmUserDetail = new frmUserDetail()
                {
                    Userrepository = repository,
                    UserInfor = cartoon,
                };
                frmUserDetail.ShowDialog();

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var userID = this.txtUserID.Text;

            var cartoon = repository.GetbyUserID(userID);
            if (cartoon != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    TblUser userAccount = repository.GetbyUserID(userID);
                    repository.DeleteUser(userAccount);
                    MessageBox.Show("Delete completed!", "Exit", MessageBoxButtons.OK);
                    loadUserList();
                }
            }
            else
            {
                MessageBox.Show($"Cartoon  id {userID} no exists!");
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            loadUserList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var userName=txtSearchBar.Text;
            List<TblUser> searchName=repository.GetListUserByName(userName);
            if(searchName != null)
            {
                BindingSource source = new BindingSource();
                source.DataSource = searchName;
                dgvUser.DataSource = null;
                dgvUser.DataSource = source;
            }

        }
    }
}
