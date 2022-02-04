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
        public string PhotoLink { get; set; } = "https://res.cloudinary.com/daidpbgul/image/upload/v1643386473/depositphotos_318221368-stock-illustration-missing-picture-page-for-website_q0uwgh.jpg";
    }
}
