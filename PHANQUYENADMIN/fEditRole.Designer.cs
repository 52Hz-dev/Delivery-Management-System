﻿namespace PHANQUYENADMIN
{
    partial class fEditRole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabEditUser = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSystemPrivilege = new System.Windows.Forms.TabPage();
            this.dgvSystemPrivilege = new System.Windows.Forms.DataGridView();
            this.colPrivilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrantPrevilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdminPrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevokePrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSecurable = new System.Windows.Forms.TabPage();
            this.dgvSecurable = new System.Windows.Forms.DataGridView();
            this.colTableSecurable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdateSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsertSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDeleteSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTabGrant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTabRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabEditUser.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSystemPrivilege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemPrivilege)).BeginInit();
            this.tabSecurable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(659, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(523, 388);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 33);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.tabUser);
            this.tabEditUser.Controls.Add(this.tabRole);
            this.tabEditUser.Controls.Add(this.tabSystemPrivilege);
            this.tabEditUser.Controls.Add(this.tabSecurable);
            this.tabEditUser.Location = new System.Drawing.Point(31, 29);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.SelectedIndex = 0;
            this.tabEditUser.Size = new System.Drawing.Size(738, 353);
            this.tabEditUser.TabIndex = 3;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.txtRename);
            this.tabUser.Controls.Add(this.label4);
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
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(171, 96);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(188, 22);
            this.txtRename.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rename";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Name";
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dgvRole);
            this.tabRole.Location = new System.Drawing.Point(4, 25);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(730, 324);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeColumns = false;
            this.dgvRole.AllowUserToResizeRows = false;
            this.dgvRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRole,
            this.colGrant,
            this.colWithAdmin,
            this.colRevoke});
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Name = "dgvRole";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRole.RowHeadersVisible = false;
            this.dgvRole.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvRole.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(730, 321);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // colRole
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRole.DefaultCellStyle = dataGridViewCellStyle13;
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 350;
            // 
            // colGrant
            // 
            this.colGrant.FalseValue = " ";
            this.colGrant.HeaderText = "Grant";
            this.colGrant.MinimumWidth = 6;
            this.colGrant.Name = "colGrant";
            this.colGrant.ReadOnly = true;
            this.colGrant.TrueValue = "x";
            this.colGrant.Width = 125;
            // 
            // colWithAdmin
            // 
            this.colWithAdmin.FalseValue = " ";
            this.colWithAdmin.HeaderText = "With Admin";
            this.colWithAdmin.MinimumWidth = 6;
            this.colWithAdmin.Name = "colWithAdmin";
            this.colWithAdmin.ReadOnly = true;
            this.colWithAdmin.TrueValue = "x";
            this.colWithAdmin.Width = 125;
            // 
            // colRevoke
            // 
            this.colRevoke.FalseValue = " ";
            this.colRevoke.HeaderText = "Revoke";
            this.colRevoke.MinimumWidth = 6;
            this.colRevoke.Name = "colRevoke";
            this.colRevoke.ReadOnly = true;
            this.colRevoke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevoke.TrueValue = "x";
            this.colRevoke.Width = 125;
            // 
            // tabSystemPrivilege
            // 
            this.tabSystemPrivilege.Controls.Add(this.dgvSystemPrivilege);
            this.tabSystemPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tabSystemPrivilege.Name = "tabSystemPrivilege";
            this.tabSystemPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemPrivilege.Size = new System.Drawing.Size(730, 324);
            this.tabSystemPrivilege.TabIndex = 2;
            this.tabSystemPrivilege.Text = "System Privilege";
            this.tabSystemPrivilege.UseVisualStyleBackColor = true;
            // 
            // dgvSystemPrivilege
            // 
            this.dgvSystemPrivilege.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemPrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSystemPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrivilege,
            this.colGrantPrevilege,
            this.colWithAdminPrivilege,
            this.colRevokePrivilege});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSystemPrivilege.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSystemPrivilege.Location = new System.Drawing.Point(0, 2);
            this.dgvSystemPrivilege.Name = "dgvSystemPrivilege";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemPrivilege.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSystemPrivilege.RowHeadersVisible = false;
            this.dgvSystemPrivilege.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvSystemPrivilege.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSystemPrivilege.RowTemplate.Height = 24;
            this.dgvSystemPrivilege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemPrivilege.Size = new System.Drawing.Size(730, 321);
            this.dgvSystemPrivilege.TabIndex = 1;
            // 
            // colPrivilege
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrivilege.DefaultCellStyle = dataGridViewCellStyle17;
            this.colPrivilege.HeaderText = "Privilege";
            this.colPrivilege.MinimumWidth = 6;
            this.colPrivilege.Name = "colPrivilege";
            this.colPrivilege.ReadOnly = true;
            this.colPrivilege.Width = 350;
            // 
            // colGrantPrevilege
            // 
            this.colGrantPrevilege.FalseValue = " ";
            this.colGrantPrevilege.HeaderText = "Grant";
            this.colGrantPrevilege.MinimumWidth = 6;
            this.colGrantPrevilege.Name = "colGrantPrevilege";
            this.colGrantPrevilege.ReadOnly = true;
            this.colGrantPrevilege.TrueValue = "x";
            this.colGrantPrevilege.Width = 125;
            // 
            // colWithAdminPrivilege
            // 
            this.colWithAdminPrivilege.FalseValue = " ";
            this.colWithAdminPrivilege.HeaderText = "With Admin";
            this.colWithAdminPrivilege.MinimumWidth = 6;
            this.colWithAdminPrivilege.Name = "colWithAdminPrivilege";
            this.colWithAdminPrivilege.ReadOnly = true;
            this.colWithAdminPrivilege.TrueValue = "x";
            this.colWithAdminPrivilege.Width = 125;
            // 
            // colRevokePrivilege
            // 
            this.colRevokePrivilege.FalseValue = " ";
            this.colRevokePrivilege.HeaderText = "Revoke";
            this.colRevokePrivilege.MinimumWidth = 6;
            this.colRevokePrivilege.Name = "colRevokePrivilege";
            this.colRevokePrivilege.ReadOnly = true;
            this.colRevokePrivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevokePrivilege.TrueValue = "x";
            this.colRevokePrivilege.Width = 125;
            // 
            // tabSecurable
            // 
            this.tabSecurable.Controls.Add(this.dgvSecurable);
            this.tabSecurable.Location = new System.Drawing.Point(4, 25);
            this.tabSecurable.Name = "tabSecurable";
            this.tabSecurable.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurable.Size = new System.Drawing.Size(730, 324);
            this.tabSecurable.TabIndex = 3;
            this.tabSecurable.Text = "Securable";
            this.tabSecurable.UseVisualStyleBackColor = true;
            // 
            // dgvSecurable
            // 
            this.dgvSecurable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSecurable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableSecurable,
            this.colSelectSecurable,
            this.colUpdateSecurable,
            this.colInsertSecurable,
            this.colDeleteSecurable,
            this.colTabGrant,
            this.colTabRevoke});
            this.dgvSecurable.Location = new System.Drawing.Point(0, 2);
            this.dgvSecurable.Name = "dgvSecurable";
            this.dgvSecurable.RowHeadersVisible = false;
            this.dgvSecurable.RowHeadersWidth = 51;
            this.dgvSecurable.RowTemplate.Height = 24;
            this.dgvSecurable.Size = new System.Drawing.Size(730, 321);
            this.dgvSecurable.TabIndex = 2;
            // 
            // colTableSecurable
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTableSecurable.DefaultCellStyle = dataGridViewCellStyle22;
            this.colTableSecurable.HeaderText = "Table";
            this.colTableSecurable.MinimumWidth = 6;
            this.colTableSecurable.Name = "colTableSecurable";
            this.colTableSecurable.ReadOnly = true;
            this.colTableSecurable.Width = 225;
            // 
            // colSelectSecurable
            // 
            this.colSelectSecurable.FalseValue = " ";
            this.colSelectSecurable.HeaderText = "Select";
            this.colSelectSecurable.MinimumWidth = 6;
            this.colSelectSecurable.Name = "colSelectSecurable";
            this.colSelectSecurable.ReadOnly = true;
            this.colSelectSecurable.TrueValue = "x";
            this.colSelectSecurable.Width = 125;
            // 
            // colUpdateSecurable
            // 
            this.colUpdateSecurable.FalseValue = " ";
            this.colUpdateSecurable.HeaderText = "Update";
            this.colUpdateSecurable.MinimumWidth = 6;
            this.colUpdateSecurable.Name = "colUpdateSecurable";
            this.colUpdateSecurable.ReadOnly = true;
            this.colUpdateSecurable.TrueValue = "x ";
            this.colUpdateSecurable.Width = 125;
            // 
            // colInsertSecurable
            // 
            this.colInsertSecurable.FalseValue = " ";
            this.colInsertSecurable.HeaderText = "Insert";
            this.colInsertSecurable.MinimumWidth = 6;
            this.colInsertSecurable.Name = "colInsertSecurable";
            this.colInsertSecurable.ReadOnly = true;
            this.colInsertSecurable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInsertSecurable.TrueValue = "x";
            this.colInsertSecurable.Width = 125;
            // 
            // colDeleteSecurable
            // 
            this.colDeleteSecurable.FalseValue = " ";
            this.colDeleteSecurable.HeaderText = "Delete";
            this.colDeleteSecurable.MinimumWidth = 6;
            this.colDeleteSecurable.Name = "colDeleteSecurable";
            this.colDeleteSecurable.ReadOnly = true;
            this.colDeleteSecurable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteSecurable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteSecurable.TrueValue = "x";
            this.colDeleteSecurable.Width = 125;
            // 
            // colTabGrant
            // 
            this.colTabGrant.HeaderText = "Grant";
            this.colTabGrant.MinimumWidth = 6;
            this.colTabGrant.Name = "colTabGrant";
            this.colTabGrant.Width = 125;
            // 
            // colTabRevoke
            // 
            this.colTabRevoke.HeaderText = "Revoke";
            this.colTabRevoke.MinimumWidth = 6;
            this.colTabRevoke.Name = "colTabRevoke";
            this.colTabRevoke.Width = 125;
            // 
            // fEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabEditUser);
            this.Name = "fEditRole";
            this.Text = "fEditRole";
            this.Load += new System.EventHandler(this.fEditRole_Load);
            this.tabEditUser.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabSystemPrivilege.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemPrivilege)).EndInit();
            this.tabSecurable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabEditUser;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TabPage tabSystemPrivilege;
        private System.Windows.Forms.DataGridView dgvSystemPrivilege;
        private System.Windows.Forms.TabPage tabSecurable;
        private System.Windows.Forms.DataGridView dgvSecurable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantPrevilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdminPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevokePrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdateSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsertSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDeleteSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTabGrant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTabRevoke;
    }
}