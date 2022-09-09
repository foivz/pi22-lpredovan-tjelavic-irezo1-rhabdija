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
    public partial class RecenzijeUC : UserControl
    {
        private GlavnaForma glavnaF;
        private int IdArtiklaZaRecenzije;
        private List<Recenzija> listaRecenzija = new List<Recenzija>();
        public RecenzijeUC(Artikl artikl, GlavnaForma gf)
        {
            glavnaF = gf;
            IdArtiklaZaRecenzije = artikl.IdArtikl;
            InitializeComponent();
            labelNaziv.Text = artikl.Naslov;
            UcitajRecenzije();
        }
        
        private void buttonPovratakKatalog_Click(object sender, EventArgs e)
        {
            glavnaF.KatalogKlik();
        }

        async private void UcitajRecenzije()
        {
            await Task.Run(() => DohvatiRecenzije());
            var lista = listaRecenzija.OrderBy(x => x.Datum).ToList();
            foreach (Recenzija item in lista)
            {
                UserControl zaDodat = new RecenzijaUC(item);
                zaDodat.Margin = new Padding(5, 20, 5, 5);
                controlFlowRecenzije.Controls.Add(zaDodat);
            }
        }
        private void DohvatiRecenzije()
        {
            listaRecenzija = RepozitorijRecenzija.DohvatiRecenzije(IdArtiklaZaRecenzije);
        }
    }
}
