using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01Nasljedivanje
{
    internal class Zivotinja : Object
    {
        public string ZivotniVijek { get; set; }

        public override string ToString()
        {
            return ZivotniVijek;
        }

    }

    
    

    
}
