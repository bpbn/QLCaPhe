using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class ChiTietDonHangDAO
    {
        public static object layMaDonHangMoiNhat()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
            return db.getScalar(sql);
        }

        public static int luuChiTietDonHang(string maDonHang, string maSP, int soLuong)
        {
            DBConnect db = new DBConnect();
            string sql = "INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong) VALUES ('" + maDonHang + "',N'" + maSP + "', '" + soLuong + "')";
            return db.execNonQuery(sql);
        }
    }
}
