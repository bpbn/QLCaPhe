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
    public partial class frmDM_HoaDonBan : Form
    {
        public frmDM_HoaDonBan()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();

        public Panel pnHoaDon;

        void loadDataGridViewHoaDon()
        {
            string sql = "select * from HoaDon";
            DataTable dt = db.getTable(sql);
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.DataSource = dt;

            dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns["ThoiGianLap"].HeaderText = "Thời Gian Lập";
            dgvHoaDon.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }

        void loadDataGridViewCTHD(string maHoaDon)
        {
            string sql = $"select * from ChiTietHoaDon where MaHoaDon = '{maHoaDon}'";
            DataTable dt = db.getTable(sql);
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.DataSource = dt;

            dgvCTHD.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvCTHD.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvCTHD.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvCTHD.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvCTHD.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }

        private void frmDM_HoaDonBan_Load(object sender, EventArgs e)
        {
            loadDataGridViewHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để đảm bảo rằng hàng được chọn là hợp lệ
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                string maHoaDon = row.Cells["MaHoaDon"].Value.ToString();
                loadDataGridViewCTHD(maHoaDon);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayLap.Value.Date; // Lấy giá trị ngày được chọn từ DateTimePicker
            string sql = $"select * from HoaDon where CAST(ThoiGianLap AS DATE) = '{selectedDate.ToString("yyyy-MM-dd")}'";
            DataTable dt = db.getTable(sql);
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.DataSource = dt;

            dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvHoaDon.Columns["ThoiGianLap"].HeaderText = "Thời Gian Lập";
            dgvHoaDon.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGridViewHoaDon();
            dgvCTHD.DataSource = null; // Xóa dữ liệu của dgvCTHD
            dgvCTHD.Rows.Clear();
        }
    }
}
