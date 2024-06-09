using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class ChiTietCaLamDAO
    {

        public static DataTable layDSCTCL(string maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT MaCaLam, NgayLam FROM ChiTietCaLam WHERE MaNhanVien = '" + maNV + "'";
            return db.getTable(sql);
        }

        public static void luuCTCL(string maCaLam, string maNhanVien, DateTime ngayLam)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.conStr))
            {
                string query = "INSERT INTO ChiTietCaLam (MaCaLam, MaNhanVien, NgayLam) VALUES (@MaCaLam, @MaNhanVien, @NgayLam)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaCaLam", maCaLam);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmd.Parameters.AddWithValue("@NgayLam", ngayLam);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
