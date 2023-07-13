using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01Nasljedivanje
{
    internal class Sisavac : Zivotinja
    {
        public string TrajanjeTrudnoce { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + TrajanjeTrudnoce;
        }
    }
}
