using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class BangLuongDAO
    {
        public static DataTable layDSBangLuong()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM BangLuong";
            return db.getTable(sql);
        }

        public static DateTime layNgayTraLuongGanNhat(String maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT MAX(THOIGIANTRALUONG) FROM BANGLUONG WHERE MaNhanVien = '" + maNV + "'";
            return db.execScalar<DateTime>(sql);
        }

        public static string layTongGioLam(string maNhanVien)
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "PROC_TINHTONGSOGIOLAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANHANVIEN", SqlDbType.VarChar).Value = maNhanVien;
            cmd.Parameters.Add("@TongGioLam", SqlDbType.Int);
            cmd.Parameters["@TongGioLam"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string tongGioLam = cmd.Parameters["@TongGioLam"].Value.ToString();
            con.Close();

            return tongGioLam;
        }

        public static string layTongPhuCap(string maNhanVien)
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "PROC_TINHPHUCAP_THEOGIOLAM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MANHANVIEN", SqlDbType.VarChar).Value = maNhanVien;
            cmd.Parameters.Add("@Phucap", SqlDbType.Int);
            cmd.Parameters["@Phucap"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string phuCap = cmd.Parameters["@Phucap"].Value.ToString();
            con.Close();

            return phuCap;
        }

        public static string layTongLuong(string maNhanVien)
        {
            SqlConnection con = new SqlConnection(DBConnect.conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "PROC_TinhTongLuongNhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            cmd.Parameters.Add("@Luong", SqlDbType.Int).Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();

            string TongLuong = cmd.Parameters["@Luong"].Value.ToString();
            con.Close();

            return TongLuong;
        }

        public static void luuBangLuong(string maNhanVien, int luong, int phuCap, DateTime ngayTraLuong)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.conStr))
            {
                string query = "INSERT INTO BangLuong (MaNhanVien, ThoiGianTraLuong, PhuCap, Luong) VALUES (@MaNhanVien, @NgayTraLuong, @PhuCap, @Luong)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@Luong", luong);
                cmd.Parameters.AddWithValue("@PhuCap", phuCap);
                cmd.Parameters.AddWithValue("@NgayTraLuong", ngayTraLuong);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}

