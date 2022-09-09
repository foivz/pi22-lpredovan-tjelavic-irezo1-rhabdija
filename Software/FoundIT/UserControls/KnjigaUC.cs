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
    public partial class KnjigaUC : UserControl
    {
        private Artikl artikl;
        private int poredak;
        public KnjigaUC(Artikl ar, int pr)
        {
            artikl = ar;
            poredak = pr;
            InitializeComponent();
            PopuniArtikl();
        }

        private void PopuniArtikl()
        {
            naslovOutput.Text = artikl.Naslov;
            autorOutput.Text = artikl.Autor;
            cijenaOutput.Text = artikl.Cijena.ToString();
            zanrOutput.Text = artikl.Zanr;
            poredakOutput.Text = poredak.ToString();
        }
    }
}
