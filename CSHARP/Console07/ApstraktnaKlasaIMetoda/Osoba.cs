using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02ApstraktnaKlasaIMetoda
{
    internal abstract class Osoba
    {
        // abstraktna metoda
        public abstract void Pozdravi(); // za nju je karakteristično da nema tijelo
        // ova metoda postoji ali ne znam kako se ponaša


        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
