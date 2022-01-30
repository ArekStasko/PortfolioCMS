using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Data.Models
{
    public class Post : IPost
    {
        [BsonId]
        public Guid _id { get; set; }

        [BsonElement("Name")]
        public string Title { get; set; } = "None";
        public string GithubLink { get; set; } = String.Empty;
        public string SummaryDescription { get; set; } = "None Description";
        public string PhotoLink { get; set; } = String.Empty;
        public string Description { get; set; } = "https://res.cloudinary.com/daidpbgul/image/upload/v1643386473/depositphotos_318221368-stock-illustration-missing-picture-page-for-website_q0uwgh.jpg";
    }
}
