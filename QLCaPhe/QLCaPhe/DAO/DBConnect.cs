using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCaPhe.DAO
{
    public class DBConnect
    {
        private readonly string connectionString;
        //public static string conStr = "Data Source=DESKTOP-QVIL76U\\SQLEXPRESS;Initial Catalog=QL_NHATHUOC;Integrated Security=True";
        //public static string conStr = @"Data Source=bpbn\sqlexpress;Initial Catalog=QL_NHATHUOC;Integrated Security=True";
        //public static string conStr = "Data Source=DESKTOP-QKV3AJV;Initial Catalog=QL_NHATHUOC;Integrated Security=True";
        public static string conStr = "Data Source=DESKTOP-8U4DADL;Initial Catalog=QL_NHATHUOC;Integrated Security=True";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private SqlConnection con;
        public DBConnect()
        {
            con = new SqlConnection(conStr);
            connectionString = conStr;
        }
        public DBConnect(string conStr)
        {
            con = new SqlConnection(conStr);
        }
        private void Open()
        {
            if (con.State == ConnectionState.Closed) con.Open();
        }
        private void Close()
        {
            if (con.State == ConnectionState.Open) con.Close();
        }
        public int execNonQuery(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            return cmd.ExecuteNonQuery();
        }
        public T execScalar<T>(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            return (T)cmd.ExecuteScalar();
        }
        public DataTable getTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public object getScalar(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            //int kt = (int)cmd.ExecuteScalar();
            return cmd.ExecuteScalar(); ;
        }

        public int updateDataTable(DataTable dt, string selectString)
        {
            SqlDataAdapter da = new SqlDataAdapter(selectString, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
    }
}
