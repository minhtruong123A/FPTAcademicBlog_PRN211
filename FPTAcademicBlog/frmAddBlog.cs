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

namespace FPTAcademicBlog
{
    public partial class frmAddBlog : Form
    {
        public string AddPostSession { get; set; }
        public IBlogrepository AddPostrepository { get; set; }
        public frmAddBlog()
        {
            InitializeComponent();
        }

        private void frmAddBlog_Load(object sender, EventArgs e)
        {
            txtUser.Text = AddPostSession;
        }

        private void btnPostBlog_Click(object sender, EventArgs e)
        {
           Post addPost = new Post();
           string author = txtUser.Text;
           string title = txtTitle.Text;
           string content = txtContent.Text;
        }
    }
}
