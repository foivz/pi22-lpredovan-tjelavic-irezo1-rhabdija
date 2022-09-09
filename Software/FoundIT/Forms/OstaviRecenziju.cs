using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoundIT.Models;
using ValidacijaUnosa;

namespace FoundIT.Forms
{
    // Tea Jelavić
    public partial class OstaviRecenziju : Form
    {
        List<int> ocjene = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Artikl artikl;
        Korisnik korisnik;
        public OstaviRecenziju(Korisnik tKorisnik, Artikl odabraniArtikl)
        {
            InitializeComponent();
            labelNaziv.Text = odabraniArtikl.Naslov;
            comboBoxOcjene.DataSource = ocjene;
            artikl = odabraniArtikl;
            korisnik = tKorisnik;
            textBoxGreskaOutput.Visible = false;
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {
            DateTime datumDanasnji = DateTime.Now;
            
            if (!ValidacijaTekstaRecenzija.ValidirajRecenziju(textBoxSadrzaj.Text))
            {
                
                textBoxGreskaOutput.Clear();
                textBoxGreskaOutput.Visible = true;
                textBoxGreskaOutput.Text += "Zabranjen unos ružnih riječi!";
            }
            else
            {
                textBoxGreskaOutput.Visible = false;
                try
                {
                    Recenzija novaRecezija = new Recenzija((int)comboBoxOcjene.SelectedItem, textBoxSadrzaj.Text, datumDanasnji);
                    RepozitorijRecenzija.DodajRecenziju(korisnik, artikl, novaRecezija);
                    Close();
                }
                catch
                {
                    textBoxGreskaOutput.Clear();
                    textBoxGreskaOutput.Visible = true;
                    textBoxGreskaOutput.Text += "Već ste ostavili svoju recenziju!";
                };
            }
        }
    }
}
