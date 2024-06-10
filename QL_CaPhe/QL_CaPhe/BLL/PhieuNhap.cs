using System;
using QL_CaPhe.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class PhieuNhap
    {
        public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TongTien { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaNhanVien { get; set; }

        public PhieuNhap() { }

        public PhieuNhap(string maPhieuNhap, DateTime ngayNhap, int tongTien, string maNhaCungCap, string maNhanVien)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
            this.MaNhaCungCap = maNhaCungCap;
            this.MaNhanVien = maNhanVien;
        }

        public static bool LuuPhieuNhap(string maNCC, string maNV)
        {
            return PhieuNhapDAO.luuPhieuNhap(maNCC, maNV) > 0;
        }

    }
}
