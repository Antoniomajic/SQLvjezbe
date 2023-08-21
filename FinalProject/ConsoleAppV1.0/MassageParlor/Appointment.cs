using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class Appointment : IDs
    {
        public DateTime DateAndTime { get; set; }
        public Customer Customer { get; set; }
    }
}
