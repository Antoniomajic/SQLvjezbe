using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Polaznik : Osoba
    {
        public string BrojUgovora { get; set; }

        public override string ToString()
        {
            // vidimo iz nadklase protected, internal i private načine pristupa
            // base.uvjet = true;
            return base.ToString() + " " + BrojUgovora;
        }
    }
}
