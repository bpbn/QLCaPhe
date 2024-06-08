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
            //loadBangLuong();
            loadCTCL();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void loadNhanVien()
        {
            DataTable dt = NhanVienDAO.layDSNhanVien();

            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "MaNhanVien";
            cboMaNV.ValueMember = "MaNhanVien";
        }

        private void loadCTCL()
        {
            DataTable dt = ChiTietCaLamDAO.layDSCTCL();

            dgvCaLam.DataSource = dt;
        }


        //private void loadBangLuong()
        //{
        //    DataTable dt = BangLuongDAO.layDSBangLuong();

        //    DataColumn[] key = new DataColumn[1];
        //    key[0] = dt.Columns[0];
        //    dt.PrimaryKey = key;
        //    dgvTinhLuong.DataSource = dt;
        //}

    }
}
