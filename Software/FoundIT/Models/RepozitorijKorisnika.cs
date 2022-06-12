using BazaPristup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Models
{
    static public class RepozitorijKorisnika
    {
        static public List<Korisnik> ListaKorisnika = new List<Korisnik>();

        static public void DodajKorisnika(Korisnik korisnik)
        {
            int status = RepozitorijPomPodataka.Uloga.FirstOrDefault(x => x.Value == korisnik.Status).Key;
            string upit = String.Format("INSERT INTO korisnik values ({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7});", status, korisnik.Ime, korisnik.Prezime, korisnik.Email, korisnik.Lozinka, korisnik.Adresa, korisnik.Kontakt, 1);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        static public List<Korisnik> DohvatiKorisnike()
        {
            ListaKorisnika.Clear();
            string upit = "SELECT * from korisnik;";
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                Korisnik korisnikZaDodat = null;
                int id = int.Parse(reader["id_korisnik"].ToString());
                string ime = reader["ime"].ToString();
                string prezime = reader["prezime"].ToString();
                string lozinka = reader["lozinka"].ToString();
                string email = reader["email"].ToString();
                string adresa = reader["adresa"].ToString();
                string kontakt = reader["kontakt"].ToString();
                string status;
                RepozitorijPomPodataka.Uloga.TryGetValue(int.Parse(reader["id_uloga"].ToString()), out status);
                bool primanjeObavijesti = bool.Parse(reader["obavijest"].ToString());
                if(reader.GetSqlBytes(9).Buffer == null)
                {
                    korisnikZaDodat = new Korisnik(ime, prezime, lozinka, email, kontakt, adresa, status, primanjeObavijesti)
                    {
                        IdKorisnika = id
                    };
                }
                else
                {
                    MemoryStream stream = new MemoryStream(reader.GetSqlBytes(9).Buffer);
                    Image foto = Image.FromStream(stream);
                    korisnikZaDodat = new Korisnik(ime, prezime, lozinka, email, kontakt, adresa, status, primanjeObavijesti)
                    {
                        IdKorisnika = id,
                        Fotografija = foto
                    };
                }
                ListaKorisnika.Add(korisnikZaDodat);
            }
            reader.Close();
            return ListaKorisnika;
        }

        public static void PromjeniPrimitakObavijesti(int idKorisnika, int primaj)
        {
            string upit = String.Format("UPDATE korisnik SET obavijest={0} where id_korisnika={1};", primaj, idKorisnika);
            BazaPodataka.Instanca.IzvrsiUpit(upit);
        }

        public static void DodajSliku(byte[] slika,int id)
        {
            BazaPodataka.Instanca.SlikuDodaj(slika, id);
        }

        public static Korisnik DohvatiKorisnika(int idK)
        {
            Korisnik korisnikZaDodat = null;
            string upit = String.Format("SELECT * from korisnik where id_korisnik={0};",idK);
            SqlDataReader reader = BazaPodataka.Instanca.DohvatiDataReader(upit);
            while (reader.Read())
            {
                int id = int.Parse(reader["id_korisnik"].ToString());
                string ime = reader["ime"].ToString();
                string prezime = reader["prezime"].ToString();
                string lozinka = reader["lozinka"].ToString();
                string email = reader["email"].ToString();
                string adresa = reader["adresa"].ToString();
                string kontakt = reader["kontakt"].ToString();
                string status;
                RepozitorijPomPodataka.Uloga.TryGetValue(int.Parse(reader["id_uloga"].ToString()), out status);
                bool primanjeObavijesti = bool.Parse(reader["obavijest"].ToString());
                if (reader.GetSqlBytes(9).Buffer == null)
                {
                    korisnikZaDodat = new Korisnik(ime, prezime, lozinka, email, kontakt, adresa, status, primanjeObavijesti)
                    {
                        IdKorisnika = id
                    };
                }
                else
                {
                    MemoryStream stream = new MemoryStream(reader.GetSqlBytes(9).Buffer);
                    Image foto = Image.FromStream(stream);
                    korisnikZaDodat = new Korisnik(ime, prezime, lozinka, email, kontakt, adresa, status, primanjeObavijesti)
                    {
                        IdKorisnika = id,
                        Fotografija = foto
                    };
                }
            }
            reader.Close();
            return korisnikZaDodat;
        }
    }
}
