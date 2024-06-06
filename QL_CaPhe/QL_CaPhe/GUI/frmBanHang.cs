using QL_CaPhe.DAO;
using QL_CaPhe.POJO;
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
    public partial class frmBanHang : Form
    {
        public Panel pn_BanHang;
        public frmBanHang()
        {
            InitializeComponent();
            loadSanPham();
        }

        //private void loadNhaCungCap()
        //{
        //    DataTable dt = NhaCungCapDAO.layDSNhaCungCap();

        //    cboNCC.DataSource = dt;
        //    cboNCC.DisplayMember = "TenNhaCungCap";
        //    cboNCC.ValueMember = "MaNhaCungCap";
        //}

        private void loadSanPham()
        {
            DataTable dt = SanPhamDAO.layDSSanPham();

            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dgvSanPham.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = SanPhamDAO.timSanPham(txtSanPham.Text);
            dgvSanPham .DataSource = dt;
        }

        private void txtSanPham_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = SanPhamDAO.timSanPham(txtSanPham.Text);
            dgvSanPham.DataSource = dt;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng trong DataGridView1 chưa
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đã chọn trong DataGridView1
                DataGridViewRow selectedRow = dgvSanPham.SelectedRows[0];
                string MASP = selectedRow.Cells["MaSanPham"].Value.ToString();
                string TENSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                int GIABAN = Convert.ToInt32(selectedRow.Cells["GiaBan"].Value);

                // Lấy số lượng từ TextBox
                if (int.TryParse(txtSoLuong.Text, out int SOLUONG))
                {
                    int THANHTIEN = GIABAN * SOLUONG;

                    bool itemExists = false;
                    int existingRowIndex = -1;

                    // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView2 hay chưa
                    for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                    {
                        if (dgvCTHD.Rows[i].Cells["MASP"].Value.ToString() == MASP)
                        {
                            itemExists = true;
                            existingRowIndex = i;
                            break;
                        }
                    }

                    // Nếu sản phẩm đã tồn tại, cập nhật thông tin của nó
                    if (itemExists)
                    {
                        int sl = Convert.ToInt32(dgvCTHD.Rows[existingRowIndex].Cells["SoLuong"].Value);
                        int tt = Convert.ToInt32(dgvCTHD.Rows[existingRowIndex].Cells["ThanhTien"].Value);

                        int slCapNhat = sl + SOLUONG;
                        int ttCapNhat = tt + THANHTIEN;

                        dgvCTHD.Rows[existingRowIndex].Cells["SoLuong"].Value = slCapNhat;
                        dgvCTHD.Rows[existingRowIndex].Cells["ThanhTien"].Value = ttCapNhat;
                    }
                    else
                    {
                        dgvCTHD.Rows.Add(MASP, TENSP, GIABAN, SOLUONG, THANHTIEN);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            lbTongTien.Text = tinhTongTien().ToString();
            lbTongTien.Visible = true;
            lbTongSoLuong.Text = tinhTongSL().ToString();
            lbTongSoLuong.Visible = true;
            txtSoLuong.Clear();
        }

        private int tinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                    tongTien += thanhTien;
                }
            }
            return tongTien;
        }

        private int tinhTongSL()
        {
            int tongSL = 0;
            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                if (row.Cells["SoLuong"].Value != null)
                {
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    tongSL += soLuong;
                }
            }
            return tongSL;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCTHD.SelectedRows)
                {
                    dgvCTHD.Rows.Remove(row);
                }
                capNhatTongTien_SL();

            }
        }

        private void capNhatTongTien_SL()
        {
            int tongTien = 0;
            int tongSL = 0;

            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                tongTien += thanhTien;
                tongSL += soLuong;

                lbTongTien.Text = tongTien.ToString();
                lbTongTien.Visible = true;
                lbTongSoLuong.Text = tongSL.ToString();
                lbTongSoLuong.Visible = true;
            }

            lbTongTien.Text = tongTien.ToString();
            lbTongTien.Visible = true;
            lbTongSoLuong.Text = tongSL.ToString();
            lbTongSoLuong.Visible = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn nhập đơn hàng có thông tin: \n Nhân viên: " + "NV002" +  " \n Tổng Tiền: " + lbTongTien.Text + " \n Tổng Số lượng: " + lbTongSoLuong.Text, "Xuất hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                luuDonHang();
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCTHD.Rows.Clear();
                lbTongSoLuong.Text = string.Empty;
                lbTongTien.Text = string.Empty;
            }
        }

        private void luuDonHang()
        {
            string maNV = "NV002";

            int isSaved = DonHangDAO.luuDonHang(maNV);

            if (isSaved > 0)
            {
                string maDonHang = ChiTietDonHangDAO.layMaDonHangMoiNhat().ToString();
                luuChiTietDonHang(maDonHang);
            }
        }

        private void luuChiTietDonHang(string maDonHang)
        {
            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                string maSP = row.Cells["MASP"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                ChiTietDonHangDAO.luuChiTietDonHang(maDonHang, maSP, soLuong);
            }
        }
    }
}
