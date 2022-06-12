using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    public class Novost
    {
        public int IdNovosti { get; set; }
        public string Naslov { get; set; }
        public DateTime Datum { get; set; }
        public string Kategorija { get; set; }
        public string Sadrzaj { get; set; }


        public Novost(string naslov, DateTime datum, string kategorija, string sadrzaj)
        {
            Naslov = naslov;
            Datum = datum;
            Kategorija = kategorija;
            Sadrzaj = sadrzaj;
        }
        public Novost()
        {

        }
    }
}
