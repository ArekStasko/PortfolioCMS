using System.Security.Cryptography;
using MongoDB.Driver;
using MongoDB.Bson;
using Data.Models;
using Microsoft.AspNet.Identity;
using System;

namespace Data.Services
{
    public class UserServices
    {
        private IMongoDatabase _database;
        public UserServices(string db)
        {
            var client = new MongoClient();
            _database = client.GetDatabase(db);
        }

        public bool CheckAuthentication(string username, string password)
        {
            try
            {
                IPasswordHasher hasher = new PasswordHasher();

                var collection = GetUsersCollection();
                var filter = Builders<User>.Filter.Eq("_username", username);
                var user = collection.Find(filter).First();
                PasswordVerificationResult passwordResult = hasher.VerifyHashedPassword(user._passwordHash, password);

                if (passwordResult == PasswordVerificationResult.Success)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private IMongoCollection<User> GetUsersCollection() => _database.GetCollection<User>("Users");
    }
}
