using FoundIT.Forms;
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

namespace FoundIT
{
    public partial class PrijavaRegistracijaForma : Form
    {
        public UserControl uxTrenutniSadrzaj;
        public PrijavaRegistracijaForma()
        {
            InitializeComponent();
            UcitajPocetniPrikaz();
            RepozitorijPomPodataka.PopuniOpcije();
        }
        private void UcitajPocetniPrikaz()
        {
            uxTrenutniSadrzaj = new PrijavaUC()
            {
                Location = new Point(0, 0)
            };
            ZamjeniStranicu();
        }
        public void ZamjeniStranicu()
        {
            Controls.Clear();
            Controls.Add(uxTrenutniSadrzaj);
        }
        public void PokreniGlavnuFormu(Korisnik tKorisnik)
        {
            Visible = false;
            GlavnaForma glavna = new GlavnaForma(tKorisnik, this);
            glavna.Show();
            glavna.PostaviPocetnuKontrolu();
        }
    }
}
