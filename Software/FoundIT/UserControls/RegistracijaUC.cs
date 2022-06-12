using FoundIT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidacijaUnosa;

namespace FoundIT.UserControls
{
    // Iva rezo
    public partial class RegistracijaUC : UserControl
    {
        public RegistracijaUC()
        {
            InitializeComponent();
        }

        private void registrirajClick_Click(object sender, EventArgs e)
        {
            uxGreskaOutput.Clear();
            uxGreskaOutput.Visible = false;
            string ime = imeTextInput.Text;
            string prezime = prezimeTextInput.Text;
            string lozinka = lozinkaTextInput.Text;
            string email = emailTextInput.Text;
            string adresa = adresaTextInput.Text;
            string kontakt = kontaktTextInput.Text;
            if (ValidirajUnos(ime, prezime, email, lozinka, adresa, kontakt))
            {
                Korisnik zaDodat = new Korisnik(ime, prezime, lozinka, email, kontakt, adresa, "obicni_korisnik", true);
                RepozitorijKorisnika.DodajKorisnika(zaDodat);
                PrijavaRegistracijaForma roditelj = DohvatiRoditelja();
                roditelj.PokreniGlavnuFormu(zaDodat);
                PocistiPoljaZaUnos();
            }
            else
            {
                uxGreskaOutput.Visible = true;
            }
        }

        private bool ValidirajUnos(string ime, string prezime, string email, string lozinka, string adresa, string kontakt)
        {
            bool uspjeh = true;
            if (ime != "" && prezime != "" && email != "" && lozinka != "" && adresa != "" && kontakt != "")
            {
                if (!Validacija.ValidirajEmail(email))
                {
                    uxGreskaOutput.Text += "Email nije u dobrom formatu." + Environment.NewLine;
                    uspjeh = false;
                }

                if (!Validacija.ValidirajLozinku(lozinka))
                {
                    uxGreskaOutput.Text += "Lozinka nije u dobrom formatu. Treba sadržavati najmanje 8 znakova, jedno slovo i jedan broj." + Environment.NewLine;
                    uspjeh = false;
                }
                
            }
            else
            {
                uxGreskaOutput.Text += "Sva polja za unos trebaju biti popunjena." + Environment.NewLine;
                uspjeh = false;
            }

            return uspjeh;
        }

        private void PocistiPoljaZaUnos()
        {
            imeTextInput.Clear();
            prezimeTextInput.Clear();
            lozinkaTextInput.Clear();
            emailTextInput.Clear();
            adresaTextInput.Clear();
            kontaktTextInput.Clear();
        }
        private PrijavaRegistracijaForma DohvatiRoditelja()
        {
            return ParentForm as PrijavaRegistracijaForma;
        }

        private void prijavaClick_Click(object sender, EventArgs e)
        {
            PrijavaRegistracijaForma roditelj = DohvatiRoditelja();
            roditelj.uxTrenutniSadrzaj = new PrijavaUC()
            {
                Location = new Point(0, 0)
            };
            roditelj.ZamjeniStranicu();
        }
    }
}
