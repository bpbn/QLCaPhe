using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class ChiTietHoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public string GhiChu { get; set; }

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, int thanhTien, string ghiChu)
        {
            this.MaHoaDon = maHoaDon;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
        }

        public static string LayMaHoaDonMoiNhat()
        {
            return ChiTietDonHangDAO.layMaDonHangMoiNhat().ToString();
        }

        public static bool LuuChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong)
        {
            return ChiTietDonHangDAO.luuChiTietDonHang(maHoaDon, maSanPham, soLuong) > 0;
        }

    }

}
