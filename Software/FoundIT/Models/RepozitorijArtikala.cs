using BazaPristup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    static public class RepozitorijArtikala
    {
        static public List<Artikl> ListaArtikala = new List<Artikl>();

        static public List<Artikl> DohvatiArtikle()
        {
            ListaArtikala.Clear();
            string upit = "select id_artikl, zr.naziv as zanr, CONCAT(at.ime, ' ', at.prezime) as autor, naslov, dostupnost, cijena, opis, naklada, vrsta_uveza, jezik, izdanje, broj_stranica, ISBN from artikl ar join zanr zr on zr.id_zanr = ar.id_zanr join autor at on at.id_autor = ar.id_autor;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
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
                ListaArtikala.Add(artiklZaDodat);
            }
            reader.Close();
            return ListaArtikala;
        }

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
            var artikliSortirani = dictFavorita.OrderByDescending(x => x.Value).Select(y=>y.Key);
            return artikliSortirani.ToList();
        }
    }
}
