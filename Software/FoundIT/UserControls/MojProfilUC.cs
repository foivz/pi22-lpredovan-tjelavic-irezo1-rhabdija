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
using ValidacijaUnosa;

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
            if(trenutniKorisnik.Fotografija != null)
            {
                pictureBox1.Image = trenutniKorisnik.Fotografija;
            }
            emailTextInput.Text = trenutniKorisnik.Email;
            obavijestInput.Checked = trenutniKorisnik.PrimanjeObavijesti;
            List<Artikl> artikli = RepozitorijArtikala.DohvatiArtikle();
            List<int> mojArtikli = RepozitorijArtikala.DohvatiMojeArtikle(trenutniKorisnik.IdKorisnika);
            var mojiArtikliObjekti = artikli.FindAll(x => mojArtikli.Any(y=>x.IdArtikl==y));
            artiklBindingSource.DataSource = null;
            artiklBindingSource.DataSource = mojiArtikliObjekti;
        }

        private void obavijestSpremiClick_Click(object sender, EventArgs e)
        {
            RepozitorijKorisnika.PromjeniPrimitakObavijesti(trenutniKorisnik.IdKorisnika, obavijestInput.Checked ? 1 : 0);
            MessageBox.Show("Uspješno promijenjeno");
        }

        private void emailSpremiClick_Click(object sender, EventArgs e)
        {
            if (!Validacija.ValidirajEmail(emailTextInput.Text))
            {
                MessageBox.Show("Email nije u dobrom formatu");
            }
            else
            {
                MessageBox.Show("Uspješno promijenjeno");
                RepozitorijKorisnika.PromjeniEmail(trenutniKorisnik.IdKorisnika, emailTextInput.Text);
            }
        }

        private void lozinkaSpremiClick_Click(object sender, EventArgs e)
        {
            if (!Validacija.ValidirajLozinku(lozinkatextInput.Text))
            {
                MessageBox.Show("Lozinka nije u dobrom formatu");
            }
            else
            {
                MessageBox.Show("Uspješno promijenjeno");
                RepozitorijKorisnika.PromjeniLozinku(trenutniKorisnik.IdKorisnika, lozinkatextInput.Text);
            }
        }
    }
}
