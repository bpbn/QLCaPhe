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

