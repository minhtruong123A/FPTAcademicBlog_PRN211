namespace FPTAcademicBlog
{
    partial class frmAddBlog
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
            txtUser = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtContent = new System.Windows.Forms.TextBox();
            btnPostBlog = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(59, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 28);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(335, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 41);
            label2.TabIndex = 1;
            label2.Text = "Content";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(59, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 28);
            label3.TabIndex = 2;
            label3.Text = "User";
            // 
            // txtUser
            // 
            txtUser.Location = new System.Drawing.Point(116, 34);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new System.Drawing.Size(162, 27);
            txtUser.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(114, 87);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(573, 27);
            txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(32, 137);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(756, 28);
            label4.TabIndex = 5;
            label4.Text = "_____________________________________________________________________________________________";
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(59, 211);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(675, 294);
            txtContent.TabIndex = 6;
            // 
            // btnPostBlog
            // 
            btnPostBlog.Location = new System.Drawing.Point(59, 533);
            btnPostBlog.Name = "btnPostBlog";
            btnPostBlog.Size = new System.Drawing.Size(675, 48);
            btnPostBlog.TabIndex = 7;
            btnPostBlog.Text = "Post Blog";
            btnPostBlog.UseVisualStyleBackColor = true;
            btnPostBlog.Click += btnPostBlog_Click;
            // 
            // frmAddBlog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 611);
            Controls.Add(btnPostBlog);
            Controls.Add(txtContent);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddBlog";
            Text = "frmAddBlog";
            Load += frmAddBlog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnPostBlog;
    }
}