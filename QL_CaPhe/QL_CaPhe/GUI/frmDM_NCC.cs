using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe.GUI
{
    public partial class frmDM_NCC : Form
    {
        public frmDM_NCC()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();
        public Panel pnNhaCungCap;

        void loadDataGridView()
        {
            string sql = "select * from NhaCungCap";
            DataTable dt = db.getTable(sql);
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.RowHeadersVisible = false;
            dgvNhaCungCap.DataSource = dt;

            dgvNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên Sản Phẩm";
            dgvNhaCungCap.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvNhaCungCap.Columns["Email"].HeaderText = "Email";
            dgvNhaCungCap.Columns["DiaChi"].HeaderText = "Địa Chỉ";
        }

        void AutoNhapMaNCC()
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "pc_TimMaTiepTheo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "NhaCungCap";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string nextId = cmd.Parameters["@id"].Value.ToString();
            con.Close();
            txtMaNCC.Text = nextId;
        }

        private void frmDM_NCC_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            AutoNhapMaNCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DBConnect.conStr);
                string sql = "insert into NhaCungCap (TenNhaCungCap, SoDienThoai, Email, DiaChi) values (N'" + txtTenNCC.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + txtDiaChi.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                int k = (int)cmd.ExecuteNonQuery();
                con.Close();
                if (k != 0)
                {
                    MessageBox.Show("Đã thêm thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("Không thể thêm!", "Thông báo!", MessageBoxButtons.OK);
                frmDM_NCC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DBConnect.conStr);
                string sql = "update NhaCungCap set TenSanPham = N'" + txtTenNCC.Text + "', SoDienThoai = '" + txtSDT.Text + "', Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "' where MaNhaCungCap = '" + txtMaNCC.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                int k = (int)cmd.ExecuteNonQuery();
                con.Close();
                if (k != 0)
                {
                    MessageBox.Show("Đã sửa thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể sửa!", "Thông báo!", MessageBoxButtons.OK);
                }
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvNhaCungCap.Rows[selectedRowIndex];
                string maNCC = row.Cells["MaNhaCungCap"].Value.ToString();
                dgvNhaCungCap.Rows.RemoveAt(selectedRowIndex);

                string sql = "delete from SanPham where MaSanPham = '" + maNCC + "'";

                int k = db.execNonQuery(sql);
                if (k != 0)
                {
                    MessageBox.Show("Đã xóa thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Không thể nào!", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDataGridView();
            AutoNhapMaNCC();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtTenNCC.Focus();
        }

        private int selectedRowIndex;
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                DataGridViewRow selectedRow = dgvNhaCungCap.Rows[selectedRowIndex];

                txtMaNCC.Text = selectedRow.Cells["MaNhaCungCap"].Value.ToString();
                txtTenNCC.Text = selectedRow.Cells["TenNhaCungCap"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Bạn phải chọn dữ liệu cần sửa!", "Error!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchData = txtTimKiem.Text;
            (dgvNhaCungCap.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenNhaCungCap LIKE '%" + searchData + "%'");
        }
    }
}
