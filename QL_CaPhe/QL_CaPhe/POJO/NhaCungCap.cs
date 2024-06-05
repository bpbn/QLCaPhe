using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.POJO
{
    public class NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string sdt;
        private string email;
        private string diaChi;

        public NhaCungCap()
        {
        }

        public NhaCungCap(string maNCC, string tenNCC, string sdt, string email, string diaChi)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.Sdt = sdt;
            this.Email = email;
            this.DiaChi = diaChi;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
