using QLCaPhe.POJO;

namespace QLCaPhe
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
            pn_TrangChu.Controls.Add(f.pnBanHang);
            f.Show();
        }
    }
}
