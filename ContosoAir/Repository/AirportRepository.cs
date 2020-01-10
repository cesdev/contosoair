using ContosoAir.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Repository
{
    public class AirportRepository
    {
        private readonly UnitOfWork _db;
        public AirportRepository(UnitOfWork db)
        {
            _db = db;
        }

        public List<Airport> GetAll()
        {
            return _db.Airports.FindSync(a => true).ToList();
        }
    }
}
