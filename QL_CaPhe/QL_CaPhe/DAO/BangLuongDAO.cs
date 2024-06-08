using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.DAO
{
    class BangLuongDAO
    {
        public static DataTable layDSBangLuong()
        {
            DBConnect db = new DBConnect();
            string sql = "SELECT * FROM BangLuong";
            return db.getTable(sql);
        }
    }
}

