using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Data.Models
{
    public class User
    {
        [BsonId]
        public Guid _id { get; set; }

        [BsonElement("Name")]
        public string _username { get; set; }
        public string _passwordHash { get; set; }

    }
}
