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
    public partial class frmKho : Form
    {
        public Panel pn_Kho;
        public frmKho()
        {
            InitializeComponent();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            f.TopLevel = false;
            pnKho.Controls.Clear();
            pnKho.Controls.Add(f.pnNhapHang);
            f.Show();
        }
    }
}
