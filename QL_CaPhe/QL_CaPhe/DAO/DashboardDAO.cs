using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CaPhe.POJO;
using static QL_CaPhe.POJO.Dashboard;


namespace QL_CaPhe.DAO
{
    public class DashboardDAO : DBConnect
    {
        private DateTime NgayBD;
        private DateTime NgayKT;
        private int SoNgay;

        public int SoNCC { get; private set; }
        public int SoSanPham { get; private set; }
        public List<KeyValuePair<String, int>> ListTopSP { get; private set; }
        public List<KeyValuePair<String, int>> ListSPSapHetHang { get; private set; }
        public List<DoanhThuTheoNgay> ListDoanhThu { get; private set; }
        public List<ChiTieuTheoNgay> ListChiTien { get; private set; }
        public int SoDH { get; private set; }
        public int SoPN { get; private set; }
        public decimal TongDoanhThu { get; set; }
        public decimal TongChiTien { get; set; }

        public DashboardDAO()
        {

        }

        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;

                    //Lấy tổng số nhà cung cấp
                    command.CommandText = "Select count(*) from NhaCungCap";
                    SoNCC = (int)command.ExecuteScalar();

                    //Lấy tổng số sản phẩm
                    command.CommandText = "Select count(*) from SanPham";
                    SoSanPham = (int)command.ExecuteScalar();

                    //Lấy tổng số đơn hàng
                    command.CommandText = @"SELECT Count(*) FROM HoaDon WHERE ThoiGianLap BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    SoDH = (int)command.ExecuteScalar();

                    //Lấy tổng số đơn xuất
                    command.CommandText = @"SELECT Count(*) FROM PhieuNhap WHERE ThoiGianLap BETWEEN @fromDate AND @toDate";
                    SoPN = (int)command.ExecuteScalar();

                }
            }
        }

        private void GetOrderAnalisys()
        {
            ListDoanhThu = new List<DoanhThuTheoNgay>();
            TongDoanhThu = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT ThoiGianLap, SUM(TongTien) from HoaDon WHERE ThoiGianLap BETWEEN @fromDate AND @toDate GROUP BY ThoiGianLap";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read()) 
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TongDoanhThu += decimal.Parse(b);
                    }
                    reader.Close();

                    //Gộp ngày
                    if (SoNgay <= 30)
                    {
                        foreach(var item in resultTable)
                        {
                            ListDoanhThu.Add(new DoanhThuTheoNgay()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    else if(SoNgay <= 92)
                    {
                        ListDoanhThu = (from orderList in resultTable
                                        group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                                into order
                                        select new DoanhThuTheoNgay
                                        {
                                            Date = "Week " + order.Key.ToString(),
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    else if(SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        ListDoanhThu = (from orderList in resultTable
                                        group orderList by orderList.Key.ToString("MMM yyyy")
                                        into order
                                        select new DoanhThuTheoNgay
                                        {
                                            Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    else
                    {
                        ListDoanhThu = (from orderList in resultTable
                                        group orderList by orderList.Key.ToString("yyyy")
                                        into order
                                        select new DoanhThuTheoNgay
                                        {
                                            Date = order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                }
            }
        }

        private void GetGoodsImportAnalisys()
        {
            ListChiTien = new List<ChiTieuTheoNgay>();
            TongChiTien = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT ThoiGianLap, SUM(TongTien) from PhieuNhap WHERE ThoiGianLap BETWEEN @fromDate AND @toDate GROUP BY ThoiGianLap";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = NgayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = NgayKT;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        string b = reader[1].ToString();
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], decimal.Parse(b)));
                        TongChiTien += decimal.Parse(b);
                    }
                    reader.Close();

                    //Gộp ngày
                    if (SoNgay <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            ListChiTien.Add(new ChiTieuTheoNgay()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    else if (SoNgay <= 92)
                    {
                        ListChiTien = (from orderList in resultTable
                                       group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                           orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                       into order
                                       select new ChiTieuTheoNgay
                                       {
                                           Date = "Week " + order.Key.ToString(),
                                           TotalAmount = order.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                    else if(SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        ListChiTien = (from orderList in resultTable
                                       group orderList by orderList.Key.ToString("MMM yyyy")
                                       into order
                                       select new ChiTieuTheoNgay
                                       {
                                           Date = order.Key,
                                           TotalAmount = order.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                    else
                    {
                        ListChiTien = (from orderList in resultTable
                                       group orderList by orderList.Key.ToString("yyyy")
                                        into order
                                       select new ChiTieuTheoNgay
                                       {
                                           Date = order.Key,
                                           TotalAmount = order.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                }
            }
        }

        private void GetGoodsAnalisys()
        {
            ListTopSP = new List<KeyValuePair<string, int>>();
            ListSPSapHetHang = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select TOP 5 "
                }
            }
        }
    } 
}
