using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacijaUnosa
{
    public class Validacija
    {
        //izvor microsoft
        static public bool ValidirajEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }
        //lozinka mora sadrzavati najmanje 8 znakova, jedno slovo i jedan broj
        static public bool ValidirajLozinku(string lozinka)
        {
            return Regex.IsMatch(lozinka, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
        }
    }
}
