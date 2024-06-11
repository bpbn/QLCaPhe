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
    public partial class frmDashboard : Form
    {
        private DashboardDAO model;
        private Button currentButton;
        
        public frmDashboard()
        {
            InitializeComponent();
            dtp_StartDate.Value = DateTime.Today.AddDays(-7);
            dtp_EndDate.Value = DateTime.Now;
            btn_7NgayGanNhat.Select();
            SetDateMenuButtonUI(btn_7NgayGanNhat);
            model = new DashboardDAO();
            loadData();
        }

        private void loadData()
        {
            var refreshData = model.LoadData(dtp_StartDate.Value, dtp_EndDate.Value);
            if (refreshData)
            {
                lb_SoDonHang.Text = model.SoDH.ToString();
                lb_TongSoPhieuNhap.Text = model.SoPN.ToString();
                lb_TongDoanhThu.Text = model.TongDoanhThu.ToString() + "đ";
                lb_TongChi.Text = model.TongChiTien.ToString();
                lb_LoiNhuan.Text = (model.TongDoanhThu - model.TongChiTien).ToString() + "đ";

                lb_SoNCC.Text = model.SoNCC.ToString();
                lb_SoMatHang.Text = model.SoSanPham.ToString();

                Chart_TinhHinhDoanhThu.DataSource = model.ListDoanhThu;
                Chart_TinhHinhDoanhThu.Series[0].XValueMember = "Date";
                Chart_TinhHinhDoanhThu.Series[0].YValueMembers = "TotalAmount";
                Chart_TinhHinhDoanhThu.DataBind();

                Chart_TinhHinhChi.DataSource = model.ListChiTien;
                Chart_TinhHinhChi.Series[0].XValueMember = "Date";
                Chart_TinhHinhChi.Series[0].YValueMembers = "TotalAmount";
                Chart_TinhHinhChi.DataBind();

                Chart_Top5SanPham.DataSource = model.ListTopSP;
                Chart_Top5SanPham.Series[0].XValueMember = "Key";
                Chart_Top5SanPham.Series[0].YValueMembers = "Value";
                Chart_Top5SanPham.DataBind();

                dgv_NLSapHetHang.DataSource = model.ListNLSapHetHang;
                dgv_NLSapHetHang.Columns[0].HeaderText = "Tên sản phẩm";
                dgv_NLSapHetHang.Columns[1].HeaderText = "Sl";

            }
        }

        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button) button;
            btn.BackColor = btn_30NgayGanNhat.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if(currentButton != null && currentButton != btn)
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.MidnightBlue;
            }
            currentButton = btn;

            if (btn == btn_Chon)
            {
                dtp_StartDate.Enabled = true;
                dtp_EndDate.Enabled = true;
                btn_OK.Visible = true;
                lb_NgayBD.Cursor = Cursors.Hand;
                lb_NgayKT.Cursor = Cursors.Hand;
            }
            else
            {
                dtp_StartDate.Enabled = false;
                dtp_EndDate.Enabled = false;
                btn_OK.Visible = false;
                lb_NgayBD.Cursor = Cursors.Default;
                lb_NgayKT.Cursor = Cursors.Default;
            }
        }

        private void btn_HomNay_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today;
            dtp_EndDate.Value = DateTime.Now;
            loadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_7NgayGanNhat_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today.AddDays(-7);
            dtp_EndDate.Value= DateTime.Now;
            loadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_30NgayGanNhat_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = DateTime.Today.AddDays(-30);
            dtp_EndDate.Value = DateTime.Now;
            loadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_ThangNay_Click(object sender, EventArgs e)
        {
            dtp_StartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtp_EndDate.Value = DateTime.Now;
            loadData();
            SetDateMenuButtonUI(sender);
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void lb_NgayBD_Click(object sender, EventArgs e)
        {
            if(currentButton == btn_Chon)
            {
                dtp_StartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lb_NgayKT_Click(object sender, EventArgs e)
        {
            if (currentButton == btn_Chon)
            {
                dtp_EndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            lb_NgayBD.Text = dtp_StartDate.Text;
        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {
            lb_NgayKT.Text = dtp_EndDate.Text;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lb_NgayBD.Text = dtp_StartDate.Text;
            lb_NgayKT.Text = dtp_EndDate.Text;
            dgv_NLSapHetHang.Columns[1].Width = 50;
        }

        private void ptc_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
