using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using Data.Models;
using System.Configuration;

namespace Data.Services
{
    public class Service
    {
        protected IMongoDatabase _database;
        public Service(string db)
        {
            var credential = new credentials();
            var client = new MongoClient(credential.MNG);
            _database = client.GetDatabase(db);
        }
    }
}
