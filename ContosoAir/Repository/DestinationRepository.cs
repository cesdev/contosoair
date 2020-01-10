using ContosoAir.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Repository
{

    public class DestinationRepository
    {
        private readonly UnitOfWork _db;
        public DestinationRepository(UnitOfWork db)
        {
            _db = db;
        }

        public List<Destination> GetAll()
        {
            return _db.Destinations.FindSync(d => true).ToList();
        }
    }
}
