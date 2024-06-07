using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class PhieuNhapDAO
    {
        public static int luuPhieuNhap(string maNCC, string maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "INSERT INTO PhieuNhap(NgayNhap, MaNhaCungCap, MaNhanVien) VALUES ('" + String.Format("{0:MM-dd-yyyy}", DateTime.Now.ToString("MM-dd-yyyy")) + "','" + maNCC + "','" + maNV + "')";
            return db.execNonQuery(sql);
        }
    }
}
