using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaObjekt
{
    internal class Dokument
    {
        public Dokument() 
        {
            Console.WriteLine("Ovo je dokument");
        }   

        public Dokument(string naziv) 
        {
            Console.WriteLine(naziv);
        }

        public Dokument (int broj)
        {
            Console.WriteLine(broj);
        }
    }
}
