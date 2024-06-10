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
    public partial class frmDM_SanPham : Form
    {
        public frmDM_SanPham()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        public Panel pnSanPham;

        void loadDataGridView()
        {
            string sql = "select * from SanPham";
            DataTable dt = db.getTable(sql);
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.DataSource = dt;

            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá";
            dgvSanPham.Columns["MaLoai"].HeaderText = "Loại Sản Phẩm";
            dgvSanPham.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        void loadCbo_LoaiSP()
        {
            string sql = "select * from LoaiSanPham";
            DataTable dt = db.getTable(sql);
            cboLoaiSP.DataSource = dt;
            cboLoaiSP.DisplayMember = "TenLoai";
            cboLoaiSP.ValueMember = "MaLoai";
            cboLoaiSP.Text = null;
        }

        void AutoNhapMaSP()
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "pc_TimMaTiepTheo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "SanPham";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string nextId = cmd.Parameters["@id"].Value.ToString();
            con.Close();
            txtMaSP.Text = nextId;
        }

        private void frmDM_SanPham_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadCbo_LoaiSP();
            AutoNhapMaSP();
        }

        private void load()
        {
            loadDataGridView();
            AutoNhapMaSP();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DBConnect.conStr);

                var loaiSP = this.cboLoaiSP.GetItemText(this.cboLoaiSP.SelectedValue);
                var trangThai = this.cboTrangThai.GetItemText(this.cboTrangThai.SelectedItem);
                string sql = "insert into SanPham (TenSanPham, GiaBan, MaLoai, TrangThai) values (N'" + txtTenSP.Text + "', " + txtGiaBan.Text + ", '" + loaiSP + "', N'" + trangThai + "')";
                con.Open();
                SqlCommand cmd= new SqlCommand();
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
                load();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DBConnect.conStr);
                var loaiSP = this.cboLoaiSP.GetItemText(this.cboLoaiSP.SelectedValue);
                var trangThai = this.cboTrangThai.GetItemText(this.cboTrangThai.SelectedItem);
                string sql = "update SanPham set TenSanPham = N'" + txtTenSP.Text + "', GiaBan = " + txtGiaBan.Text + ", MaLoai = '" + loaiSP + "', TrangThai = N'" + trangThai + "' where MaSanPham = '" + txtMaSP.Text + "'";
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
                DataGridViewRow row = this.dgvSanPham.Rows[selectedRowIndex];
                string maSP = row.Cells["MaSanPham"].Value.ToString();
                dgvSanPham.Rows.RemoveAt(selectedRowIndex);

                string sql = "delete from SanPham where MaSanPham = '" + maSP + "'";

                int k = db.execNonQuery(sql);
                if (k != 0)
                {
                    MessageBox.Show("Đã xóa thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Không thể nào!", "Thông báo!", MessageBoxButtons.OK);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchData = txtTimKiem.Text;
            (dgvSanPham.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenSanPham LIKE '%" + searchData + "%'");
        }

        private int selectedRowIndex;

        private string GetTenLoai(string maLoai)
        {
            string tenLoai = string.Empty;

            string sql = "select TenLoai from LoaiSanPham where MaLoai = @MaLoai";

            using (SqlConnection conn = new SqlConnection(DBConnect.conStr))
            {
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLoai", maLoai);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if(result != null)
                    {
                        tenLoai = result.ToString();
                    }
                }
            }
            return tenLoai;
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                DataGridViewRow selectedRow = dgvSanPham.Rows[selectedRowIndex];

                txtMaSP.Text = selectedRow.Cells["MaSanPham"].Value.ToString();
                txtTenSP.Text = selectedRow.Cells["TenSanPham"].Value.ToString();
                txtGiaBan.Text = selectedRow.Cells["GiaBan"].Value.ToString();

                string maLoai = selectedRow.Cells["MaLoai"].Value.ToString();
                string tenLoai = GetTenLoai(maLoai);

                cboLoaiSP.Text = tenLoai;
                cboTrangThai.SelectedItem = selectedRow.Cells["TrangThai"].Value.ToString();

                if (selectedRow.Cells["TrangThai"].Value.ToString() == "")
                {
                    cboTrangThai.Text = null;
                }
            }
            else {
                MessageBox.Show("Bạn phải chọn dữ liệu cần sửa!", "Error!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            AutoNhapMaSP();
            loadDataGridView();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            cboLoaiSP.Text = null;
            cboTrangThai.Text = null;
            txtTenSP.Focus();
        }
    }
}
