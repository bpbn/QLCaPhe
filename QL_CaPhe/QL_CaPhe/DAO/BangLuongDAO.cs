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

    }
}

