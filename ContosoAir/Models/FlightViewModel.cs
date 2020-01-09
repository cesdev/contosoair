using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class FlightViewModel
    {
        public string From { get; set; }
        public string To { get; set; }

        public Flight[] departs { get; set; }

        public Flight[] returns { get; set; }
    }

    
}
