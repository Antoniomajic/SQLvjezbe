using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaKlasaIMetoda
{
    internal abstract class Osoba
    {

        public abstract void Pozdravi();


        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}

