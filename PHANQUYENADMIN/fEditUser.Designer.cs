namespace PHANQUYENADMIN
{
    partial class fEditUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEditUser = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.tabSystemPrivilege = new System.Windows.Forms.TabPage();
            this.tabSecurable = new System.Windows.Forms.TabPage();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colPrevilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrantPrevilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdminPrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevokePrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colTableSecurable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdateSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsertSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDeleteSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabEditUser.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRole.SuspendLayout();
            this.tabSystemPrivilege.SuspendLayout();
            this.tabSecurable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.tabUser);
            this.tabEditUser.Controls.Add(this.tabRole);
            this.tabEditUser.Controls.Add(this.tabSystemPrivilege);
            this.tabEditUser.Controls.Add(this.tabSecurable);
            this.tabEditUser.Location = new System.Drawing.Point(40, 32);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.SelectedIndex = 0;
            this.tabEditUser.Size = new System.Drawing.Size(738, 353);
            this.tabEditUser.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.txtConfirmPassword);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(730, 324);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dataGridView1);
            this.tabRole.Location = new System.Drawing.Point(4, 25);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(730, 324);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // tabSystemPrivilege
            // 
            this.tabSystemPrivilege.Controls.Add(this.dataGridView2);
            this.tabSystemPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tabSystemPrivilege.Name = "tabSystemPrivilege";
            this.tabSystemPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemPrivilege.Size = new System.Drawing.Size(730, 324);
            this.tabSystemPrivilege.TabIndex = 2;
            this.tabSystemPrivilege.Text = "System Privilege";
            this.tabSystemPrivilege.UseVisualStyleBackColor = true;
            // 
            // tabSecurable
            // 
            this.tabSecurable.Controls.Add(this.dataGridView3);
            this.tabSecurable.Location = new System.Drawing.Point(4, 25);
            this.tabSecurable.Name = "tabSecurable";
            this.tabSecurable.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurable.Size = new System.Drawing.Size(730, 324);
            this.tabSecurable.TabIndex = 3;
            this.tabSecurable.Text = "Securable";
            this.tabSecurable.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(532, 391);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 33);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N\\A";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(171, 151);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(188, 22);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRole,
            this.colGrant,
            this.colWithAdmin,
            this.colRevoke});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // colRole
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRole.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 350;
            // 
            // colGrant
            // 
            this.colGrant.HeaderText = "Grant";
            this.colGrant.MinimumWidth = 6;
            this.colGrant.Name = "colGrant";
            this.colGrant.ReadOnly = true;
            this.colGrant.Width = 125;
            // 
            // colWithAdmin
            // 
            this.colWithAdmin.HeaderText = "With Admin";
            this.colWithAdmin.MinimumWidth = 6;
            this.colWithAdmin.Name = "colWithAdmin";
            this.colWithAdmin.ReadOnly = true;
            this.colWithAdmin.Width = 125;
            // 
            // colRevoke
            // 
            this.colRevoke.HeaderText = "Revoke";
            this.colRevoke.MinimumWidth = 6;
            this.colRevoke.Name = "colRevoke";
            this.colRevoke.ReadOnly = true;
            this.colRevoke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevoke.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrevilege,
            this.colGrantPrevilege,
            this.colWithAdminPrivilege,
            this.colRevokePrivilege});
            this.dataGridView2.Location = new System.Drawing.Point(0, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(730, 321);
            this.dataGridView2.TabIndex = 1;
            // 
            // colPrevilege
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrevilege.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPrevilege.HeaderText = "Privilege";
            this.colPrevilege.MinimumWidth = 6;
            this.colPrevilege.Name = "colPrevilege";
            this.colPrevilege.ReadOnly = true;
            this.colPrevilege.Width = 350;
            // 
            // colGrantPrevilege
            // 
            this.colGrantPrevilege.HeaderText = "Grant";
            this.colGrantPrevilege.MinimumWidth = 6;
            this.colGrantPrevilege.Name = "colGrantPrevilege";
            this.colGrantPrevilege.ReadOnly = true;
            this.colGrantPrevilege.Width = 125;
            // 
            // colWithAdminPrivilege
            // 
            this.colWithAdminPrivilege.HeaderText = "With Admin";
            this.colWithAdminPrivilege.MinimumWidth = 6;
            this.colWithAdminPrivilege.Name = "colWithAdminPrivilege";
            this.colWithAdminPrivilege.ReadOnly = true;
            this.colWithAdminPrivilege.Width = 125;
            // 
            // colRevokePrivilege
            // 
            this.colRevokePrivilege.HeaderText = "Revoke";
            this.colRevokePrivilege.MinimumWidth = 6;
            this.colRevokePrivilege.Name = "colRevokePrivilege";
            this.colRevokePrivilege.ReadOnly = true;
            this.colRevokePrivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevokePrivilege.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableSecurable,
            this.colSelectSecurable,
            this.colUpdateSecurable,
            this.colInsertSecurable,
            this.colDeleteSecurable});
            this.dataGridView3.Location = new System.Drawing.Point(0, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(730, 321);
            this.dataGridView3.TabIndex = 2;
            // 
            // colTableSecurable
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTableSecurable.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTableSecurable.HeaderText = "Table";
            this.colTableSecurable.MinimumWidth = 6;
            this.colTableSecurable.Name = "colTableSecurable";
            this.colTableSecurable.ReadOnly = true;
            this.colTableSecurable.Width = 225;
            // 
            // colSelectSecurable
            // 
            this.colSelectSecurable.HeaderText = "Select";
            this.colSelectSecurable.MinimumWidth = 6;
            this.colSelectSecurable.Name = "colSelectSecurable";
            this.colSelectSecurable.ReadOnly = true;
            this.colSelectSecurable.Width = 125;
            // 
            // colUpdateSecurable
            // 
            this.colUpdateSecurable.HeaderText = "Update";
            this.colUpdateSecurable.MinimumWidth = 6;
            this.colUpdateSecurable.Name = "colUpdateSecurable";
            this.colUpdateSecurable.ReadOnly = true;
            this.colUpdateSecurable.Width = 125;
            // 
            // colInsertSecurable
            // 
            this.colInsertSecurable.HeaderText = "Insert";
            this.colInsertSecurable.MinimumWidth = 6;
            this.colInsertSecurable.Name = "colInsertSecurable";
            this.colInsertSecurable.ReadOnly = true;
            this.colInsertSecurable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInsertSecurable.Width = 125;
            // 
            // colDeleteSecurable
            // 
            this.colDeleteSecurable.HeaderText = "Delete";
            this.colDeleteSecurable.MinimumWidth = 6;
            this.colDeleteSecurable.Name = "colDeleteSecurable";
            this.colDeleteSecurable.ReadOnly = true;
            this.colDeleteSecurable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteSecurable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteSecurable.Width = 125;
            // 
            // fEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabEditUser);
            this.Name = "fEditUser";
            this.Text = "fEditUser";
            this.tabEditUser.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabRole.ResumeLayout(false);
            this.tabSystemPrivilege.ResumeLayout(false);
            this.tabSecurable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEditUser;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabSystemPrivilege;
        private System.Windows.Forms.TabPage tabSecurable;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevoke;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrevilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantPrevilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdminPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevokePrivilege;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdateSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsertSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDeleteSecurable;
    }
}