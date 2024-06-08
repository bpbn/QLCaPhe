using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public static object layMaPhieuNhapMoiNhat()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT TOP 1 MaPhieuNhap FROM PhieuNhap ORDER BY MaPhieuNhap DESC";
            return db.getScalar(sql);
        }

        public static int luuChiTietPhieuNhap(string maPN, string maNL, int soLuong, int donGia)
        {
            DBConnect db = new DBConnect();
            string sql = "INSERT INTO ChiTietPhieuNhap(MaPhieuNhap, MaNguyenLieu, SoLuong, DonGia) VALUES ('" + maPN + "',N'" + maNL + "', '" + soLuong + "', '" + donGia + "')";
            return db.execNonQuery(sql);
        }
    }
}
