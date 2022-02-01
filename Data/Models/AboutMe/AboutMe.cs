using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Data.Models
{
    public class AboutMe : IAboutMe
    {
        [BsonId]
        public Guid _id { get; set; }

        [BsonElement("Name")]
        public string Title { get; set; } = "None";
        public string AboutDescription { get; set; } = "None Description";
        public string AboutSkills { get; set; } = "None Description";
    }
}
