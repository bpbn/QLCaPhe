using System;
using System.Collections.Generic;
using System.Data;
using QL_CaPhe.DAO;

namespace QL_CaPhe
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public DateTime? NgayNghi { get; set; }
        public string MaChucVu { get; set; }

        public NhanVien(string maNhanVien, string tenNhanVien, string maChucVu)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            MaChucVu = maChucVu;
        }

        public NhanVien(string maNhanVien, string tenNhanVien, DateTime ngaySinh, bool gioiTinh, string diaChi, DateTime ngayVaoLam, DateTime? ngayNghi, string maChucVu)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            NgayVaoLam = ngayVaoLam;
            NgayNghi = ngayNghi;
            MaChucVu = maChucVu;
        }

        public static List<NhanVien> LayDanhSachNhanVien()
        {
            DataTable dt = NhanVienDAO.layDSNhanVien();
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                string maNhanVien = row["MaNhanVien"].ToString();
                string tenNhanVien = row["TenNhanVien"].ToString();
                string maChucVu = row["MaChucVu"].ToString();

                NhanVien nhanVien = new NhanVien(maNhanVien, tenNhanVien, maChucVu);
                danhSachNhanVien.Add(nhanVien);
            }

            return danhSachNhanVien;
        }

        public static string LayTenNhanVien(string maNV)
        {
            return NhanVienDAO.layTenNhanVien(maNV);
        }

        public static string LayChucVu(string maNV)
        {
            return NhanVienDAO.layChucVu(maNV);
        }

        public static List<NhanVien> LayDanhSachNhanVienBanHang()
        {
            DataTable dt = NhanVienDAO.layDSNhanVienBH();
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                string maNhanVien = row["MaNhanVien"].ToString();
                string tenNhanVien = row["TenNhanVien"].ToString();
                string maChucVu = row["MaChucVu"].ToString();

                NhanVien nhanVien = new NhanVien(maNhanVien, tenNhanVien, maChucVu);
                danhSachNhanVien.Add(nhanVien);
            }

            return danhSachNhanVien;
        }

        public static List<NhanVien> LayDanhSachNhanVienKho()
        {
            DataTable dt = NhanVienDAO.layDSNhanVienKho();
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            foreach (DataRow row in dt.Rows)
            {
                string maNhanVien = row["MaNhanVien"].ToString();
                string tenNhanVien = row["TenNhanVien"].ToString();
                string maChucVu = row["MaChucVu"].ToString();

                NhanVien nhanVien = new NhanVien(maNhanVien, tenNhanVien, maChucVu);
                danhSachNhanVien.Add(nhanVien);
            }

            return danhSachNhanVien;
        }
    }
}
