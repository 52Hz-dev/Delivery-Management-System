using PHANQUYENADMIN.DAO;
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

        private void dgvtabRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }

        private void dgvTabSystemPrivilege_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            }
        }
    }
}
