using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe.GUI
{
    public partial class frmNguyenLieu : Form
    {
        public Panel pn_NguyenLieu;
        public frmNguyenLieu()
        {
            InitializeComponent();
            loadNguyenLieu();
        }

        private void loadNguyenLieu()
        {
            DataTable dt = NguyenLieuDAO.layDSNguyenLieu();

            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dgvNL.DataSource = dt;
        }

        private void dgvNL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNL.Rows[e.RowIndex];
                txtNguyenLieu.Text = row.Cells["TenNL"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvNL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNL.SelectedRows[0];
                string maNL = selectedRow.Cells["MaNL"].Value.ToString();
                int soLuong;
                if (int.TryParse(txtSoLuong.Text, out soLuong))
                {
                    int rowsAffected = NguyenLieuDAO.capNhatSoLuongNguyenLieu(maNL, soLuong);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        loadNguyenLieu();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!");
            }
        }
    }
}
