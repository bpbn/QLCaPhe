using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe.GUI
{
    public partial class frmDN_DK : Form
    {
        private TaiKhoanDAO tk = new TaiKhoanDAO();

        public frmDN_DK()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        private void LoadData()
        {
            txt_TenTK.Text = Properties.Settings.Default.Username;
            txt_Password.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Username != string.Empty)
            {
                ck_RememberMe.Checked = true;
            }
        }

        private void From_DN_DK_Load(object sender, EventArgs e)
        {
            LoadData();
            ck_RememberMe.Visible = true;
            panel2.Visible = false;
        }

        private bool checkInfoDangNhap()
        {
            if (txt_TenTK.Text == string.Empty || txt_Password.Text == string.Empty)
                return false;
            return true;
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (!checkInfoDangNhap())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!tk.CheckPrimaryKey(txt_TenTK.Text))
            {
                MessageBox.Show("Tài khoản không tồn tại!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(tk.checkDangNhapHople(txt_TenTK.Text, txt_Password.Text))
            {
                this.Hide();
                frmTrangChu f = new frmTrangChu();
                f.Show();
            }    
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
        }

        private void ck_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInfoDangNhap())
            {
                if (ck_RememberMe.Checked)
                {
                    Properties.Settings.Default.Username = txt_TenTK.Text;
                    Properties.Settings.Default.Password = txt_Password.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {
                txt_Password.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.hide;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.view;
            }
        } 
    }
}
