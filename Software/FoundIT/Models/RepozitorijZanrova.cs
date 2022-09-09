using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazaPristup;

namespace FoundIT.Models
{
    // Tea Jelavić
    class RepozitorijZanrova
    {
        public static string DohvatiNazivZanra(int id)
        {
            string nazivZ = "";
            string upit = String.Format("SELECT naziv from zanr where id_zanr = {0};", id);
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                nazivZ = reader["naziv"].ToString();
            }
            reader.Close();
            return nazivZ;
        }
    }
}
