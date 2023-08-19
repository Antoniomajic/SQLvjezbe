using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Riba : Zivotinja
    {
        public int duzinaPeraja { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + duzinaPeraja;
        }
    }
}
