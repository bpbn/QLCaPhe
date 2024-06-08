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
    public partial class frmTinhLuong : Form
    {
        public Panel pn_TinhLuong;
        public frmTinhLuong()
        {
            InitializeComponent();
            loadNhanVien();
            loadBangLuong();
            //cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
            //btnThanhToan.Click += btnThanhToan_Click;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex >= 0)
            {
                string maNV = cboMaNV.SelectedValue.ToString();
                loadCTCL(maNV);
                loadNhanVienDetails(maNV);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex >= 0)
            {
                string maNV = cboMaNV.SelectedValue.ToString();

                // Lấy các giá trị cần thiết từ các label hoặc từ các biến
                int luong = int.Parse(lbTienLuong.Text);
                int phuCap = int.Parse(lbPhuCap.Text);
                DateTime ngayTraLuong = DateTime.Now; // Hoặc lấy từ một điều khiển datetime picker nếu có

                // Lưu thông tin vào bảng BangLuong
                BangLuongDAO.luuBangLuong(maNV, luong, phuCap, ngayTraLuong);

                // Thông báo lưu thành công
                MessageBox.Show("Lưu thông tin lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại bảng lương để hiển thị thông tin mới
                loadBangLuong();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadNhanVien()
        {
            DataTable dt = NhanVienDAO.layDSNhanVien();

            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
            cboMaNV.DataSource = dt;

        }

        private void loadNhanVienDetails(string maNV)
        {
            string tongLuong = BangLuongDAO.layTongLuong(maNV);
            lbTienLuong.Text = tongLuong;

            string phuCap = BangLuongDAO.layTongPhuCap(maNV);
            lbPhuCap.Text = phuCap;

            string tongGioLam = BangLuongDAO.layTongGioLam(maNV);
            lbTongGio.Text = tongGioLam;

            string tenNhanVien = NhanVienDAO.layTenNhanVien(maNV);
            lbTenNV.Text = tenNhanVien;

            // Lấy và hiển thị chức vụ
            string chucVu = NhanVienDAO.layChucVu(maNV);
            lbChucVu.Text = chucVu;

            // Lấy và hiển thị ngày trả lương gần nhất
            DateTime ngayTraLuongGanNhat = BangLuongDAO.layNgayTraLuongGanNhat(maNV);
            lbTuNgay.Text = ngayTraLuongGanNhat.ToString("dd-MM-yyyy");

            // Lấy và hiển thị ngày hiện tại
            lbDenNgay.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        private void loadCTCL(string maNV)
        {
            DataTable dt = ChiTietCaLamDAO.layDSCTCL(maNV);

            dgvCaLam.DataSource = dt;
        }


        private void loadBangLuong()
        {
            DataTable dt = BangLuongDAO.layDSBangLuong();

            dgvTinhLuong.DataSource = dt;
        }
        
        
    }
}
