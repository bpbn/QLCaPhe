using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.BLL
{
    public class BangLuong
    {
        public string MaBangLuong { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime ThoiGianTraLuong { get; set; }
        public int PhuCap { get; set; }
        public int Luong { get; set; }

        public BangLuong() { }

        public BangLuong(string maBangLuong, string maNhanVien, DateTime thoiGianTraLuong, int phuCap, int luong)
        {
            this.MaBangLuong = maBangLuong;
            this.MaNhanVien = maNhanVien;
            this.ThoiGianTraLuong = thoiGianTraLuong;
            this.PhuCap = phuCap;
            this.Luong = luong;
        }
    }
}
