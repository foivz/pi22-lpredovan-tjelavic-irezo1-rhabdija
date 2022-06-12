using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    public class Artikl
    {
        public int IdArtikl { get; set; }
        public string Naslov { get; set; }
        public bool Dostupnost { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public string Naklada { get; set; }
        public string VrstaUveza { get; set; }
        public string Jezik { get; set; }
        public string Izdanje { get; set; }
        public int BrStranica { get; set; }
        public string ISBN { get; set; }
        public string Zanr { get; set; }
        public string Autor { get; set; }


        public Artikl(string naslov, bool dostupnost, float cijena, string opis, string naklada, string vrstaUveza, string jezik,
            string izdanje,  int brStranica, string isbn, string zanr, string autor)
        {
            Naslov = naslov;
            Dostupnost = dostupnost;
            Cijena = cijena;
            Opis = opis;
            Naklada = naklada;
            VrstaUveza = vrstaUveza;
            Jezik = jezik;
            Izdanje = izdanje;
            BrStranica = brStranica;
            ISBN = isbn;
            Zanr = zanr;
            Autor = autor;

        }
        public Artikl()
        {

        }
    }
}
