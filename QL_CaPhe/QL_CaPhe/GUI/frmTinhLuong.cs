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
        public Panel pnTimhLuong
        public frmTinhLuong()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void loadNhanVien()
        {
            DataTable dt = NhanVienDAO.layDSNhanVien();

            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "TenNhanVien" +
                "";
            cboMaNV.ValueMember = "MaNhanVien";
        }

    }
}
