using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaPristup
{
    public class BazaPodataka
    {
        private static BazaPodataka instanca;
        public static BazaPodataka Instanca
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
            connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI2252_DB; User=PI2252_User; Password=NEccx>CH";
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

        public int SlikuDodaj(byte[] slika, int id)
        {
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@image", slika);
            command.Parameters.AddWithValue("@id", id);
            command.CommandText = "UPDATE korisnik SET fotografija = @image where id_korisnik=@id";
            return command.ExecuteNonQuery();
        }
    }
}
