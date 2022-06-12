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
    public partial class PrijavaUC : UserControl
    {
        public PrijavaUC()
        {
            InitializeComponent();
        }

        private PrijavaRegistracijaForma DohvatiRoditelja()
        {
            return ParentForm as PrijavaRegistracijaForma;
        }

        private bool Validiraj(string email, string lozinka)
        {
            if (email != "" && lozinka != "")
            {
                if (!Validacija.ValidirajEmail(email))
                {
                    uxGreskaOutput.Text += "Email je u krivom formatu.";
                    return false;
                }
            }
            else
            {
                uxGreskaOutput.Text += "Popunite sva polja";
                return false;
            }
            return true;
        }

        private void prijavaClick_Click(object sender, EventArgs e)
        {
            uxGreskaOutput.Clear();
            uxGreskaOutput.Visible = false;
            string email = emailTextInput.Text;
            string lozinka = lozinkaTextInput.Text;
            if (Validiraj(email, lozinka))
            {
                ProvjeriKorisnika(email, lozinka);
            }
            if (uxGreskaOutput.Text != "")
            {
                uxGreskaOutput.Visible = true;
            }
        }
        private void ProvjeriKorisnika(string email, string lozinka)
        {

            List<Korisnik> listaKorisnika = RepozitorijKorisnika.DohvatiKorisnike();
            Korisnik pronadeniKorisnik = listaKorisnika.FirstOrDefault(x => x.Email == email && x.Lozinka == lozinka);
            if (pronadeniKorisnik == null)
            {
                uxGreskaOutput.Text += "Neuspješan login" + Environment.NewLine;
            }
            else
            {
                PrijavaRegistracijaForma roditelj = DohvatiRoditelja();
                roditelj.PokreniGlavnuFormu(pronadeniKorisnik);
                emailTextInput.Clear();
                lozinkaTextInput.Clear();
            }
        }

        private void registracijaClick_Click(object sender, EventArgs e)
        {
            PrijavaRegistracijaForma roditelj = DohvatiRoditelja();
            roditelj.uxTrenutniSadrzaj = new RegistracijaUC()
            {
                Location = new Point(0, 0)
            };
            roditelj.ZamjeniStranicu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrijavaRegistracijaForma roditelj = DohvatiRoditelja();
            List<Korisnik> lista = RepozitorijKorisnika.DohvatiKorisnike();
            roditelj.PokreniGlavnuFormu(lista[0]);
        }
    }
}
