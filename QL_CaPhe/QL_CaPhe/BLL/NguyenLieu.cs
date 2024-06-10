using QL_CaPhe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CaPhe
{
    public class NguyenLieu
    {
        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string XuatXu { get; set; }
        public int SoLuongTon { get; set; }

        public NguyenLieu() { }

        public NguyenLieu(string maNguyenLieu, string tenNguyenLieu, string xuatXu, int soLuongTon)
        {
            this.MaNguyenLieu = maNguyenLieu;
            this.TenNguyenLieu = tenNguyenLieu;
            this.XuatXu = xuatXu;
            this.SoLuongTon = soLuongTon;
        }

        public static List<NguyenLieu> LayDSNguyenLieu()
        {
            List<NguyenLieu> dsNguyenLieu = new List<NguyenLieu>();
            DataTable dt = NguyenLieuDAO.layDSNguyenLieu();

            foreach (DataRow row in dt.Rows)
            {
                NguyenLieu nl = new NguyenLieu
                (
                    row["MaNguyenLieu"].ToString(),
                    row["TenNguyenLieu"].ToString(),
                    row["XuatXu"].ToString(),
                    int.Parse(row["SoLuongTon"].ToString())
                );
                dsNguyenLieu.Add(nl);
            }
            return dsNguyenLieu;
        }

        public static List<NguyenLieu> TimNguyenLieu(string tenNL)
        {
            List<NguyenLieu> dsNguyenLieu = new List<NguyenLieu>();
            DataTable dt = NguyenLieuDAO.timNguyenLieu(tenNL);

            foreach (DataRow row in dt.Rows)
            {
                NguyenLieu nl = new NguyenLieu
                (
                    row["MaNguyenLieu"].ToString(),
                    row["TenNguyenLieu"].ToString(),
                    row["XuatXu"].ToString(),
                    int.Parse(row["SoLuongTon"].ToString())
                );
                dsNguyenLieu.Add(nl);
            }
            return dsNguyenLieu;
        }

        public static bool CapNhatSoLuongNguyenLieu(string maNL, int soLuong)
        {
            return NguyenLieuDAO.capNhatSoLuongNguyenLieu(maNL, soLuong) > 0;
        }

    }
}

