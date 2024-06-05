using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.POJO
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private int giaBan;
        private string trangThai;
        private string maLoai;

        public SanPham()
        {
        }

        public SanPham(string maSP, string tenSP, int giaBan, string trangThai, string maLoai)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.GiaBan = giaBan;
            this.TrangThai = trangThai;
            this.MaLoai = maLoai;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
    }
}
