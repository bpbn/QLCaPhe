using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class ChiTietCaLam
    {
        public static DataTable layDSCTCL()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM ChiTietCaLam";
            return db.getTable(sql);
        }
    }
}
