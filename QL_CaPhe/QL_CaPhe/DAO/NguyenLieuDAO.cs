using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class NguyenLieuDAO
    {
        public static DataTable layDSNguyenLieu()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NguyenLieu";
            return db.getTable(sql);
        }

        public static DataTable timNguyenLieu(string tenNL)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NguyenLieu where TenNguyenLieu like N'%" + tenNL + "%'";
            return db.getTable(sql);
        }

        public static int capNhatSoLuongNguyenLieu(string maNL, int soLuong)
        {
            DBConnect db = new DBConnect();
            string sql = "UPDATE NguyenLieu SET SoLuongTon = " + soLuong + " WHERE MaNguyenLieu = '" + maNL + "'";
            return db.execNonQuery(sql);
        }
    }
}
