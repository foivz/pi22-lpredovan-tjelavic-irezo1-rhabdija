using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    // Tea Jelavić
    public class Recenzija
    {
        public int IdKorisnik { get; set; }
        public int IdArtikl { get; set; }
        public int Ocjena { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }


        public Recenzija(int ocjena, string tekst, DateTime datum)
        {
            Ocjena = ocjena;
            Tekst = tekst;
            Datum = datum;
        }
        public Recenzija()
        {

        }
    }
}
