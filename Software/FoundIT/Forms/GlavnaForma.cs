using FoundIT.Models;
using FoundIT.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundIT.Forms
{
    public partial class GlavnaForma : Form
    {
        private Korisnik trenutniKorisnik;
        private Form startForma;
        private UserControl uxTrenutniPrikaz;
        public GlavnaForma(Korisnik tKorisnik, Form startF)
        {
            trenutniKorisnik = tKorisnik;
            startForma = startF;
            InitializeComponent();
            PostaviGumbeZaNavigaciju();
        }

        private void PostaviGumbeZaNavigaciju()
        {
            string prava = trenutniKorisnik.Status;

            Button uxONamaAction = new Button();
            uxONamaAction.Name = "Naslovnica";
            uxONamaAction.Text = "Naslovnica";
            uxONamaAction.Click += NavigacijskiGumb_Click;
            uxONamaAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxONamaAction);

            Button uxKatalogAction = new Button();
            uxKatalogAction.Text = "Katalog";
            uxKatalogAction.Click += NavigacijskiGumb_Click;
            uxKatalogAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxKatalogAction);

            Button uxPostavkeRacunaAction = new Button();
            uxPostavkeRacunaAction.Text = "Pretraži";
            uxPostavkeRacunaAction.Click += NavigacijskiGumb_Click;
            uxPostavkeRacunaAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxPostavkeRacunaAction);

            Button uxFavoritiAction = new Button();
            uxFavoritiAction.Text = "Moji favoriti";
            uxFavoritiAction.Click += NavigacijskiGumb_Click;
            uxFavoritiAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxFavoritiAction);

            Button uxStatistikaProdajeAction = new Button();
            uxStatistikaProdajeAction.Text = "Košarica";
            uxStatistikaProdajeAction.Click += NavigacijskiGumb_Click;
            uxStatistikaProdajeAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxStatistikaProdajeAction);

            Button uxMojProfilAction = new Button();
            uxMojProfilAction.Text = "Moj profil";
            uxMojProfilAction.Click += NavigacijskiGumb_Click;
            uxMojProfilAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxMojProfilAction);

            Button uxOdjavaAction = new Button();
            uxOdjavaAction.Name = "odjava";
            uxOdjavaAction.Text = "Odjava";
            uxOdjavaAction.Click += NavigacijskiGumb_Click;
            uxOdjavaAction.Size = new Size(120, 30);
            uxNavigacija.Controls.Add(uxOdjavaAction);

            if (prava == "admin")
            {
                Button uxStatistikaAction = new Button();
                uxStatistikaAction.Text = "Statistika";
                uxStatistikaAction.Click += NavigacijskiGumb_Click;
                uxStatistikaAction.Size = new Size(120, 30);
                uxNavigacija.Controls.Add(uxStatistikaAction);
            }

        }
        private void NavigacijskiGumb_Click(object sender, EventArgs e)
        {
            PocistiBojuNavigacijskihGumba();
            Button kliknutiGumb = sender as Button;
            kliknutiGumb.BackColor = Color.LightBlue;
            switch (kliknutiGumb.Text)
            {
                case "Naslovnica":
                    {
                        NaslovnicaKlik();
                        break;
                    }
                case "Moj profil":
                    {
                        ProfilKlik();
                        break;
                    }
                case "Odjava":
                    {
                        OdjavaKlik();
                        break;
                    }
                case "Katalog":
                    {
                        KatalogKlik();
                        break;
                    }
                case "Moji favoriti":
                    {
                        FavoritiKlik();
                        break;
                    }
                case "Statistika":
                    {
                        StatistikaKlik();
                        break;
                    }
            }
        }

        private void PocistiBojuNavigacijskihGumba()
        {
            foreach (Button x in uxNavigacija.Controls)
            {
                x.BackColor = Color.Transparent;
            }
        }

        public void PostaviPocetnuKontrolu()
        {
            imeOutput.Text = trenutniKorisnik.Ime;
            Control kontrola = uxNavigacija.Controls.Find("Naslovnica", false).First();
            (kontrola as Button).PerformClick();
            kontrola.Select();
        }

        private void OdjavaKlik()
        {
            startForma.Visible = true;
            Close();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Control kontrola = uxNavigacija.Controls.Find("odjava", false).First();
            if (!((kontrola as Button).BackColor == Color.LightBlue))
            {
                startForma.Close();
            }
        }
        public void NaslovnicaKlik()
        {
            uxTrenutniPrikaz = new NaslovnicaNovostiUC(trenutniKorisnik, this)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }

        public void NaslovnicaKnjigeKlik()
        {
            uxTrenutniPrikaz = new NaslovnicaKnjigeUC(trenutniKorisnik, this)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }

        public void ZamjeniStranicu()
        {
            Controls.RemoveByKey("uxTrenutniPrikaz");
            Controls.Add(uxTrenutniPrikaz);
        }
        private void ProfilKlik()
        {
            uxTrenutniPrikaz = new MojProfilUC(trenutniKorisnik)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }
        public void KatalogKlik()
        {
            uxTrenutniPrikaz = new KatalogUC(trenutniKorisnik, this)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }
        public void KatalogRecenzijeKlik(Artikl artikl)
        {
            uxTrenutniPrikaz = new RecenzijeUC(artikl, this)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }
        public void FavoritiKlik()
        {
            uxTrenutniPrikaz = new FavoritiUC(trenutniKorisnik, this)
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }
        public void StatistikaKlik()
        {
            uxTrenutniPrikaz = new StatistikaUC()
            {
                Location = new Point(0, 91),
                Name = "uxTrenutniPrikaz"
            };
            ZamjeniStranicu();
        }
    }
}
