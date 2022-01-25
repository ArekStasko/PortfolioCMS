using MongoDB.Driver;
using MongoDB.Bson;
using Data.Models;
using System.Collections.Generic;

namespace Data.Services
{
    public class PostServices
    {
        private IMongoDatabase _database;

        public PostServices(string db)
        {
            var client = new MongoClient();
            _database = client.GetDatabase(db);
        }

        public List<Post> GetPosts()
        {
            var collection = _database.GetCollection<Post>("Posts");
            return collection.Find(new BsonDocument()).ToList();
        }

    }
}
