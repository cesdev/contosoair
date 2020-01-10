using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoAir.Models
{
    public class Segment
    {
        [BsonElement("flight")]
        public string Flight { get; set; }
        [BsonElement("fromCode")]
        public string FromCode { get; set; }
        [BsonElement("departTime")] 
        public string DepartTime { get; set; }
        [BsonElement("toCode")] 
        public string ToCode { get; set; }
        [BsonElement("arrivalTime")] 
        public string ArrivalTime { get; set; }
    }
    public class Flight
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("duration")]
        public string Duration { get; set; }
        [BsonElement("price")]
        public string Price { get; set; }
        [BsonElement("fromCode")]
        public string FromCode { get; set; }
        [BsonElement("toCode")]
        public string ToCode { get; set; }
        [BsonElement("distance")] 
        public string Distance { get; set; }
        [BsonElement("segments")]
        public Segment[] Segments { get; set; }
    }
}
