namespace PHANQUYENADMIN
{
    partial class fAdministrator
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrivilegeUserInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUsersys = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbRolePrivs = new System.Windows.Forms.ComboBox();
            this.btnRefreshRole = new System.Windows.Forms.Button();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnDropRole = new System.Windows.Forms.Button();
            this.btnPvlRoleInfo = new System.Windows.Forms.Button();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.dgvPrivilegeRoleInfo = new System.Windows.Forms.DataGridView();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.txtRole = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbbUserPrivs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDropUser = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.dgvPrivilegeInfo = new System.Windows.Forms.DataGridView();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.txtUser = new System.Windows.Forms.Label();
            this.dgvPrivilegeUserInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersys)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegeRoleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ";
            // 
            // dgvPrivilegeUserInfo
            // 
            this.dgvPrivilegeUserInfo.Controls.Add(this.tabPage1);
            this.dgvPrivilegeUserInfo.Controls.Add(this.tabPage2);
            this.dgvPrivilegeUserInfo.Controls.Add(this.tabPage3);
            this.dgvPrivilegeUserInfo.Location = new System.Drawing.Point(32, 104);
            this.dgvPrivilegeUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrivilegeUserInfo.Name = "dgvPrivilegeUserInfo";
            this.dgvPrivilegeUserInfo.SelectedIndex = 0;
            this.dgvPrivilegeUserInfo.Size = new System.Drawing.Size(1294, 688);
            this.dgvPrivilegeUserInfo.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUsersys);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1286, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Người dùng trong hệ thống";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUsersys
            // 
            this.dgvUsersys.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsersys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersys.Location = new System.Drawing.Point(17, 26);
            this.dgvUsersys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsersys.Name = "dgvUsersys";
            this.dgvUsersys.RowHeadersWidth = 62;
            this.dgvUsersys.RowTemplate.Height = 28;
            this.dgvUsersys.Size = new System.Drawing.Size(1254, 614);
            this.dgvUsersys.TabIndex = 0;
            this.dgvUsersys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersys_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbRolePrivs);
            this.tabPage2.Controls.Add(this.btnRefreshRole);
            this.tabPage2.Controls.Add(this.btnEditRole);
            this.tabPage2.Controls.Add(this.btnDropRole);
            this.tabPage2.Controls.Add(this.btnPvlRoleInfo);
            this.tabPage2.Controls.Add(this.btnCreateRole);
            this.tabPage2.Controls.Add(this.dgvPrivilegeRoleInfo);
            this.tabPage2.Controls.Add(this.dgvRole);
            this.tabPage2.Controls.Add(this.txtRole);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1286, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbRolePrivs
            // 
            this.cbbRolePrivs.FormattingEnabled = true;
            this.cbbRolePrivs.Location = new System.Drawing.Point(648, 28);
            this.cbbRolePrivs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbRolePrivs.Name = "cbbRolePrivs";
            this.cbbRolePrivs.Size = new System.Drawing.Size(280, 28);
            this.cbbRolePrivs.TabIndex = 8;
            // 
            // btnRefreshRole
            // 
            this.btnRefreshRole.Location = new System.Drawing.Point(333, 406);
            this.btnRefreshRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshRole.Name = "btnRefreshRole";
            this.btnRefreshRole.Size = new System.Drawing.Size(130, 36);
            this.btnRefreshRole.TabIndex = 7;
            this.btnRefreshRole.Text = "Refresh";
            this.btnRefreshRole.UseVisualStyleBackColor = true;
            this.btnRefreshRole.Click += new System.EventHandler(this.btnRefreshRole_Click_1);
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(333, 249);
            this.btnEditRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(130, 36);
            this.btnEditRole.TabIndex = 6;
            this.btnEditRole.Text = "Edit role";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click_1);
            // 
            // btnDropRole
            // 
            this.btnDropRole.Location = new System.Drawing.Point(333, 330);
            this.btnDropRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropRole.Name = "btnDropRole";
            this.btnDropRole.Size = new System.Drawing.Size(130, 36);
            this.btnDropRole.TabIndex = 5;
            this.btnDropRole.Text = "Drop role";
            this.btnDropRole.UseVisualStyleBackColor = true;
            this.btnDropRole.Click += new System.EventHandler(this.btnDropRole_Click_1);
            // 
            // btnPvlRoleInfo
            // 
            this.btnPvlRoleInfo.Location = new System.Drawing.Point(1026, 19);
            this.btnPvlRoleInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPvlRoleInfo.Name = "btnPvlRoleInfo";
            this.btnPvlRoleInfo.Size = new System.Drawing.Size(130, 36);
            this.btnPvlRoleInfo.TabIndex = 4;
            this.btnPvlRoleInfo.Text = "Privilege Info";
            this.btnPvlRoleInfo.UseVisualStyleBackColor = true;
            this.btnPvlRoleInfo.Click += new System.EventHandler(this.btnPvlRoleInfo_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(333, 169);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(130, 36);
            this.btnCreateRole.TabIndex = 3;
            this.btnCreateRole.Text = "Create role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click_1);
            // 
            // dgvPrivilegeRoleInfo
            // 
            this.dgvPrivilegeRoleInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPrivilegeRoleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivilegeRoleInfo.Location = new System.Drawing.Point(519, 69);
            this.dgvPrivilegeRoleInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrivilegeRoleInfo.Name = "dgvPrivilegeRoleInfo";
            this.dgvPrivilegeRoleInfo.RowHeadersWidth = 62;
            this.dgvPrivilegeRoleInfo.RowTemplate.Height = 28;
            this.dgvPrivilegeRoleInfo.Size = new System.Drawing.Size(752, 565);
            this.dgvPrivilegeRoleInfo.TabIndex = 2;
            // 
            // dgvRole
            // 
            this.dgvRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(11, 69);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 62;
            this.dgvRole.RowTemplate.Height = 28;
            this.dgvRole.Size = new System.Drawing.Size(256, 565);
            this.dgvRole.TabIndex = 1;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick_1);
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(6, 14);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(68, 25);
            this.txtRole.TabIndex = 0;
            this.txtRole.Text = "Role: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbbUserPrivs);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnRefreshUser);
            this.tabPage3.Controls.Add(this.btnEditUser);
            this.tabPage3.Controls.Add(this.btnDropUser);
            this.tabPage3.Controls.Add(this.btnCreateUser);
            this.tabPage3.Controls.Add(this.dgvPrivilegeInfo);
            this.tabPage3.Controls.Add(this.dgvUser);
            this.tabPage3.Controls.Add(this.txtUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1286, 655);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbbUserPrivs
            // 
            this.cbbUserPrivs.FormattingEnabled = true;
            this.cbbUserPrivs.Location = new System.Drawing.Point(652, 22);
            this.cbbUserPrivs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbUserPrivs.Name = "cbbUserPrivs";
            this.cbbUserPrivs.Size = new System.Drawing.Size(280, 28);
            this.cbbUserPrivs.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1030, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Privilege Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(332, 414);
            this.btnRefreshUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(130, 36);
            this.btnRefreshUser.TabIndex = 15;
            this.btnRefreshUser.Text = "Refresh";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click_1);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(332, 248);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(130, 36);
            this.btnEditUser.TabIndex = 14;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click_1);
            // 
            // btnDropUser
            // 
            this.btnDropUser.Location = new System.Drawing.Point(332, 332);
            this.btnDropUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropUser.Name = "btnDropUser";
            this.btnDropUser.Size = new System.Drawing.Size(130, 36);
            this.btnDropUser.TabIndex = 13;
            this.btnDropUser.Text = "Drop user";
            this.btnDropUser.UseVisualStyleBackColor = true;
            this.btnDropUser.Click += new System.EventHandler(this.btnDropUser_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(332, 168);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(130, 36);
            this.btnCreateUser.TabIndex = 11;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click_1);
            // 
            // dgvPrivilegeInfo
            // 
            this.dgvPrivilegeInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPrivilegeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrivilegeInfo.Location = new System.Drawing.Point(518, 68);
            this.dgvPrivilegeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrivilegeInfo.Name = "dgvPrivilegeInfo";
            this.dgvPrivilegeInfo.RowHeadersWidth = 62;
            this.dgvPrivilegeInfo.RowTemplate.Height = 28;
            this.dgvPrivilegeInfo.Size = new System.Drawing.Size(756, 565);
            this.dgvPrivilegeInfo.TabIndex = 10;
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(10, 68);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 28;
            this.dgvUser.Size = new System.Drawing.Size(256, 565);
            this.dgvUser.TabIndex = 9;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick_1);
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(4, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(70, 25);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "User: ";
            // 
            // fAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrivilegeUserInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAdministrator";
            this.Text = "fAdministrator";
            this.Load += new System.EventHandler(this.fAdministrator_Load);
            this.dgvPrivilegeUserInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersys)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegeRoleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrivilegeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl dgvPrivilegeUserInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvUsersys;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbbRolePrivs;
        private System.Windows.Forms.Button btnRefreshRole;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnDropRole;
        private System.Windows.Forms.Button btnPvlRoleInfo;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.DataGridView dgvPrivilegeRoleInfo;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbbUserPrivs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefreshUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDropUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.DataGridView dgvPrivilegeInfo;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label txtUser;
    }
}