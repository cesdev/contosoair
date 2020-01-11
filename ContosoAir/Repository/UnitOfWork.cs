using ContosoAir.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public IMongoCollection<UserBooks> Books { get; set; }



        public UnitOfWork() {

            // var cliente = new MongoClient("mongodb://localhost:27017");
            var cliente = new MongoClient(new MongoClientSettings {
            
                Server=new MongoServerAddress("localhost"),
                ClusterConfigurator = cb => {
                    cb.Subscribe<CommandStartedEvent>(e =>
                    {
                        Debug.WriteLine($"{e.CommandName} - {e.Command.ToJson()}");
                    });
                    }
            });
           
            var database = cliente.GetDatabase("contosoair");

            Destinations = database.GetCollection<Destination>("destination");

            Deals = database.GetCollection<Deal>("deal");

            Airports = database.GetCollection<Airport>("airport");

            Flights = database.GetCollection<Flight>("flight");

            Books = database.GetCollection<UserBooks>("book");
        }
    }
}
