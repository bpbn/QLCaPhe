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
    public partial class frmNhapHang : Form
    {
        public Panel pnNhapHang;
        public frmNhapHang()
        {
            InitializeComponent();
            loadNCC();
            loadNhanVien();
            loadNguyenLieu();
        }

        private void loadNCC()
        {
            List<NhaCungCap> dt = NhaCungCap.LayDSNhaCungCap();

            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TenNhaCungCap";
            cboNCC.ValueMember = "MaNhaCungCap";
        }

        private void loadNhanVien()
        {

            List<NhanVien> dt = NhanVien.LayDanhSachNhanVienKho();

            cboNhanVienKho.DataSource = dt;
            cboNhanVienKho.DisplayMember = "TenNhanVien";
            cboNhanVienKho.ValueMember = "MaNhanVien";
        }
        
        private void loadNguyenLieu()
        {
            List<NguyenLieu> dt = NguyenLieu.LayDSNguyenLieu();
            dgvNguyenLieu.DataSource = dt;
        }

        private void txtNguyenLieu_TextChanged(object sender, EventArgs e)
        {
            List<NguyenLieu> dt = NguyenLieu.TimNguyenLieu(txtNguyenLieu.Text);
            dgvNguyenLieu.DataSource = dt;
        }

        private void btnTimNL_Click(object sender, EventArgs e)
        {
            List<NguyenLieu> dt = NguyenLieu.TimNguyenLieu(txtNguyenLieu.Text);
            dgvNguyenLieu.DataSource = dt;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng trong DataGridView1 chưa
            if (dgvNguyenLieu.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đã chọn trong DataGridView1
                DataGridViewRow selectedRow = dgvNguyenLieu.SelectedRows[0];
                string MANL = selectedRow.Cells["MaNguyenLieu"].Value.ToString();
                string TENNL = selectedRow.Cells["TenNguyenLieu"].Value.ToString();

                // Lấy số lượng từ TextBox
                if (int.TryParse(txtSoLuong.Text, out int SOLUONG) && int.TryParse(txtGiaNhap.Text, out int GIANHAP))
                {
                    int THANHTIEN = GIANHAP * SOLUONG;

                    bool itemExists = false;
                    int existingRowIndex = -1;

                    // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView2 hay chưa
                    for (int i = 0; i < dgvCTPN.Rows.Count; i++)
                    {
                        if (dgvCTPN.Rows[i].Cells["MANL"].Value.ToString() == MANL)
                        {
                            itemExists = true;
                            existingRowIndex = i;
                            break;
                        }
                    }

                    // Nếu sản phẩm đã tồn tại, cập nhật thông tin của nó
                    if (itemExists)
                    {
                        int sl = Convert.ToInt32(dgvCTPN.Rows[existingRowIndex].Cells["SoLuong"].Value);
                        int tt = Convert.ToInt32(dgvCTPN.Rows[existingRowIndex].Cells["ThanhTien"].Value);

                        int slCapNhat = sl + SOLUONG;
                        int ttCapNhat = tt + THANHTIEN;

                        dgvCTPN.Rows[existingRowIndex].Cells["SoLuong"].Value = slCapNhat;
                        dgvCTPN.Rows[existingRowIndex].Cells["ThanhTien"].Value = ttCapNhat;
                    }
                    else
                    {
                        dgvCTPN.Rows.Add(MANL, TENNL, GIANHAP, SOLUONG, THANHTIEN);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng và giá nhập hợp lệ!");
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
            txtGiaNhap.Clear();
        }

        private int tinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dgvCTPN.Rows)
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
            foreach (DataGridViewRow row in dgvCTPN.Rows)
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
            if (dgvCTPN.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCTPN.SelectedRows)
                {
                    dgvCTPN.Rows.Remove(row);
                }
                capNhatTongTien_SL();

            }
        }

        private void capNhatTongTien_SL()
        {
            int tongTien = 0;
            int tongSL = 0;

            foreach (DataGridViewRow row in dgvCTPN.Rows)
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
            DialogResult result = MessageBox.Show("Bạn có muốn nhập đơn hàng có thông tin: \n Nhân viên: " + cboNhanVienKho.Text + " \n Nhà cung cấp: " + cboNCC.Text + " \n Tổng Tiền: " + lbTongTien.Text + " \n Tổng Số lượng: " + lbTongSoLuong.Text, "Xuất hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                luuPhieuNhap();
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCTPN.Rows.Clear();
                lbTongSoLuong.Text = string.Empty;
                lbTongTien.Text = string.Empty;
            }
        }

        private void luuPhieuNhap()
        {
            string maNV = cboNhanVienKho.SelectedValue.ToString();
            string maNCC = cboNCC.SelectedValue.ToString();

            bool isSaved = PhieuNhap.LuuPhieuNhap(maNCC, maNV);

            if (isSaved)
            {
                string maPhieuNhap = ChiTietPhieuNhap.LayMaPhieuNhapMoiNhat().ToString();
                luuChiTietPhieuNhap(maPhieuNhap);
            }
        }

        private void luuChiTietPhieuNhap(string maPN)
        {
            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                string maNL = row.Cells["MANL"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                int giaNhap = Convert.ToInt32(row.Cells["Gia"].Value);

                ChiTietPhieuNhap.LuuChiTietPhieuNhap(maPN, maNL, soLuong, giaNhap);
            }
        }
    }
}
