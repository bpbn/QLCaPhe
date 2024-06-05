using QL_CaPhe.POJO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    public class NhaCungCapDAO
    {
        
        public static DataTable layDSNhaCungCap()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM NhaCungCap";
            return db.getTable(sql);
        }
    }
}
