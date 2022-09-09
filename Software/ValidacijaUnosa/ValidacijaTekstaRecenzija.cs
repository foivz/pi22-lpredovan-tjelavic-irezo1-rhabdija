using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacijaUnosa
{
    // Tea Jelavić
    public class ValidacijaTekstaRecenzija
    {
        static public bool ValidirajRecenziju(string tekst)
        {
            return Regex.IsMatch(tekst, @"^(?!.*(fuj|bljak|odvratno)).*$", RegexOptions.IgnoreCase);
        }
    }
}
