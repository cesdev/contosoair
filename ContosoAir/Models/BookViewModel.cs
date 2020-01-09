using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class BookViewModel
    {
        public Airport[] Airports { get; set; }
        public string Today { get; set; }
    }

    public class BookedViewModel
    {

        public Flight Parting { get; set; }

        public Flight Returning { get; set; }
    }
}
