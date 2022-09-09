using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazaPristup;

namespace FoundIT.Models
{
    // Iva Rezo i Tea Jelavić
    class RepozitorijFavorita
    {
        static public List<int> DohvatiFavorite()
        {
            Dictionary<int, int> dictFavorita = new Dictionary<int, int>();
            string upit = "select id_artikl from favorit;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_artikl"].ToString());
                if (dictFavorita.ContainsKey(id))
                {
                    dictFavorita[id] = dictFavorita[id] + 1;
                }
                else
                {
                    dictFavorita.Add(id, 0);
                }
            }
            reader.Close();
            var artikliSortirani = dictFavorita.OrderByDescending(x => x.Value).Select(y => y.Key);
            return artikliSortirani.ToList();
        }
        static public List<Artikl> DohvatiMojeFavorite(int idTKorisnik)
        {
            List<Artikl> ListaMojihFavorita = new List<Artikl>();
            List<int> ListaIdFavorita = new List<int>();
            string upit1 = String.Format("SELECT id_artikl FROM favorit WHERE id_korisnik = {0};", idTKorisnik);
            SqlDataReader reader1 = BazaPodataka.Instanca.DohvatiDataReader(upit1);
            while (reader1.Read())
            {
                int idFavoritaArtikla = int.Parse(reader1["id_artikl"].ToString());
                ListaIdFavorita.Add(idFavoritaArtikla);
            }
            reader1.Close();

            ListaMojihFavorita.Clear();
            foreach (int idFavoritaArtikla in ListaIdFavorita)
            {
                string upit2 = String.Format("SELECT zr.naziv as zanr, CONCAT(at.ime, ' ', at.prezime) as autor, naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, broj_stranica, ISBN FROM artikl ar join zanr zr on zr.id_zanr = ar.id_zanr join autor at on at.id_autor = ar.id_autor WHERE id_artikl = {0};", idFavoritaArtikla);
                SqlDataReader reader2 = BazaPodataka.Instanca.DohvatiDataReader(upit2);
                while (reader2.Read())
                {
                    int id = idFavoritaArtikla;
                    string zanr = reader2["zanr"].ToString();
                    string autor = reader2["autor"].ToString();
                    string naslov = reader2["naslov"].ToString();
                    bool dostupnost = bool.Parse(reader2["dostupnost"].ToString());
                    float cijena = float.Parse(reader2["cijena"].ToString());
                    string opis = reader2["opis"].ToString();
                    string naklada = reader2["naklada"].ToString();
                    string vrsta_uveza = reader2["vrsta_uveza"].ToString();
                    string jezik = reader2["jezik"].ToString();
                    string izdanje = reader2["izdanje"].ToString();
                    int brojStranica = int.Parse(reader2["broj_stranica"].ToString());
                    string ISBN = reader2["ISBN"].ToString();
                    Artikl noviFavorit = new Artikl(naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, brojStranica, ISBN, zanr, autor)
                    {
                        IdArtikl = id
                    };
                    ListaMojihFavorita.Add(noviFavorit);
                }
                reader2.Close();
            }
            return ListaMojihFavorita;
        }

        static public void DodajFavorit(Korisnik korisnik, Artikl artikl)
        {
            string upit = String.Format("INSERT INTO favorit values ({0},'{1}');", korisnik.IdKorisnika, artikl.IdArtikl);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        static public void UkloniFavorit(Korisnik korisnik, Artikl artikl)
        {
            string upit = String.Format("DELETE FROM favorit WHERE id_korisnik = {0} AND id_artikl = {1};", korisnik.IdKorisnika, artikl.IdArtikl);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        static public int BrojacFavorita(int artikl_id)
        {
            int brojFavorita = 0;
            string upit = String.Format("SELECT * FROM favorit WHERE id_artikl = {0};", artikl_id);
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                brojFavorita++;
            }
            reader.Close();

            return brojFavorita;
        }
    }
}
