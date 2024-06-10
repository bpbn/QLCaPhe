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
    public partial class frmDM_HoaDonNhap : Form
    {
        public frmDM_HoaDonNhap()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        public Panel pnPhieuNhap;

        void loadDataGridViewPhieuNhap()
        {
            string sql = "select * from PhieuNhap";
            DataTable dt = db.getTable(sql);
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.DataSource = dt;

            dgvPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuNhap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvPhieuNhap.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
        }

        void loadDataGridViewCTPN(string maPhieuNhap)
        {
            string sql = $"select * from ChiTietPhieuNhap where MaPhieuNhap = '{maPhieuNhap}'";
            DataTable dt = db.getTable(sql);
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.RowHeadersVisible = false;
            dgvCTPN.DataSource = dt;

            dgvCTPN.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvCTPN.Columns["MaNguyenLieu"].HeaderText = "Mã Nguyên Liệu";
            dgvCTPN.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvCTPN.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvCTPN.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvCTPN.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }
        private void frmDM_HoaDonNhap_Load(object sender, EventArgs e)
        {
            loadDataGridViewPhieuNhap();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayNhap.Value.Date; // Lấy giá trị ngày được chọn từ DateTimePicker
            string sql = $"select * from PhieuNhap where CAST(NgayNhap AS DATE) = '{selectedDate.ToString("yyyy-MM-dd")}'";
            DataTable dt = db.getTable(sql);
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.DataSource = dt;

            dgvPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuNhap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvPhieuNhap.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGridViewPhieuNhap();
            dgvCTPN.DataSource = null; // Xóa dữ liệu của dgvCTHD
            dgvCTPN.Rows.Clear();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để đảm bảo rằng hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                string maPhieuNhap = row.Cells["MaPhieuNhap"].Value.ToString();
                loadDataGridViewCTPN(maPhieuNhap);
            }
        }
    }
}
