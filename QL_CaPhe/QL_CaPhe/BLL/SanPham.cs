using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.POJO
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int GiaBan { get; set; }
        public string MaLoai { get; set; }
        public string TrangThai { get; set; }

        public SanPham() { }

        public SanPham(string maSanPham, string tenSanPham, int giaBan, string maLoai, string trangThai)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.GiaBan = giaBan;
            this.MaLoai = maLoai;
            this.TrangThai = trangThai;
        }


        public static List<SanPham> LayDSSanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            DataTable dt = SanPhamDAO.layDSSanPham();

            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham
                (
                    row["MaSanPham"].ToString(),
                    row["TenSanPham"].ToString(),
                    Convert.ToInt32(row["GiaBan"]),
                    row["MaLoai"].ToString(),
                    row["TrangThai"].ToString()
                );
                dsSanPham.Add(sp);
            }
            return dsSanPham;
        }

        public static List<SanPham> TimSanPham(string tenSP)
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            DataTable dt = SanPhamDAO.timSanPham(tenSP);

            foreach (DataRow row in dt.Rows)
            {
                SanPham sp = new SanPham
                (
                    row["MaSanPham"].ToString(),
                    row["TenSanPham"].ToString(),
                    Convert.ToInt32(row["GiaBan"]),
                    row["MaLoai"].ToString(),
                    row["TrangThai"].ToString()
                );
                dsSanPham.Add(sp);
            }
            return dsSanPham;
        }
    }
}
