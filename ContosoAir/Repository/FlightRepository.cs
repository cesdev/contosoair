using ContosoAir.DomianModel;
using ContosoAir.Models;
using MongoDB.Bson;
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

        public Flight GetById(string id)
        {
            return _db.Flights.FindSync(f => (f.Id == id)).FirstOrDefault();
        }
        public List<Flight> GetBy(string fromCode, string toCode)
        {

            return _db.Flights.FindSync(f => (f.FromCode == fromCode && f.ToCode == toCode)).ToList();
        }

        public List<FlightCount> GetGroupByFromCode()
        {
            var group = new BsonDocument{
                {
                    "$group", new BsonDocument
                    {
                         {"_id","$fromCode" },
                        {"Count", new BsonDocument
                            {
                                {"$sum", 1 }
                             }
                        }
                }
                }
            };

            var pipeline = new[] { group };
            return _db.Flights.Aggregate<FlightCount>(pipeline).ToList();
        }


    }
}
