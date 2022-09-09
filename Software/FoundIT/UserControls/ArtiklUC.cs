using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoundIT.Forms;
using FoundIT.Models;

namespace FoundIT.UserControls
{
    // Tea Jelavić
    public partial class ArtiklUC : UserControl
    {
        private Artikl artikl;
        private GlavnaForma glavna1;
        private Korisnik trenKorisnik;

        public ArtiklUC(Artikl art, GlavnaForma glavna, Korisnik tKorisnik, bool artikl_1_favorit_0)
        {
            InitializeComponent();
            glavna1 = glavna;
            trenKorisnik = tKorisnik;
            artikl = art;
            PopuniArtikl(artikl_1_favorit_0);
        }

        private void PopuniArtikl(bool artikl_favorit)
        {
            if (!artikl_favorit)
            {
                label1.Visible = false;
                label2.Visible = false;
                groupBox1.Visible = false;
                labelProsjecnaOcjena.Visible = false;
                labelBrojFavorita.Visible = false;
                buttonDodajFavorit.Visible = false;
                buttonRecenzije.Visible = false;
            }
            else
            {
                buttonUkloniFavorit.Visible = false;
            }
            
            labelNaslov.Text = artikl.Naslov;
            labelAutor.Text = artikl.Autor;
            labelCijena.Text = string.Format("{0} kn", artikl.Cijena);
            labelOpis.Text = artikl.Opis;
            if (artikl.Dostupnost)
            {
                labelDostupnost.ForeColor = Color.Blue;
                labelDostupnost.Text = "Trenutno dostupno";
            }
            else
            {
                labelDostupnost.ForeColor = Color.Red;
                labelDostupnost.Text = "Trenutno nedostupno";
            }

            float prosjecnaOcjena = RepozitorijRecenzija.ProsjecnaOcjena(artikl);
            if (prosjecnaOcjena == 0)
            {
                labelProsjecnaOcjena.ForeColor = Color.Gray;
                labelProsjecnaOcjena.Text = "Nema";
            }
            else if(prosjecnaOcjena <= 5)
            {
                labelProsjecnaOcjena.ForeColor = Color.Red;
                labelProsjecnaOcjena.Text = prosjecnaOcjena.ToString("0.00");
            }
            else
            {
                labelProsjecnaOcjena.ForeColor = Color.Green;
                labelProsjecnaOcjena.Text = prosjecnaOcjena.ToString("0.00");
            }
            labelBrojFavorita.Text = RepozitorijFavorita.BrojacFavorita(artikl.IdArtikl).ToString();
        }

        private void buttonDodajFavorit_Click(object sender, EventArgs e)
        {
            textBoxGreskaOutput.Visible = false;
            try
            {
                RepozitorijFavorita.DodajFavorit(trenKorisnik, artikl);
            }
            catch
            {
                textBoxGreskaOutput.Clear();
                textBoxGreskaOutput.Visible = true;
                textBoxGreskaOutput.Text += "Artikl je već u favoritima!";
            };
            PopuniArtikl(true);
        }

        private void buttonRecenzije_Click(object sender, EventArgs e)
        {
            glavna1.KatalogRecenzijeKlik(artikl);
        }

        private void buttonUkloniFavorit_Click(object sender, EventArgs e)
        {
            RepozitorijFavorita.UkloniFavorit(trenKorisnik, artikl);
            glavna1.FavoritiKlik();
        }
    }
}
