using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Data.Models;


namespace Data.Services
{
    public class AboutServices
    {
        private IMongoDatabase _database;
        public AboutServices(string db)
        {
            var client = new MongoClient();
            _database = client.GetDatabase(db);
        }

        public AboutMe GetAboutMe()
        {
            var collection = GetAboutCollection();
            return collection.Find(new BsonDocument()).ToList()[0];
        }
        
        public void CreateAboutMe(AboutMe aboutMe)
        {
            var collection = GetAboutCollection();
            collection.InsertOne(aboutMe);
        }

        public void UpdateAboutMe(AboutMe aboutMe)
        {
            var collection = GetAboutCollection();
            var filter = Builders<AboutMe>.Filter.Eq("_id", aboutMe._id);
            var result = collection.ReplaceOne(filter, aboutMe);
        }

        private IMongoCollection<AboutMe> GetAboutCollection() => _database.GetCollection<AboutMe>("About");
    }
}
