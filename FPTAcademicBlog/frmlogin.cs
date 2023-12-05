using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTAcademicBlog
{
    public partial class frmlogin : Form
    {
        IBlogrepository repository = new Blogrepository();
        public frmlogin()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return config["ConnectionStrings:DB"];
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", true, true)
                             .Build();
            var adminUser = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            var adminRole = config["AdminAccount:Role"];
            if (adminUser == txtusername.Text && adminPassword == txtpassword.Text)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                if (repository.CheckLogin(txtusername.Text, txtpassword.Text) != null)
                {
                    frmHomePage loginPage = new frmHomePage()
                    {
                        userSession = txtusername.Text
                    };
                    loginPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your User Account didn't existed!!");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistercs frmRegistercs = new frmRegistercs();
            frmRegistercs.ShowDialog();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
