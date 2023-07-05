using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// prvi dio rješenja zadatka Z01
namespace E01KlasaObjekt
{
    internal class Dokument
    {
        public Dokument() 
        {
            Console.WriteLine("Prazan"); ;
        }   
        public Dokument(string name) 
        {
            Console.WriteLine("puni s {0}", name);
        }
    }
}
