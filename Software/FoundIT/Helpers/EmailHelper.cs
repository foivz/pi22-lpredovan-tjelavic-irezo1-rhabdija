using FoundIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FoundIT.Helpers
{
    static public class EmailHelper
    {
        static public void PosaljiEmailNovost(Novost nv, Korisnik k)
        {

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("foundit.books33@gmail.com", "qqlrqqluwmihdcku"),
                EnableSsl = true,
            };

            smtpClient.Send("foundit.books33@gmail.com", k.Email, nv.Naslov, nv.Sadrzaj);
        }
    }
}
