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
    static public class RepozitorijRecenzija
    {
        static public List<Recenzija> ListaRecenzija = new List<Recenzija>();

        static public List<Recenzija> DohvatiRecenzije(int IdArtiklRecenzija)
        {
            ListaRecenzija.Clear();
            string upit = String.Format("SELECT * from recenzija where id_artikl = {0};", IdArtiklRecenzija);
            return DohvacanjePodatakaRecenzija(upit);
        }

        static public List<Recenzija> DohvatiSveRecenzije()
        {
            ListaRecenzija.Clear();
            string upit = "SELECT * from recenzija";
            ListaRecenzija = DohvacanjePodatakaRecenzija(upit);
            var sortirana = ListaRecenzija.OrderBy(x => x.Datum).ToList();
            return sortirana;
        }

        static public List<Recenzija> DohvacanjePodatakaRecenzija(string query)
        {
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(query);
            while (reader.Read())
            {
                int idKorisnik1 = int.Parse(reader["id_korisnik"].ToString());
                int idArtikl1 = int.Parse(reader["id_artikl"].ToString());
                int ocjena = int.Parse(reader["ocjena"].ToString());
                string tekst = reader["tekst"].ToString();
                DateTime datum = DateTime.Parse(reader["datum"].ToString());
                Recenzija recenzija = new Recenzija(ocjena, tekst, datum)
                {
                    IdKorisnik = idKorisnik1,
                    IdArtikl = idArtikl1
                };
                ListaRecenzija.Add(recenzija);
            }
            reader.Close();
            return ListaRecenzija;
        }
        static public void DodajRecenziju(Korisnik korisnik, Artikl artikl, Recenzija recenzija)
        {
            string datum = recenzija.Datum.ToString("MM/dd/yyyy");
            string upit = String.Format("INSERT INTO recenzija values ('{0}','{1}','{2}','{3}', '{4}');", korisnik.IdKorisnika, artikl.IdArtikl, recenzija.Ocjena, recenzija.Tekst, datum);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        static public float ProsjecnaOcjena(Artikl artikl)
        {
            float prosjecnaOcjena = 0;
            int brojac = 0;
            string upit = String.Format("SELECT ocjena FROM recenzija WHERE id_artikl = {0};", artikl.IdArtikl);
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                float ocjena = float.Parse(reader["ocjena"].ToString());
                prosjecnaOcjena = prosjecnaOcjena + ocjena;
                brojac++;
            }
            reader.Close();

            if(brojac != 0)
            {
                return prosjecnaOcjena / brojac;
            }
            else
            {
                return 0;
            }
        }
    }
}
