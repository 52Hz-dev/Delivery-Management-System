using PHANQUYENADMIN.DAO;
using PHANQUYENADMIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN
{
    public partial class fEditUser : Form
    {
        private List<GrantTableForm> newGrantTable=new List<GrantTableForm>();
        private List<GrantRoleForm> newGrantRole = new List<GrantRoleForm>();
        private List<GrantRoleForm> newGrantPrivilege = new List<GrantRoleForm>();
        public fEditUser()
        {
            InitializeComponent();
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {
            MessageBox.Show(fAdministrator.curUser);
            label4.Text = fAdministrator.curUser;
            // Load user role
            DataTable roleTable= AdminstratorDAO.loadUserRole();
            dgvtabRole.AutoGenerateColumns = false;
            dgvtabRole.DataSource=roleTable;
            dgvtabRole.Columns["colRole"].DataPropertyName = "R";
            // Load user privilege
            DataTable privilegeTable= AdminstratorDAO.loadUserPrivilege();
            dgvTabSystemPrivilege.AutoGenerateColumns = false;
            dgvTabSystemPrivilege.DataSource=privilegeTable;
            dgvTabSystemPrivilege.Columns["colPrivilege"].DataPropertyName = "PRIVILEGE";
            // Load table
            DataTable tbTable = AdminstratorDAO.loadTable();
            dgvTabSecurable.AutoGenerateColumns = false;
            dgvTabSecurable.DataSource = tbTable;
            dgvTabSecurable.Columns["colTableSecurable"].DataPropertyName = "TABLE_NAME";
        }

        private void dgvtabRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtabRole.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvtabRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvtabRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvtabRole.Rows[e.RowIndex].Cells[3].Value=cell.FalseValue; 

                    }
                    else if (e.ColumnIndex == 2 && dgvtabRole.Rows[e.RowIndex].Cells[1].Value== cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if(e.ColumnIndex==3)
                    {
                        dgvtabRole.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue ;
                        dgvtabRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                }
                newGrantRole.Add(getValue(dgvtabRole.Rows[e.RowIndex]));
            }
        }



        private void dgvTabSystemPrivilege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTabSystemPrivilege.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                    newGrantPrivilege.Add(getValue(dgvTabSystemPrivilege.Rows[e.RowIndex]));
                }
            }
        }

        private void dgvTabSecurable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTabSecurable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvTabSecurable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                }
                else
                {
                    cell.Value = cell.TrueValue;
                }
                newGrantTable.Add(getTableValue(dgvTabSecurable.Rows[e.RowIndex]));
            }
        }
        private GrantRoleForm getValue(DataGridViewRow dataGridViewRow)
        {
            String rolename = dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
            bool Grant = dataGridViewRow.Cells[1].Value == cell.TrueValue;
            bool AdminOption = dataGridViewRow.Cells[2].Value == cell.TrueValue;
            bool Revoke = dataGridViewRow.Cells[3].Value == cell.TrueValue;
            GrantRoleForm result = new GrantRoleForm(rolename, Grant, AdminOption, Revoke);
            return result;
        }
        private GrantTableForm getTableValue(DataGridViewRow dataGridViewRow)
        {
            string RoleName= dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
            bool Select = dataGridViewRow.Cells[1].Value == cell.TrueValue;
            bool Update= dataGridViewRow.Cells[2].Value == cell.TrueValue;
            bool Insert= dataGridViewRow.Cells[3].Value == cell.TrueValue;
            bool Delete= dataGridViewRow.Cells[4].Value == cell.TrueValue;
            GrantTableForm result = new GrantTableForm(RoleName, Select, Update, Insert, Delete);
            return result;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            AdminstratorDAO.Role2User(fAdministrator.curUser, newGrantRole);
            AdminstratorDAO.Privilege2User(fAdministrator.curUser, newGrantPrivilege);
            if(txtPassword.Text!=null)
            AdminstratorDAO.changeUserPassword(fAdministrator.curUser,txtPassword.Text,txtConfirmPassword.Text);
            MessageBox.Show("Edit sucessfully!");
            newGrantRole.Clear();
            newGrantPrivilege.Clear();
            newGrantTable.Clear();
            this.Close();
        }

        private void tabUser_Click(object sender, EventArgs e)
        {

        }
    }
}
