using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class DonHangDAO
    {
        public static int luuDonHang(string maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "INSERT INTO HoaDon(ThoiGianLap, MaNhanVien) VALUES  ('" + String.Format("{0:MM-dd-yyyy HH:mm:ss}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss.fff")) + "','" + maNV + "')";
            return db.execNonQuery(sql);
        }
    }
}
