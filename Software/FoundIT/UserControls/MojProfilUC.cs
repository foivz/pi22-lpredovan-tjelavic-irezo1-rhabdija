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
    public partial class MojProfilUC : UserControl
    {
        private Korisnik trenutniKorisnik;
        public MojProfilUC(Korisnik tKorisnik)
        {
            trenutniKorisnik = tKorisnik;
            InitializeComponent();
            UcitajElemente();
        }

        private void slikaClick_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            OD.Multiselect = false;
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(OD.FileName);
            var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            RepozitorijKorisnika.DodajSliku((Byte[])image, trenutniKorisnik.IdKorisnika);
        }

        private void UcitajElemente()
        {
            trenutniKorisnik = RepozitorijKorisnika.DohvatiKorisnika(trenutniKorisnik.IdKorisnika);
            pictureBox1.Image = trenutniKorisnik.Fotografija;
            emailTextInput.Text = trenutniKorisnik.Email;
            obavijestInput.Checked = trenutniKorisnik.PrimanjeObavijesti;
        }
    }
}
