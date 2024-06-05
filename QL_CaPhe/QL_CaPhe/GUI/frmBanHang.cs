using QL_CaPhe.DAO;
using QL_CaPhe.POJO;
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
    public partial class frmBanHang : Form
    {
        public Panel pn_BanHang;
        public frmBanHang()
        {
            InitializeComponent();
            loadNhaCungCap();
            loadSanPham();
        }

        private void loadNhaCungCap()
        {
            DataTable dt = NhaCungCapDAO.layDSNhaCungCap();

            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TenNhaCungCap";
            cboNCC.ValueMember = "MaNhaCungCap";
        }

        private void loadSanPham()
        {
            DataTable dt = SanPhamDAO.layDSSanPham();

            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dgv_SanPham.DataSource = dt;
        }
    }
}
