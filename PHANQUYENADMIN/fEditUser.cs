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
    public partial class fEditUser : Form
    {
        public fEditUser()
        {
            InitializeComponent();
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {

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
            }
        }
    }
}
