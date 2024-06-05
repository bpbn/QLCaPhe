using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class SanPhamDAO
    {
        public static DataTable layDSSanPham()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT MaSanPham, TenSanPham, GiaBan FROM SanPham";
            return db.getTable(sql);
        }
    }
}
