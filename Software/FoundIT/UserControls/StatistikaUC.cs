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

namespace FoundIT.UserControls
{
    // Tea Jelavić
    public partial class StatistikaUC : UserControl
    {
        public StatistikaUC()
        {
            InitializeComponent();
            labelKojaStatistika.Visible = false;

            buttonSveMjeseci.Visible = false;
            buttonPredprosliMjesec.Visible = false;
            buttonProsliMjesec.Visible = false;
            buttonOvajMjesec.Visible = false;

            buttonSortirajUzlazno.Visible = false;
            buttonSortirajSilazno.Visible = false;
        }

        private void buttonZanrovi_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            labelKojaStatistika.Text = "Najpopularniji zanrovi prema kupnji sortirani silazno";

            List<int> listaIdZanrovaSRacuna = RepozitorijRacuna.DohvatiSortiraneIdZanroveSRacuna();
            List<string> listaZanrova = new List<string>();
            foreach (var item in listaIdZanrovaSRacuna)
            {
                listaZanrova.Add(RepozitorijZanrova.DohvatiNazivZanra(item));
            }
            var result = listaZanrova.Select(x => new { Value = x }).ToList();
            dataGridViewStatistika.DataSource = result;
        }

        private List<Artikl> DohvatiSortiraneArtikleSRacuna()
        {
            List<Artikl> listaArtikala = RepozitorijArtikala.DohvatiArtikle();
            List<int> listaIdArtikalaSRacuna = RepozitorijRacuna.DohvatiSortiraneIdArtikalaSRacuna();
            List<Artikl> listaSvihSortiranihArtikalaSRacuna = new List<Artikl>();
            for (int i = 0; i < listaIdArtikalaSRacuna.Count; i++)
            {
                Artikl ar = listaArtikala.Find(x => x.IdArtikl == listaIdArtikalaSRacuna[i]);
                listaSvihSortiranihArtikalaSRacuna.Add(ar);
            }
            
            // Ako odkomentiras u statistici popularnosti prema kupnjama ce bit vidljivi svi, neovisno jesu li kupljeni ili ne
            /*
            bool pronaden;
            foreach (Artikl item in listaArtikala)
            {
                pronaden = false;
                for (int i = 0; i < listaIdArtikalaSRacuna.Count; i++)
                {
                    if (item.IdArtikl == listaIdArtikalaSRacuna[i])
                    {
                        pronaden = true;
                        break;
                    }
                }
                if (!pronaden)
                {
                    listaSvihSortiranihArtikalaSRacuna.Add(item);
                }
            }
            */
            return listaSvihSortiranihArtikalaSRacuna;
        }

        private void buttonArtikli_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            labelKojaStatistika.Text = "Najomiljeniji artikli prema broju favorita sortirani silazno";

