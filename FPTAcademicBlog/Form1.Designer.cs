namespace FPTAcademicBlog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            dgvUser = new System.Windows.Forms.DataGridView();
            BtnDelete = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtUserID = new System.Windows.Forms.TextBox();
            btnRefreshList = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtSearchBar = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(159, -9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(479, 67);
            label1.TabIndex = 0;
            label1.Text = "Admin Management";
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new System.Drawing.Point(76, 227);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new System.Drawing.Size(636, 318);
            dgvUser.TabIndex = 1;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new System.Drawing.Point(250, 111);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new System.Drawing.Size(129, 42);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(250, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "UserID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(309, 65);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new System.Drawing.Size(180, 27);
            txtUserID.TabIndex = 4;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Location = new System.Drawing.Point(397, 111);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new System.Drawing.Size(129, 42);
            btnRefreshList.TabIndex = 5;
            btnRefreshList.Text = "Refresh List";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(191, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Search";
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new System.Drawing.Point(250, 179);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new System.Drawing.Size(277, 27);
            txtSearchBar.TabIndex = 7;
            txtSearchBar.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(533, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(74, 27);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 538);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBar);
            Controls.Add(label3);
            Controls.Add(btnRefreshList);
            Controls.Add(txtUserID);
            Controls.Add(label2);
            Controls.Add(BtnDelete);
            Controls.Add(dgvUser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnSearch;
    }
}
