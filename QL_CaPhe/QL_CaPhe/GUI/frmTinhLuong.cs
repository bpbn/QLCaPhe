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
