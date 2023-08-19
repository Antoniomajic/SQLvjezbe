using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Zivotinja
    {
        public string duzinaKraljeznice { get; set; }

        public Zivotinja() { }  

        public override string ToString()
        {
            return duzinaKraljeznice;
        }
    }
}
