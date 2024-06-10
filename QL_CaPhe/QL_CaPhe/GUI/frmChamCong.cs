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
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
            loadCaLam();
            loadNhanVien();
        }


        private void loadNhanVien()
        {
            DataTable dt = NhanVienDAO.layDSNhanVien();

            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";
        }

        private void loadCaLam()
        {
            DataTable dt = CaLamDAO.layDSCaLam();

            cboMaCL.DataSource = dt;
            cboMaCL.DisplayMember = "MaCaLam";
            cboMaCL.ValueMember = "MaCaLam";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                string maNV = cboNhanVien.SelectedValue.ToString();
                string maCL = cboMaCL.SelectedValue.ToString();
                DateTime ngayLam = DateTime.Now; 

                ChiTietCaLamDAO.luuCTCL(maCL, maNV,ngayLam);

                // Thông báo lưu thành công
                MessageBox.Show("Lưu thông tin ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
}
