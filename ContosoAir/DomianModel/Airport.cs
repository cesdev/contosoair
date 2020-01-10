using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class Airport
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("code")]
        public string Code { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("country")]
        public string Country { get; set; }
    }
}
