using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaChucVu { get; set; }

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenDangNhap, string matKhau, string maChucVu)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaChucVu = maChucVu;
        }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO(); 
            return taiKhoanDAO.checkDangNhapHople(tenDangNhap, matKhau);
        }

        public bool KiemTraTaiKhoanTonTai(string tenDangNhap)
        {
            TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
            return taiKhoanDAO.CheckPrimaryKey(tenDangNhap);
        }
    }

}
