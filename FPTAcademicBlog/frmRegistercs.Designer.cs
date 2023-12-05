namespace FPTAcademicBlog
{
    partial class frmRegistercs
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtUserId = new System.Windows.Forms.TextBox();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtConfirmPass = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            txtRoleId = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(290, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 78);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(35, 116);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 35);
            label2.TabIndex = 1;
            label2.Text = "UserID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(35, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 35);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(35, 307);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 35);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(26, 372);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(152, 35);
            label5.TabIndex = 4;
            label5.Text = "ConfirmPass";
            // 
            // txtUserId
            // 
            txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserId.Location = new System.Drawing.Point(174, 118);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(516, 34);
            txtUserId.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserName.Location = new System.Drawing.Point(173, 182);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(517, 34);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(174, 307);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(516, 34);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfirmPass.Location = new System.Drawing.Point(173, 372);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new System.Drawing.Size(516, 34);
            txtConfirmPass.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.Location = new System.Drawing.Point(300, 449);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(194, 51);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // txtRoleId
            // 
            txtRoleId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRoleId.Location = new System.Drawing.Point(174, 249);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.ReadOnly = true;
            txtRoleId.Size = new System.Drawing.Size(516, 34);
            txtRoleId.TabIndex = 10;
            txtRoleId.Text = "Student";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(35, 249);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 35);
            label6.TabIndex = 11;
            label6.Text = "RoleID";
            // 
            // frmRegistercs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 537);
            Controls.Add(label6);
            Controls.Add(txtRoleId);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtUserId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistercs";
            Text = "frmRegistercs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Label label6;
    }
}