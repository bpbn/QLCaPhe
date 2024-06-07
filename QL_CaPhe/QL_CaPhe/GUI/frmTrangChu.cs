using QL_CaPhe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            if (Properties.Settings.Default.LoaiTK == "BH")
            {
                btnThongKe.Enabled = false;
                btnKho.Enabled = false;
                btnTinhLuong.Enabled = false;
                btnBanHang.Enabled = true;
            }
            else if (Properties.Settings.Default.LoaiTK == "K")
            {
                btnThongKe.Enabled = false;
                btnKho.Enabled = true;
                btnTinhLuong.Enabled = false;
                btnBanHang.Enabled = false;
            }
            else if (Properties.Settings.Default.LoaiTK == "QL")
            {
                btnThongKe.Enabled = true;
                btnKho.Enabled = false;
                btnTinhLuong.Enabled = true;
                btnBanHang.Enabled = false;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.TopLevel = false;
            pn_TrangChu.Controls.Clear();
            pn_TrangChu.Controls.Add(f.pn_BanHang);
            f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmDashboard f = new frmDashboard();
            f.Show();
        }

        public void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDN_DK f = new frmDN_DK();
            f.Show();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmKho f = new frmKho();
            f.TopLevel = false;
            pn_TrangChu.Controls.Clear();
            pn_TrangChu.Controls.Add(f.pn_Kho);
            f.Show();
        }
    }
}
