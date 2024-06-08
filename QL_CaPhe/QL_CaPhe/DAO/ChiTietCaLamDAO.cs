using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class ChiTietCaLamDAO
    {
        public static DataTable layDSCTCL(string maNV)
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT MaCaLam, NgayLam FROM ChiTietCaLam WHERE MaNhanVien = '" + maNV + "'";
            return db.getTable(sql);
        }
    }
}
