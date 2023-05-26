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
    public partial class fNhanSu : Form
    {
        public fNhanSu()
        {
            InitializeComponent();
            loadInfo();
        }
        void loadInfo()
        {
            dgvNV.DataSource = AdminstratorDAO.readNHANVIEN();
            dgvPB.DataSource = AdminstratorDAO.readPHONGBAN();
        }

        private void dgvPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPB.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPB.SelectedRows[0];

                // Lấy giá trị từ các cột dữ liệu
                txtMAPB.Text = selectedRow.Cells["MAPB"].Value.ToString();
                txtTENPB.Text = selectedRow.Cells["TENPB"].Value.ToString();
                txtTRPHG.Text = selectedRow.Cells["TRPHG"].Value.ToString();
            }
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNV.SelectedRows[0];

                // Lấy giá trị từ các cột dữ liệu
                txtMANV.Text = selectedRow.Cells["MANV"].Value.ToString();
                txtTENNV.Text = selectedRow.Cells["TENNV"].Value.ToString();
                txtPHAI.Text = selectedRow.Cells["PHAI"].Value.ToString();
                txtNGAYSINH.Text = selectedRow.Cells["NGAYSINH"].Value.ToString();
                txtDIACHI.Text = selectedRow.Cells["DIACHI"].Value.ToString();
                txtSODT.Text = selectedRow.Cells["SODT"].Value.ToString();
                txtLUONG.Text = selectedRow.Cells["LUONG"].Value.ToString();
                txtPHUCAP.Text = selectedRow.Cells["PHUCAP"].Value.ToString();
                txtVAITRO.Text = selectedRow.Cells["VAITRO"].Value.ToString();
                txtMAQL.Text = selectedRow.Cells["MANQL"].Value.ToString();
                txtPHG.Text = selectedRow.Cells["PHG"].Value.ToString();
            }
        }

        private void btnResetPB_Click(object sender, EventArgs e)
        {
            loadInfo();
            txtMAPB.Text = "";
            txtTENPB.Text ="";
            txtTRPHG.Text = "";
        }

        private void btnResetNV_Click(object sender, EventArgs e)
        {
            loadInfo();
            txtMANV.Text = "";
            txtTENNV.Text = "";
            txtPHAI.Text = "";
            txtNGAYSINH.Text = "";
            txtDIACHI.Text = "";
            txtSODT.Text = "";
            txtLUONG.Text = "";
            txtPHUCAP.Text = "";
            txtVAITRO.Text = "";
            txtMAQL.Text = "";
            txtPHG.Text = "";
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if(AdminstratorDAO.checkMaNHANVIEN(txtMANV.Text)!=1) MessageBox.Show("Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (AdminstratorDAO.updateNHANVIEN(txtMANV.Text, txtTENNV.Text, txtPHAI.Text, txtNGAYSINH.Text, txtDIACHI.Text, txtSODT.Text, txtVAITRO.Text, txtMAQL.Text, txtPHG.Text) ==1)
                 MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        } 
                
        }

        private void btnCreateNV_Click(object sender, EventArgs e)
        {
            if (AdminstratorDAO.checkMaNHANVIEN(txtMANV.Text) == 1) MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(AdminstratorDAO.createNHANVIEN(txtMANV.Text, txtTENNV.Text, txtPHAI.Text, txtNGAYSINH.Text, txtDIACHI.Text, txtSODT.Text, txtVAITRO.Text, txtMAQL.Text, txtPHG.Text)==1)
                MessageBox.Show("Tạo nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdatePB_Click(object sender, EventArgs e)
        {
            if (AdminstratorDAO.checkMaNHANVIEN(txtMAPB.Text) != 1) MessageBox.Show("Mã phòng ban không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(AdminstratorDAO.updatePHONGBAN(txtMAPB.Text,txtTENPB.Text,txtTRPHG.Text)==1)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void btnCreatePB_Click(object sender, EventArgs e)
        {
            if (AdminstratorDAO.checkMaNHANVIEN(txtMAPB.Text) == 1) MessageBox.Show("Mã phòng ban đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (AdminstratorDAO.createPHONGBAN(txtMAPB.Text, txtTENPB.Text, txtTRPHG.Text) == 1)
                    MessageBox.Show("Tạo phòng ban mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
