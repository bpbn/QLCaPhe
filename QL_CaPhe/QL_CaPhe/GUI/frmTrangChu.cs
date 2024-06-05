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
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.TopLevel = false;
            pn_TrangChu.Controls.Clear();
            pn_TrangChu.Controls.Add(f.pn_BanHang);
            f.Show();
        }
    }
}
