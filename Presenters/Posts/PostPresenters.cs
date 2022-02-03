using System;
using System.Collections.Generic;
using Data.Models;
using Data.Services;
using Data.Factories;

namespace Presenters.Posts
{
    public class PostPresenters : IPostPresenters
    {
        private PostServices _service;

        public PostPresenters()
        {
            _service = DataFactory.GetPostServiceInstance("Portfolio");
        }

        public IEnumerable<IPost> GetAll()
        {
            var posts = _service.GetPosts();
            foreach(var post in posts)
            {
                yield return post;
            }
        }

        public Post GetPostByID(Guid Id)
        {
            var post = _service.GetPostByID(Id);
            return post;
        }

        public void Update(Post post)
        {
            _service.UpdatePost(post);
        }

        public void Create(List<string> data)
        {
            var post = new Post();
            post.Title = data[0];
            post.SummaryDescription = data[1];
            post.Description = data[2];
            post.GithubLink = data[3];
            post.PhotoLink = data[4];
            
            _service.InsertPost(post);
        }

        public void Delete(Guid id)
        {
            _service.DeletePost(id);
        }

    }
}
