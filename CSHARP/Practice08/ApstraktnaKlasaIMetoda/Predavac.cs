using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaKlasaIMetoda
{
    internal class Predavac : Osoba
    {

        public int Godine { get; set; }

        public override void Pozdravi()
        {
            Console.WriteLine(Godine>=30 ? "Dobar dan gospodine" : "Dobar dan mladiću");
        }
    }
}
