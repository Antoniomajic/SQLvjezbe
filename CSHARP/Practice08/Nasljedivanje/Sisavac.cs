using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Sisavac : Zivotinja
    {
        public string trajanjeTrudnoce { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + trajanjeTrudnoce;
        }
    }

    
}
