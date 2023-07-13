using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01Nasljedivanje
{
    internal class Riba : Zivotinja
    {
        public string DuzinaPeraje { get; set; }

        public override string ToString()
        {
            return base.ToString()  + ", " + DuzinaPeraje;
        }
    }
}
