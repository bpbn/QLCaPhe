using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class ChiTietPhieuNhap
    {
        public string MaPhieuNhap { get; set; }
        public string MaNguyenLieu { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
        public string GhiChu { get; set; }

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPhieuNhap, string maNguyenLieu, int soLuong, int donGia, int thanhTien, string ghiChu)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.MaNguyenLieu = maNguyenLieu;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
        }

        public static string LayMaPhieuNhapMoiNhat()
        {
            return ChiTietPhieuNhapDAO.layMaPhieuNhapMoiNhat().ToString();
        }

        public static bool LuuChiTietPhieuNhap(string maPN, string maNL, int soLuong, int donGia)
        {
            return ChiTietPhieuNhapDAO.luuChiTietPhieuNhap(maPN, maNL, soLuong, donGia) > 0;
        }

    }
}
