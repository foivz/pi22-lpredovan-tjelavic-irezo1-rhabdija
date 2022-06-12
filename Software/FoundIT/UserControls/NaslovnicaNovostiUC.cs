using FoundIT.Forms;
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

namespace FoundIT.UserControls
{
    public partial class NaslovnicaNovostiUC : UserControl
    {
        private Korisnik trenutniKorisnik;
        private GlavnaForma glavnaF;
        private List<Novost> listaNovosti = new List<Novost>();
        public NaslovnicaNovostiUC(Korisnik tKorisnik, GlavnaForma gf)
        {
            trenutniKorisnik = tKorisnik;
            glavnaF = gf;
            InitializeComponent();
            PostaviPrava();
            UcitajNovosti();
        }

        private void uxPrikazClick_Click(object sender, EventArgs e)
        {
            glavnaF.NaslovnicaKnjigeKlik();
        }

        private void PostaviPrava()
        {
            if (trenutniKorisnik.Status == "admin")
            {
                DodajNovostClick.Visible = true;
            }
        }

        async private void UcitajNovosti()
        {
            await Task.Run(() => DohvatiNovosti());
            var lista = listaNovosti.OrderByDescending(x => x.Datum);
            foreach (Novost x in lista)
            {
                UserControl zaDodat = new NovostUC(x);
                zaDodat.Margin = new Padding(5, 20, 5, 5);
                uxControlFlow.Controls.Add(zaDodat);

            }
        }
        private void DohvatiNovosti()
        {
            listaNovosti = RepozitorijNovosti.DohvatiNovosti();
        }

        private void DodajNovostClick_Click(object sender, EventArgs e)
        {
            DodajNovost fr = new DodajNovost(trenutniKorisnik);
            fr.Show();
        }
    }
}
