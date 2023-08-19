using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Som : Riba
    {
        public int duzinaBrkova { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + duzinaBrkova;
        }
    }
}
