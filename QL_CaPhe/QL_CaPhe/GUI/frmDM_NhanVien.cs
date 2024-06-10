using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CaPhe.GUI
{
    public partial class frmDM_NhanVien : Form
    {
        public frmDM_NhanVien()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        public Panel pnNhanVien;

        void loadDataGridView()
        {
            string sql = "select * from NhanVien";
            DataTable dt = db.getTable(sql);
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.DataSource = dt;

            dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân viên";
            dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
            dgvNhanVien.Columns["NgayNghi"].HeaderText = "Ngày Nghỉ Làm";
            dgvNhanVien.Columns["MaChucVu"].HeaderText = "Chức Vụ";
        }

        void loadCbo_MaChucVu()
        {
            string sql = "select * from ChucVu";
            DataTable dt = db.getTable(sql);
            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
            cboChucVu.Text = null;
        }

        void AutoNhapMaNV()
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "pc_TimMaTiepTheo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@table", SqlDbType.VarChar).Value = "NhanVien";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string nextId = cmd.Parameters["@id"].Value.ToString();
            con.Close();
            txtMaNV.Text = nextId;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(DBConnect.conStr);

                var chucVu = this.cboChucVu.GetItemText(this.cboChucVu.SelectedValue);
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string ngayVaoLam = dtpNgayVaoLam.Value.ToString("yyyy/MM/dd");

                string ngayNghiLam;

                if (cbNghiLam.Checked = false)
                    ngayNghiLam = "NULL";
                else
                {
                    pnNghiLam.Visible = true;
                    ngayNghiLam = dtpNgayNghiLam.Value.ToString("yyyy/MM/dd");
                }

                int gioiTinh;
                if (rdoNam.Checked)
                    gioiTinh = 1;
                else
                    gioiTinh = 0;

                string sql = "insert into NhanVien (TenNhanVien, NgaySinh, GioiTinh, DiaChi, NgayVaoLam, NgayNghi, MaChucVu) VALUES (N'" + txtTenNV.Text + "', '" + ngaySinh + "', " + gioiTinh + ", N'" + txtDiaChi.Text + "', '" + ngayVaoLam + "', " + ngayNghiLam + ", '" + chucVu + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                int k = db.execNonQuery(sql);
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

                var chucVu = this.cboChucVu.GetItemText(this.cboChucVu.SelectedValue);
                string ngaySinh = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string ngayVaoLam = dtpNgayVaoLam.Value.ToString("yyyy/MM/dd");

                string ngayNghiLam;

                if (cbNghiLam.Checked = false)
                    ngayNghiLam = "NULL";
                else
                {
                    pnNghiLam.Visible = true;
                    ngayNghiLam = dtpNgayNghiLam.Value.ToString("yyyy/MM/dd");
                }

                int gioiTinh;
                if (rdoNam.Checked)
                    gioiTinh = 1;
                else
                    gioiTinh = 0;

                string sql = "update NhanVien set TenNhanVien = N'" + txtTenNV.Text + "', NgaySinh = '" + ngaySinh + "', GioiTinh = " + gioiTinh + ", DiaChi = N'" + txtDiaChi.Text + "', NgayVaoLam = '" + ngayVaoLam + "', NgayNghi = '" + ngayNghiLam + "', MaChucVu = '" + chucVu + "' where MaNhanVien = '" + txtMaNV.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                int k = db.execNonQuery(sql);
                con.Close();
                if (k != 0)
                {
                    MessageBox.Show("Đã sửa thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("Không thể sửa!", "Thông báo!", MessageBoxButtons.OK);
                load();
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
                DataGridViewRow row = this.dgvNhanVien.Rows[selectedRowIndex];
                string maNhanVien = row.Cells["MaNhanVien"].Value.ToString();
                dgvNhanVien.Rows.RemoveAt(selectedRowIndex);

                string sql = "delete from NhanVien where MaNhanVien = '" + maNhanVien + "'";

                int k = db.execNonQuery(sql);
                if (k != 0)
                {
                    MessageBox.Show("Đã xoá thành công!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Không thể xoá!", "Thông báo!", MessageBoxButtons.OK);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtpNgaySinh.Checked = false;
            txtDiaChi.Clear();
            dtpNgayVaoLam.Checked = false;
            dtpNgayNghiLam.Checked = false;
            cboChucVu.Text = null;
            pnNghiLam.Visible = false;
            txtTenNV.Focus();
            load();
        }

        private void frmDM_NhanVien_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadCbo_MaChucVu();
            AutoNhapMaNV();
        }

        private void load()
        {
            loadDataGridView();
            AutoNhapMaNV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchData = txtTimKiem.Text;
            (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = string.Format("TenNhanVien LIKE '%" + searchData + "%'");
        }

        private int selectedRowIndex;

        private string GetTenChucVu(string maChucVu)
        {
            string tenLoai = string.Empty;

            string sql = "select TenChucVu from ChucVu where MaChucVu = @MaChucVu";

            using (SqlConnection conn = new SqlConnection(DBConnect.conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaChucVu", maChucVu);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        tenLoai = result.ToString();
                    }
                }
            }
            return tenLoai;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                DataGridViewRow selectedRow = dgvNhanVien.Rows[selectedRowIndex];

                txtMaNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();

                string maChucVu = selectedRow.Cells["MaChucVu"].Value.ToString();
                string tenChucVu = GetTenChucVu(maChucVu);

                cboChucVu.Text = tenChucVu;

                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "True")
                {
                    rdoNam.Checked = true;
                }
                else
                    rdoNu.Checked = true;

                dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                dtpNgayVaoLam.Text = selectedRow.Cells["NgayVaoLam"].Value.ToString();
                pnNghiLam.Visible = true;
                if (selectedRow.Cells["NgayNghi"].Value != DBNull.Value)
                {
                    cbNghiLam.Checked = true;
                    pnNghiLam.Visible = true;
                    dtpNgayNghiLam.Value = Convert.ToDateTime(selectedRow.Cells["NgayNghi"].Value);
                }
                else
                {
                    cbNghiLam.Checked = false;
                    pnNghiLam.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dữ liệu cần sửa!", "Error!");
            }
        }

        private void cbNghiLam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNghiLam.Checked == true)
            {
                pnNghiLam.Visible = true;
            }
            else
                pnNghiLam.Visible = false;
        }
    }
}
