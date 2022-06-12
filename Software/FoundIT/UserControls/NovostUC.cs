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
    public partial class NovostUC : UserControl
    {
        private Novost novost;
        public NovostUC(Novost nv)
        {
            novost = nv;
            InitializeComponent();
            PopuniNovost();
        }

        private void PopuniNovost()
        {
            naslovOutput.Text = novost.Naslov;
            datumOutput.Text = novost.Datum.ToString("dd-MM-yyyy");
            kategorijaOutput.Text = novost.Kategorija;
            sadrzajOutput.Text = novost.Sadrzaj;
        }
    }
}
