using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
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

        public static List<BangLuong> LayDSBangLuong()
        {
            DataTable dt = BangLuongDAO.layDSBangLuong();
            List<BangLuong> bangLuongs = new List<BangLuong>();

            foreach (DataRow row in dt.Rows)
            {
                bangLuongs.Add(new BangLuong
                {
                    MaBangLuong = row["MaBangLuong"].ToString(),
                    MaNhanVien = row["MaNhanVien"].ToString(),
                    ThoiGianTraLuong = (DateTime)row["ThoiGianTraLuong"],
                    PhuCap = Convert.ToInt32(row["PhuCap"]),
                    Luong = Convert.ToInt32(row["Luong"])
                });
            }

            return bangLuongs;
        }

        // Method to get the latest payroll date for a specific employee
        public static DateTime LayNgayTraLuongGanNhat(string maNV)
        {
            return BangLuongDAO.layNgayTraLuongGanNhat(maNV);
        }

        // Method to save a salary record
        public void LuuBangLuong()
        {
            BangLuongDAO.luuBangLuong(MaNhanVien, Luong, PhuCap, ThoiGianTraLuong);
        }
    }
}
