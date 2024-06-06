using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe.POJO
{
    public class Dashboard
    {
        public struct DoanhThuTheoNgay
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public struct ChiTieuTheoNgay
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public Dashboard() { }
        
    }
}
