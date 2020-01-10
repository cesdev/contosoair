using ContosoAir.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Repository
{

    public class FlightRepository
    {
        private readonly UnitOfWork _db;
        public FlightRepository(UnitOfWork db)
        {
            _db = db;
        }

        public List<Flight> GetBy(string fromCode, string toCode)
        {
            
            return _db.Flights.FindSync(f => (f.FromCode == fromCode && f.ToCode == toCode)).ToList();
        }
    }
}
