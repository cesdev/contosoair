using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class Deal
    {
        public string Id { get; set; }
        public string FromName { get; set; }
        public string FromCode { get; set; }
        public string ToName { get; set; }
        public string ToCode { get; set; }
        public string Price { get; set; }
        public string departTime { get; set; }
        public string arrivalTime { get; set; }

        public string hours { get; set; }
        public string stops { get; set; }
        public string since { get; set; }
    }
}
