using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class UserBooks
    {
        public string UserName { get; set; }
        public Travel[] Travels { get; set; }
    }

    public class Travel
    {

        public Flight Parting { get; set; }

        public Flight Returning { get; set; }
    }
}
