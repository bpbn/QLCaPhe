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
        public frmDN_DK()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        private void clearInfo()
        {
            txt_TenTK.Clear();
            txt_Password.Clear();
            txt_ConfirmPassword.Clear();
        }

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

        private bool IsEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, pattern);
        }

        private bool checkInfoDangKy()
        {
            if (txt_TenTK.Text == string.Empty || txt_Password.Text == string.Empty)
                return false;
            return true;
        }

        private bool checkInfoDangNhap()
        {
            if (txt_TenTK.Text == string.Empty || txt_Password.Text == string.Empty)
                return false;
            return true;
        }

        private bool CheckPrimaryKey(string primaryKey)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.conStr))
            {
                con.Open();
                string sql = "SELECT MATKHAU FROM TAIKHOAN WHERE TENDANGNHAP = '" + primaryKey + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                string pass = Convert.ToString(cmd.ExecuteScalar());
                int affectedRows = cmd.ExecuteNonQuery();
                if (pass != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    if (!checkInfoDangNhap())
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!CheckPrimaryKey(txt_TenTK.Text))
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    using (SqlConnection con = new SqlConnection(DBConnect.conStr))
                    {
                        con.Open();
                        string sql = "SELECT MATKHAU, MaChucVu FROM TAIKHOAN WHERE TenDangNhap = @username AND MATKHAU = @password";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("@username", txt_TenTK.Text));
                        cmd.Parameters.Add(new SqlParameter("@password", txt_Password.Text));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string password = reader.GetString(0); 
                                string MaChucVu = reader.GetString(1); 

                                if (password == txt_Password.Text) 
                                {
                                    Properties.Settings.Default.LoaiTK = MaChucVu;
                                    Properties.Settings.Default.Save();
                                    this.Hide();
                                    frmTrangChu f = new frmTrangChu();
                                    f.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Sai mật khẩu!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
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
