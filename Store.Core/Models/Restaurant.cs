﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Store.Core.Models
{
    public class Restaurant
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
