using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
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
            this.MaNhaCungCap = maNCC;
            this.TenNhaCungCap = tenNCC;
            this.SoDienThoai = sdt;
            this.Email = email;
            this.DiaChi = diaChi;
        }

        public string MaNhaCungCap { get => maNCC; set => maNCC = value; }
        public string TenNhaCungCap { get => tenNCC; set => tenNCC = value; }
        public string SoDienThoai { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public static List<NhaCungCap> LayDSNhaCungCap()
        {
            List<NhaCungCap> dsNhaCungCap = new List<NhaCungCap>();
            DataTable dt = NhaCungCapDAO.layDSNhaCungCap();

            foreach (DataRow row in dt.Rows)
            {
                NhaCungCap ncc = new NhaCungCap
                (
                    row["MaNhaCungCap"].ToString(),
                    row["TenNhaCungCap"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SoDienThoai"].ToString(),
                    row["Email"].ToString()
                );
                dsNhaCungCap.Add(ncc);
            }
            return dsNhaCungCap;
        }

    }
}
