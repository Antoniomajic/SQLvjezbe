using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01Nasljedivanje
{
    internal class Som : Riba
    {
        public string DuzinaBrkova { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + DuzinaBrkova;
        }

    }
}
