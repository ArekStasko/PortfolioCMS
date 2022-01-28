using System;
using System.Collections.Generic;
using Data.Models;
using MongoDB.Driver;
using MongoDB.Bson;

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
            var collection = GetPostsCollection();
            return collection.Find(new BsonDocument()).ToList();
        }

        public void InsertPost(Post post)
        { 
            var collection = GetPostsCollection();
            collection.InsertOne(post);
        }

        public void UpdatePost(Post post)
        {
            var collection = GetPostsCollection();
            var filter = Builders<Post>.Filter.Eq("_id", post._id);
            var result = collection.ReplaceOne(filter, post);
        }


        public Post GetPostByID(Guid Id)
        {
            var collection = GetPostsCollection();
            var filter = Builders<Post>.Filter.Eq("_id", Id);

            return collection.Find(filter).First();
        }

        public void DeletePost(Guid Id)
        {
            var collection = GetPostsCollection();
            var filter = Builders<Post>.Filter.Eq("_id", Id);

            collection.DeleteOne(filter);
        }

        private IMongoCollection<Post> GetPostsCollection() => _database.GetCollection<Post>("Posts");
    }
}
