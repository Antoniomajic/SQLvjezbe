using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class Massage : IDs
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
