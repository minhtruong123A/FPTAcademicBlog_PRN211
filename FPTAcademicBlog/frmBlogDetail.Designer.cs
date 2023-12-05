namespace FPTAcademicBlog
{
    partial class frmBlogDetail
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
            txtAuthor = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtContent = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(141, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 40);
            label1.TabIndex = 0;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(84, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 40);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(309, 227);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 40);
            label3.TabIndex = 2;
            label3.Text = "Content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(252, -2);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(269, 67);
            label4.TabIndex = 3;
            label4.Text = "Blog Detail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(12, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(761, 40);
            label5.TabIndex = 4;
            label5.Text = "______________________________________________________________";
            label5.Click += label5_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAuthor.Location = new System.Drawing.Point(252, 94);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new System.Drawing.Size(269, 34);
            txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTitle.Location = new System.Drawing.Point(161, 153);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new System.Drawing.Size(467, 34);
            txtTitle.TabIndex = 6;
            // 
            // txtContent
            // 
            txtContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtContent.Location = new System.Drawing.Point(51, 282);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new System.Drawing.Size(667, 238);
            txtContent.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(446, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(92, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(560, 231);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(92, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmBlogDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(781, 532);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBlogDetail";
            Text = "frmBlogDetail";
            Load += frmBlogDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}