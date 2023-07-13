using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01Nasljedivanje
{
    internal class Osoba : Object // svaka klasa nasljeđuje Object
    {

        int brojac;
        protected bool uvjet;
        private String naziv;
        internal DateTime datum;

        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba()
        {

        }

        // metoda ToString postoji na klasi Object i mi ovdje redefiniramo (prepišemo preko/override) njezine ponašanje
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public override bool Equals(object? obj)
        {
            var o = obj as Osoba;
            return Sifra.Equals(o.Sifra);
        }

    }
}
