using BazaPristup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    // Iva rezo
    public class RepozitorijNovosti
    {
        static public List<Novost> ListaNovosti = new List<Novost>();

        static public List<Novost> DohvatiNovosti()
        {
            ListaNovosti.Clear();
            string upit = "SELECT * from novosti;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_novost"].ToString());
                string naslov = reader["naslov"].ToString();
                string kategorija = reader["kategorija"].ToString();
                string sadrzaj = reader["sadrzaj"].ToString();
                DateTime datum_objave = DateTime.Parse(reader["datum_objave"].ToString());
                Novost korisnikZaDodat = new Novost(naslov, datum_objave, kategorija, sadrzaj)
                {
                    IdNovosti = id
                };
                ListaNovosti.Add(korisnikZaDodat);
            }
            reader.Close();
            return ListaNovosti;
        }

        static public void DodajNovost(Novost novost, Korisnik korisnik)
        {
            string datum = novost.Datum.ToString("MM/dd/yyyy");
            string upit = String.Format("INSERT INTO novosti values ({0},'{1}','{2}','{3}','{4}');", korisnik.IdKorisnika, novost.Naslov, datum, novost.Kategorija, novost.Sadrzaj);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }
    }
}
