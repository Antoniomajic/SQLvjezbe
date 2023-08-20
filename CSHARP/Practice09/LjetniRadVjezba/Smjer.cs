using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRadVjezba
{
    internal class Smjer : Entitet
    {
        // za ovu klasu ne treba konstruktor jer će ona ima samo svojstva (property/prop)
        
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public decimal Cijena { get; set; }
        public decimal Upisnina { get; set; }
        public bool Verificiran { get; set; }
    }
}
