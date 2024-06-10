using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class NhanVienDAO
    {
        public static DataTable layDSNhanVien()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NhanVien";
            return db.getTable(sql);
        }

        public static String layTenNhanVien(String maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT TenNhanVien FROM NhanVien WHERE MaNhanVien = '" + maNV + "'";
            return db.execScalar<string>(sql);
        }

        public static String layChucVu(String maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT TenChucVu FROM ChucVu CV, NhanVien NV WHERE CV.MaChucVu = NV.MaChucVu AND NV.MaNhanVien = '" + maNV + "'";
            return db.execScalar<string>(sql);
        }

        public static DataTable layDSNhanVienBH()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NhanVien WHERE MaChucVu = 'BH'";
            return db.getTable(sql);
        }

        public static DataTable layDSNhanVienKho()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NhanVien WHERE MaChucVu = 'K'";
            return db.getTable(sql);
        }
    }
}
