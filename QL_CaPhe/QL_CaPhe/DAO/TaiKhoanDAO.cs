using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class TaiKhoanDAO
    {
        DBConnect db = new DBConnect();

        public bool CheckPrimaryKey(string primaryKey)
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


        public bool checkDangNhapHople(string tenTK, string Password)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    using (SqlConnection con = new SqlConnection(DBConnect.conStr))
                    {
                        con.Open();
                        string sql = "SELECT MATKHAU, MaChucVu FROM TAIKHOAN WHERE TenDangNhap = @username AND MATKHAU = @password";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Add(new SqlParameter("@username", tenTK));
                        cmd.Parameters.Add(new SqlParameter("@password", Password));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string password = reader.GetString(0);
                                string MaChucVu = reader.GetString(1);

                                if (password == Password)
                                {
                                    Properties.Settings.Default.LoaiTK = MaChucVu;
                                    Properties.Settings.Default.Save();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
