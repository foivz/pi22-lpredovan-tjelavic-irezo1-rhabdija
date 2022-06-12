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
using FoundIT.Helpers;

namespace FoundIT.Forms
{
    public partial class DodajNovost : Form
    {
        private Korisnik trenutniKorisnik;
        public DodajNovost(Korisnik tKorisnik)
        {
            trenutniKorisnik = tKorisnik;
            InitializeComponent();
        }

        private void uxDodajClick_Click(object sender, EventArgs e)
        {
            if(uxDatumInput.Text !="" && uxKategorijaInput.Text != "" && uxNaslovInput.Text !="" && uxSadrzajInput.Text != "")
            {
                Novost nv = new Novost(uxNaslovInput.Text, uxDatumInput.Value, uxKategorijaInput.Text, uxSadrzajInput.Text);
                RepozitorijNovosti.DodajNovost(nv, trenutniKorisnik);
                List<Korisnik> sviKorisnici = RepozitorijKorisnika.DohvatiKorisnike();
                var samoDopusteni = sviKorisnici.FindAll(x => x.PrimanjeObavijesti == true);
                foreach(Korisnik x in samoDopusteni)
                {
                    EmailHelper.PosaljiEmailNovost(nv, x);
                }
                Close();
            }
        }
    }
}
