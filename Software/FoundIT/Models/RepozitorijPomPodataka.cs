using BazaPristup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    static public class RepozitorijPomPodataka
    {
        static public Dictionary<int, string> Uloga { get; set; }

        static RepozitorijPomPodataka()
        {
            Uloga = new Dictionary<int, string>();
        }
        static public void PopuniOpcije()
        {
            PopuniUloge();
        }
        static private void PopuniUloge()
        {
            Uloga.Clear();
            string upit = "SELECT * from uloga;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_uloga"].ToString());
                string naziv = reader["naziv"].ToString();

                Uloga.Add(id, naziv);
            }
            reader.Close();
        }
    }
}
