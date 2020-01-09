using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class IndexViewModel
    {
        public Deal[] Deals { get; set; }

        public Destination[] Destinations { get; set; }
    }
}