            List<Artikl> listaArtikala = RepozitorijArtikala.DohvatiArtikle();
            List<int> listaFavorita = RepozitorijFavorita.DohvatiFavorite();
            List<Artikl> listaSvihSortiranihArtikalaPremaFavoritima = new List<Artikl>();
            for (int i = 0; i < listaFavorita.Count; i++)
            {
                Artikl ar = listaArtikala.Find(x => x.IdArtikl == listaFavorita[i]);
                listaSvihSortiranihArtikalaPremaFavoritima.Add(ar);
            }
            /*
            bool pronaden;
            foreach (Artikl item in listaArtikala)
            {
                pronaden = false;
                for (int i = 0; i < listaFavorita.Count; i++)
                {
                    if(item.IdArtikl == listaFavorita[i])
                    {
                        pronaden = true;
                        break;
                    }
                }
                if (!pronaden)
                {
                    listaSvihSortiranihArtikalaPremaFavoritima.Add(item);
                }
            }
            */
            dataGridViewStatistika.DataSource = listaSvihSortiranihArtikalaPremaFavoritima;
        }

        private void buttonKupci_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            labelKojaStatistika.Text = "Najčešći kupci sortirani silazno";

            List<int> listaSvihSortiranihIdKupacaSRacuna = RepozitorijRacuna.DohvatiSortiraneIdKupacaSRacuna();
            List<Korisnik> listaSvihSortiranihKupacaSRacuna = new List<Korisnik>();
            Korisnik korisnikPomocni;
            Korisnik korisnikZaPrikaz;
            foreach (var item in listaSvihSortiranihIdKupacaSRacuna)
            {
                korisnikPomocni = RepozitorijKorisnika.DohvatiKorisnika(item);
                korisnikZaPrikaz = new Korisnik()
                {
                    IdKorisnika = korisnikPomocni.IdKorisnika,
                    Ime = korisnikPomocni.Ime,
                    Prezime = korisnikPomocni.Prezime,
                    Email = korisnikPomocni.Email,
                    Status = korisnikPomocni.Status,
                    PrimanjeObavijesti = korisnikPomocni.PrimanjeObavijesti
                };
                listaSvihSortiranihKupacaSRacuna.Add(korisnikZaPrikaz);
            }
            dataGridViewStatistika.DataSource = listaSvihSortiranihKupacaSRacuna;
            dataGridViewStatistika.Columns["lozinka"].Visible = false;
            dataGridViewStatistika.Columns["kontakt"].Visible = false;
            dataGridViewStatistika.Columns["adresa"].Visible = false;
            dataGridViewStatistika.Columns["fotografija"].Visible = false;
        }
       
        private void gumbiVidljivost()
        {
            buttonZanrovi.Visible = false;
            buttonArtikliKupnja.Visible = false;
            buttonArtikli.Visible = false;
            buttonNedostupni.Visible = false;
            buttonKupci.Visible = false;
            buttonVrijemeKupnje.Visible = false;
            labelKojaStatistika.Visible = true;

            buttonSortirajSilazno.Visible = false;
            buttonSortirajUzlazno.Visible = false;

            buttonSveMjeseci.Visible = false;
            buttonPredprosliMjesec.Visible = false;
            buttonProsliMjesec.Visible = false;
            buttonOvajMjesec.Visible = false;
        }

        private void buttonVratiSe_Click(object sender, EventArgs e)
        {
            buttonZanrovi.Visible = true;
            buttonArtikliKupnja.Visible = true;
            buttonArtikli.Visible = true;
            buttonNedostupni.Visible = true;
            buttonKupci.Visible = true;
            buttonVrijemeKupnje.Visible = true;
            labelKojaStatistika.Visible = false;

            buttonSortirajSilazno.Visible = false;
            buttonSortirajUzlazno.Visible = false;

            buttonSveMjeseci.Visible = false;
            buttonPredprosliMjesec.Visible = false;
            buttonProsliMjesec.Visible = false;
            buttonOvajMjesec.Visible = false;

            dataGridViewStatistika.DataSource = null;
        }

        private void buttonNedostupni_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            labelKojaStatistika.Text = "Nedostupni artikli";
            List<Artikl> nedostupni = RepozitorijArtikala.DohvatiNedostupneArtikle();
            dataGridViewStatistika.DataSource = nedostupni;
        }

        private void buttonArtikliKupnja_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            labelKojaStatistika.Text = "Najpopularniji artikli prema kupnji";

            buttonSortirajSilazno.Visible = true;
            buttonSortirajUzlazno.Visible = true;
        }

        private void buttonVrijemeKupnje_Click(object sender, EventArgs e)
        {
            gumbiVidljivost();
            buttonSveMjeseci.Visible = true;
            buttonPredprosliMjesec.Visible = true;
            buttonProsliMjesec.Visible = true;
            buttonOvajMjesec.Visible = true;
            labelKojaStatistika.Text = "Recenzije";
        }

        private void buttonProsliMjesec_Click(object sender, EventArgs e)
        {
            List<Recenzija> listaSvihRecenzija = RepozitorijRecenzija.DohvatiSveRecenzije();
            List<Recenzija> listaProsliMjesecRecenzija = new List<Recenzija>();
            int mjesecSada = int.Parse(DateTime.Now.ToString("MM"));
            int mjesecRecenzije;
            foreach (var item in listaSvihRecenzija)
            {
                mjesecRecenzije = int.Parse(item.Datum.ToString("MM"));
                if (mjesecSada - 1 == mjesecRecenzije)
                {
                    listaProsliMjesecRecenzija.Add(item);
                }
            }
            dataGridViewStatistika.DataSource = listaProsliMjesecRecenzija;
            labelKojaStatistika.Text = string.Format("Sve recenzije za {0}. mjesec", mjesecSada - 1);
        }

        private void buttonPredprosliMjesec_Click(object sender, EventArgs e)
        {
            List<Recenzija> listaSvihRecenzija = RepozitorijRecenzija.DohvatiSveRecenzije();
            List<Recenzija> listaPredprosliMjesecRecenzija = new List<Recenzija>();
            int mjesecSada = int.Parse(DateTime.Now.ToString("MM"));
            int mjesecRecenzije;
            foreach (var item in listaSvihRecenzija)
            {
                mjesecRecenzije = int.Parse(item.Datum.ToString("MM"));
                if (mjesecSada - 2 == mjesecRecenzije)
                {
                    listaPredprosliMjesecRecenzija.Add(item);
                }
            }
            dataGridViewStatistika.DataSource = listaPredprosliMjesecRecenzija;
            labelKojaStatistika.Text = string.Format("Sve recenzije za {0}. mjesec", mjesecSada - 2);
        }

        private void buttonOvajMjesec_Click(object sender, EventArgs e)
        {
            List<Recenzija> listaSvihRecenzija = RepozitorijRecenzija.DohvatiSveRecenzije();
            List<Recenzija> listaOvajMjesecRecenzija = new List<Recenzija>();
            int mjesecSada = int.Parse(DateTime.Now.ToString("MM"));
            int mjesecRecenzije;
            foreach (var item in listaSvihRecenzija)
            {
                mjesecRecenzije = int.Parse(item.Datum.ToString("MM"));
                if (mjesecSada == mjesecRecenzije)
                {
                    listaOvajMjesecRecenzija.Add(item);
                }
            }
            dataGridViewStatistika.DataSource = listaOvajMjesecRecenzija;
            labelKojaStatistika.Text = string.Format("Sve recenzije za {0}. mjesec", mjesecSada);
        }

        private void buttonSveMjeseci_Click(object sender, EventArgs e)
        {
            labelKojaStatistika.Text = "Sve recenzije od najstarije prema najnovijoj";
            dataGridViewStatistika.DataSource = RepozitorijRecenzija.DohvatiSveRecenzije();
        }

        private void buttonSortirajUzlazno_Click(object sender, EventArgs e)
        {
            labelKojaStatistika.Text = "Najpopularniji artikli prema kupnji sortirani uzlazno";
            List<Artikl> listaSvihSortiranihArtikalaSRacuna = DohvatiSortiraneArtikleSRacuna();
            listaSvihSortiranihArtikalaSRacuna.Reverse();
            dataGridViewStatistika.DataSource = listaSvihSortiranihArtikalaSRacuna;
        }

        private void buttonSortirajSilazno_Click(object sender, EventArgs e)
        {
            labelKojaStatistika.Text = "Najpopularniji artikli prema kupnji sortirani silazno";
            List<Artikl> listaSvihSortiranihArtikalaSRacuna = DohvatiSortiraneArtikleSRacuna();
            dataGridViewStatistika.DataSource = listaSvihSortiranihArtikalaSRacuna;
        }
    }
}
