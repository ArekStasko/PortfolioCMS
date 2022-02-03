using MongoDB.Driver;
using Data.Models;
using Microsoft.AspNet.Identity;
using System;

namespace Data.Services
{
    public class UserServices : Service
    {
        public UserServices(string db) : base(db) { }

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
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private IMongoCollection<User> GetUsersCollection() => _database.GetCollection<User>("User");
    }
}
