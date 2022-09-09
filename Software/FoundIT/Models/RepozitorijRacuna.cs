using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazaPristup;

namespace FoundIT.Models
{
    class RepozitorijRacuna
    {
        static public List<int> DohvatiSortiraneIdArtikalaSRacuna()
        {
            Dictionary<int, int> dictArtikalaSRacuna = new Dictionary<int, int>();
            string upit = "select id_artikl from artikl_racun;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_artikl"].ToString());
                if (dictArtikalaSRacuna.ContainsKey(id))
                {
                    dictArtikalaSRacuna[id] = dictArtikalaSRacuna[id] + 1;
                }
                else
                {
                    dictArtikalaSRacuna.Add(id, 0);
                }
            }
            reader.Close();
            var artikliSortirani = dictArtikalaSRacuna.OrderByDescending(x => x.Value).Select(y => y.Key);
            return artikliSortirani.ToList();
        }

        static public List<int> DohvatiSortiraneIdKupacaSRacuna()
        {
            Dictionary<int, int> dictKupciSRacuna = new Dictionary<int, int>();
            string upit = "select id_korisnik from racun;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_korisnik"].ToString());
                if (dictKupciSRacuna.ContainsKey(id))
                {
                    dictKupciSRacuna[id] = dictKupciSRacuna[id] + 1;
                }
                else
                {
                    dictKupciSRacuna.Add(id, 0);
                }
            }
            reader.Close();
            var kupciSortirani = dictKupciSRacuna.OrderByDescending(x => x.Value).Select(y => y.Key);
            return kupciSortirani.ToList();
        }

        static public List<int> DohvatiSveIdArtikalaSRacuna()
        {
            List<int> sviArtikliNaRacunu = new List<int>();
            string upit = "select id_artikl from artikl_racun;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_artikl"].ToString());
                sviArtikliNaRacunu.Add(id);
            }
            reader.Close();
            return sviArtikliNaRacunu;
        }

        static public List<int> DohvatiSortiraneIdZanroveSRacuna()
        {
            Dictionary<int, int> dictZanrovaSRacuna = new Dictionary<int, int>();
            List<int> sviArtikliNaRacunu = DohvatiSveIdArtikalaSRacuna();
            foreach (var item in sviArtikliNaRacunu)
            {
                string upit = string.Format("select id_zanr from artikl where id_artikl = {0}", item);
                SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_zanr"].ToString());
                    if (dictZanrovaSRacuna.ContainsKey(id))
                    {
                        dictZanrovaSRacuna[id] = dictZanrovaSRacuna[id] + 1;
                    }
                    else
                    {
                        dictZanrovaSRacuna.Add(id, 0);
                    }
                }
                reader.Close();
            }
            var artikliSortirani = dictZanrovaSRacuna.OrderByDescending(x => x.Value).Select(y => y.Key);
            return artikliSortirani.ToList();
        }
    }
}
