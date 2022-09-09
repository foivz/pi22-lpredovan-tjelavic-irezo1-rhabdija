using BazaPristup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundIT.Models
{
    static public class RepozitorijArtikala
    {
        static public List<Artikl> ListaArtikala = new List<Artikl>();
        static public List<Artikl> DohvatiArtikle()
        {
            ListaArtikala.Clear();
            string upit = "select id_artikl, zr.naziv as zanr, CONCAT(at.ime, ' ', at.prezime) as autor, naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, broj_stranica, ISBN from artikl ar join zanr zr on zr.id_zanr = ar.id_zanr join autor at on at.id_autor = ar.id_autor;";
            ListaArtikala = DohvacanjePodatakaOArtiklima(upit);
            return ListaArtikala;
        }
        static public List<Artikl> DohvatiNedostupneArtikle()
        {
            ListaArtikala.Clear();
            string upit = string.Format("select id_artikl, zr.naziv as zanr, CONCAT(at.ime, ' ', at.prezime) as autor, naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, broj_stranica, ISBN from artikl ar join zanr zr on zr.id_zanr = ar.id_zanr join autor at on at.id_autor = ar.id_autor WHERE dostupnost = {0};", 0);
            ListaArtikala = DohvacanjePodatakaOArtiklima(upit);
            return ListaArtikala;
        }

        static public List<int> DohvatiMojeArtikle(int idK)
        {
            List<int> mojiArtikli = new List<int>();
            List<int> mojiRacuni = new List<int>();
            string upit = String.Format("select id_racun from racun where id_korisnik={0};", idK);
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_racun"].ToString());
                mojiRacuni.Add(id);
            }
            reader.Close();
            foreach (int x in mojiRacuni)
            {
                upit = String.Format("select id_artikl from artikl_racun where id_racun={0};", x);
                reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_artikl"].ToString());
                    mojiArtikli.Add(id);
                }
                reader.Close();
            }
            return mojiArtikli;
        }


        static public List<Artikl> DohvacanjePodatakaOArtiklima(string query)
        {
            List<Artikl> lista = new List<Artikl>();
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(query);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_artikl"].ToString());
                string zanr = reader["zanr"].ToString();
                string autor = reader["autor"].ToString();
                string naslov = reader["naslov"].ToString();
                bool dostupnost = bool.Parse(reader["dostupnost"].ToString());
                float cijena = float.Parse(reader["cijena"].ToString());
                string opis = reader["opis"].ToString();
                string naklada = reader["naklada"].ToString();
                string vrsta_uveza = reader["vrsta_uveza"].ToString();
                string jezik = reader["jezik"].ToString();
                string izdanje = reader["izdanje"].ToString();
                int brojStranica = int.Parse(reader["broj_stranica"].ToString());
                string ISBN = reader["ISBN"].ToString();
                Artikl artiklZaDodat = new Artikl(naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, brojStranica, ISBN, zanr, autor)
                {
                    IdArtikl = id
                };
                lista.Add(artiklZaDodat);
            }
            reader.Close();
            return lista;
        }
    }

}