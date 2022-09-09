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
    public partial class KatalogUC : UserControl
    {
        List<Artikl> artikli = new List<Artikl>();
        private Korisnik trenutniKorisnik;
        private GlavnaForma glavnaF;

        public KatalogUC(Korisnik tKorisnik, GlavnaForma gf)
        {
            trenutniKorisnik = tKorisnik;
            glavnaF = gf;
            InitializeComponent();
            UcitajArtikle();
        }

        async private void UcitajArtikle()
        {
            await Task.Run(() => DohvatiArtikle());
            foreach (Artikl x in artikli)
            {
                UserControl zaDodat = new ArtiklUC(x, glavnaF, trenutniKorisnik, true);
                zaDodat.Margin = new Padding(5, 20, 5, 5);
                controlFlowKatalog.Controls.Add(zaDodat);

            }
        }
        private void DohvatiArtikle()
        {
            artikli = RepozitorijArtikala.DohvatiArtikle();
        }
    }
}
