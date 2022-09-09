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
    public partial class FavoritiUC : UserControl
    {
        List<Artikl> favoriti = new List<Artikl>();
        private Korisnik trenutniKorisnik;
        private GlavnaForma glavnaF;

        public FavoritiUC(Korisnik tKorisnik, GlavnaForma gf)
        {
            trenutniKorisnik = tKorisnik;
            glavnaF = gf;
            InitializeComponent();
            UcitajFavorite();
        }

        async private void UcitajFavorite()
        {
            await Task.Run(() => DohvatiFavorite());
            foreach (Artikl x in favoriti)
            {
                UserControl zaDodat = new ArtiklUC(x, glavnaF, trenutniKorisnik, false);
                zaDodat.Margin = new Padding(5, 20, 5, 5);
                controlFlowFavoriti.Controls.Add(zaDodat);

            }
        }
        private void DohvatiFavorite()
        {
            favoriti = RepozitorijFavorita.DohvatiMojeFavorite(trenutniKorisnik.IdKorisnika);
        }
        
    }
}
