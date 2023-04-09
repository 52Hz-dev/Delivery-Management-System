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

    public partial class fEditRole : Form
    {
        private List<GrantTableForm> newGrantTable = new List<GrantTableForm>();
        private List<GrantRoleForm> newGrantRole = new List<GrantRoleForm>();
        private List<GrantRoleForm> newGrantPrivilege = new List<GrantRoleForm>();
        public fEditRole()
        {
            InitializeComponent();
        }

        private void fEditRole_Load(object sender, EventArgs e)
        {
            // Load user role
            DataTable roleTable = AdminstratorDAO.loadUserRole();
            dgvRole.AutoGenerateColumns = false;
            dgvRole.DataSource = roleTable;
            dgvRole.Columns["colRole"].DataPropertyName = "R";
            // Load user privilege
            DataTable privilegeTable = AdminstratorDAO.loadUserPrivilege();
            dgvSystemPrivilege.AutoGenerateColumns = false;
            dgvSystemPrivilege.DataSource = privilegeTable;
            dgvSystemPrivilege.Columns["colPrivilege"].DataPropertyName = "PRIVILEGE";
            // Load table
            DataTable tbTable = AdminstratorDAO.loadTable();
            dgvSecurable.AutoGenerateColumns = false;
            dgvSecurable.DataSource = tbTable;
            dgvSecurable.Columns["colTableSecurable"].DataPropertyName = "TABLE_NAME";
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRole.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvRole.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvRole.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvRole.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                }
                newGrantRole.Add(getValue(dgvRole.Rows[e.RowIndex]));
            }
        }

        private void dgvSystemPrivilege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSystemPrivilege.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvSystemPrivilege.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvSystemPrivilege.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                    newGrantPrivilege.Add(getValue(dgvSystemPrivilege.Rows[e.RowIndex]));
                }
            }
        }

        private void dgvSecurable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSecurable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvSecurable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                }
                else
                {
                    cell.Value = cell.TrueValue;
                }
                newGrantTable.Add(getTableValue(dgvSecurable.Rows[e.RowIndex]));
            }
        }
        private GrantRoleForm getValue(DataGridViewRow dataGridViewRow)
        {
            String rolename = dataGridViewRow.Cells[0].Value.ToString();
            bool Grant = dataGridViewRow.Cells[1].Value != null;
            bool AdminOption = dataGridViewRow.Cells[2].Value != null;
            bool Revoke = dataGridViewRow.Cells[3].Value != null;
            GrantRoleForm result = new GrantRoleForm(rolename, Grant, AdminOption, Revoke);
            return result;
        }
        private GrantTableForm getTableValue(DataGridViewRow dataGridViewRow)
        {
            string RoleName = dataGridViewRow.Cells[0].Value.ToString();
            bool Select = dataGridViewRow.Cells[1].Value != null;
            bool Update = dataGridViewRow.Cells[2].Value != null;
            bool Insert = dataGridViewRow.Cells[3].Value != null;
            bool Delete = dataGridViewRow.Cells[4].Value != null;
            GrantTableForm result = new GrantTableForm(RoleName, Select, Update, Insert, Delete);
            return result;
        }


        private void btnApply_Click_1(object sender, EventArgs e)
        {
            AdminstratorDAO.Role2User(newGrantRole);
            AdminstratorDAO.Privilege2User(newGrantPrivilege);
            MessageBox.Show("Edit sucessfully!");
            this.Close();
        }
    }
}
