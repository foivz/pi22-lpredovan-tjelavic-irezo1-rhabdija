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
    public partial class RecenzijaUC : UserControl
    {
        private Recenzija recenzija;
        public RecenzijaUC(Recenzija rec)
        {
            InitializeComponent();
            recenzija = rec;
            PopuniRecenziju();
        }

        private void PopuniRecenziju()
        {
            Korisnik korisnik = RepozitorijKorisnika.DohvatiKorisnika(recenzija.IdKorisnik);
            datumOutput.Text = recenzija.Datum.ToString("dd-MM-yyyy");
            korisnikOutput.Text = korisnik.Ime.ToString();
            ocjenaOutput.Text = recenzija.Ocjena.ToString();
            sadrzajOutput.Text = recenzija.Tekst;
        }
    }
}
