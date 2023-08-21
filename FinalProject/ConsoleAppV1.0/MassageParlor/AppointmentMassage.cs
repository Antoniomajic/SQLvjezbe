using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class AppointmentMassage : IDs
    {
        public Appointment Appointment { get; set; }
        public Massage Massage { get; set; }
        public int Quantity { get; set; }
    }
}
