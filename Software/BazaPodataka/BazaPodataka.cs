using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaPodatakaPristup
{
    public class BazaPodataka
    {
        private static global::BazaPodataka instanca;
        public static global::BazaPodataka Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new BazaPodataka();
                }
                return instanca;
            }
        }
        private string connectionString { get; set; }
        private SqlConnection connection { get; set; }

        private BazaPodataka()
        {
            connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI21-20_DB; User=PI21-20_User; Password=S^qw.O(B";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void ZatvoriKonekciju()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, connection);
            return command.ExecuteNonQuery();
        }
    }
}
