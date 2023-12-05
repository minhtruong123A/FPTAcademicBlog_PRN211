namespace FPTAcademicBlog
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtusername = new System.Windows.Forms.TextBox();
            txtpassword = new System.Windows.Forms.TextBox();
            Username = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(276, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(233, 89);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // txtusername
            // 
            txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtusername.Location = new System.Drawing.Point(149, 165);
            txtusername.Name = "txtusername";
            txtusername.Size = new System.Drawing.Size(474, 34);
            txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtpassword.Location = new System.Drawing.Point(149, 258);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new System.Drawing.Size(474, 34);
            txtpassword.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Username.Location = new System.Drawing.Point(149, 127);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(127, 35);
            Username.TabIndex = 3;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(149, 220);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 35);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(292, 336);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 58);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabel1.Location = new System.Drawing.Point(317, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(125, 41);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 506);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "frmlogin";
            Text = "frmlogin";
            Load += frmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}