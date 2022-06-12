using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    public class Korisnik
    {
        public int IdKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string Adresa { get; set; }
        public string Status { get; set; }
        public bool PrimanjeObavijesti { get; set; }
        public Image Fotografija { get; set; }


        public Korisnik(string ime, string prezime, string lozinka, string email, string kontakt, string adresa, string status, bool primanjeObavijesti)
        {
            Ime = ime;
            Prezime = prezime;
            Lozinka = lozinka;
            Email = email;
            Kontakt = kontakt;
            Adresa = adresa;
            Status = status;
            PrimanjeObavijesti = primanjeObavijesti;
        }
        public Korisnik()
        {

        }
    }
}
