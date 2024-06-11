using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public int TongTien { get; set; }
        public DateTime ThoiGianLap { get; set; }
        public string MaNhanVien { get; set; }
        public string GhiChu { get; set; }

        public HoaDon() { }

        public HoaDon(string maHoaDon, int tongTien, DateTime thoiGianLap, string maNhanVien, string ghiChu)
        {
            this.MaHoaDon = maHoaDon;
            this.TongTien = tongTien;
            this.ThoiGianLap = thoiGianLap;
            this.MaNhanVien = maNhanVien;
            this.GhiChu = ghiChu;
        }

        public static bool LuuHoaDon(string maNV)
        {
            return DonHangDAO.luuDonHang(maNV) > 0;
        }

    }

}
