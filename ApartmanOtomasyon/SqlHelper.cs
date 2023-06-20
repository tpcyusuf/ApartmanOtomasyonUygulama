using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyon
{
    class SqlHelper
    {
        private string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"Data Source =YTOPCU-ORTAK\SQLEXPRESS2019; initial catalog =UYGULAMA_TEST; user id =sa; password =Yt12345!";
            Connection = new SqlConnection(ConnectionString);            
        }

        public void ExecuteProcedure(string procName,params SqlParameter[] ps)  // Birden fazla Sql Parametresi oldugu icin bunu params da dizi olarak tutup adina "ps" diyoruz.
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.AddRange(ps);
            cmd.Connection = Connection;  // = Connection =>>  public SqlConnection Connection buradan geliyor ve bunun ConnectionString de yukarida
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)   // Sql den Data Cekme Metotu
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query,ConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
