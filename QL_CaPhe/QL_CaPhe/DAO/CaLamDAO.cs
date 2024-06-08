using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class CaLamDAO
    {
        public static DataTable layDSCaLam()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM CaLam";
            return db.getTable(sql);
        }
    }
}
