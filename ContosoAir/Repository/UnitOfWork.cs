using ContosoAir.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Repository
{
    public class UnitOfWork
    {
        public IMongoCollection<Destination> Destinations { get; set; }

        public IMongoCollection<Deal> Deals { get; set; }

        public IMongoCollection<Airport> Airports {get;set;}

        public IMongoCollection<Flight> Flights { get; set; }



        public UnitOfWork() {
            var cliente = new MongoClient("mongodb://localhost:27017");
            var database = cliente.GetDatabase("contosoair");

            Destinations = database.GetCollection<Destination>("destination");

            Deals = database.GetCollection<Deal>("deal");

            Airports = database.GetCollection<Airport>("airport");

            Flights = database.GetCollection<Flight>("flight");
        }
    }
}
