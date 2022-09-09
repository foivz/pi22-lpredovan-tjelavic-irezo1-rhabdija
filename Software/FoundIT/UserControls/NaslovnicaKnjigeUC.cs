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
    // Iva rezo i Tea Jelavić
    public partial class NaslovnicaKnjigeUC : UserControl
    {
        private Korisnik trenutniKorisnik;
        private GlavnaForma glavnaF;
        private List<Artikl> listaArtikala = new List<Artikl>();
        private List<int> listaFavorita = new List<int>();
        public NaslovnicaKnjigeUC(Korisnik tKorisnik, GlavnaForma gf)
        {
            trenutniKorisnik = tKorisnik;
            glavnaF = gf;
            InitializeComponent();
            UcitajArtikle();
        }
        
        private void uxPrikazClick_Click(object sender, EventArgs e)
        {
            glavnaF.NaslovnicaKlik();
        }
        async private void UcitajArtikle()
        {
            await Task.Run(() => DohvatiFavorite());
            int ogranicenje = 10;
            if(listaFavorita.Count < 10)
            {
                ogranicenje = listaFavorita.Count;
            }
            for(int i = 0; i < ogranicenje; i++)
            {
                Artikl ar = listaArtikala.Find(x => x.IdArtikl == listaFavorita[i]);
                UserControl zaDodat = new KnjigaUC(ar,i+1);
                zaDodat.Margin = new Padding(5, 20, 5, 5);
                uxControlFlow.Controls.Add(zaDodat);

            }
        }
        private void DohvatiFavorite()
        {
            listaFavorita = RepozitorijFavorita.DohvatiFavorite();
            listaArtikala = RepozitorijArtikala.DohvatiArtikle();
        }
    }
}
