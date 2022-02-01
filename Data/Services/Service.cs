using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using Data.Models;

namespace Data.Services
{
    public class Service
    {
        protected IMongoDatabase _database;
        public Service(string db)
        {
            var client = new MongoClient();
            _database = client.GetDatabase(db);
        }
    }
}
