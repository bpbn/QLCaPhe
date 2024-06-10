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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();
            this.Hide();
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmDM_SanPham f = new frmDM_SanPham();
            f.TopLevel = false;
            pn_DanhMuc.Controls.Clear();
            pn_DanhMuc.Controls.Add(f.pnSanPham);
            f.Show();
            pnBtnHoaDon.Visible = false;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmDM_NCC f = new frmDM_NCC();
            f.TopLevel = false;
            pn_DanhMuc.Controls.Clear();
            pn_DanhMuc.Controls.Add(f.pnNhaCungCap);
            f.Show();
            pnBtnHoaDon.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDM_NhanVien f = new frmDM_NhanVien();
            f.TopLevel = false;
            pn_DanhMuc.Controls.Clear();
            pn_DanhMuc.Controls.Add(f.pnNhanVien);
            f.Show();
            pnBtnHoaDon.Visible = false;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            pnBtnHoaDon.Visible = true;
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            frmDM_HoaDonBan f = new frmDM_HoaDonBan();
            f.TopLevel = false;
            pn_DanhMuc.Controls.Clear();
            pn_DanhMuc.Controls.Add(f.pnHoaDon);
            f.Show();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            frmDM_HoaDonNhap f = new frmDM_HoaDonNhap();
            f.TopLevel = false;
            pn_DanhMuc.Controls.Clear();
            pn_DanhMuc.Controls.Add(f.pnPhieuNhap);
            f.Show();
        }
    }
}
