using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class Segment
    {
        public string Flight { get; set; }
        public string FromCode { get; set; }
        public string DepartTime { get; set; }
        public string ToCode { get; set; }
        public string ArrivalTime { get; set; }
    }
    public class Flight
    {
        public string Id { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }

        public string FromCode { get; set; }
        public string ToCode { get; set; }
        public string Distance { get; set; }
        public Segment[] Segments { get; set; }
    }
}
