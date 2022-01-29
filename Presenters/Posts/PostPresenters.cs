using System;
using System.Collections.Generic;
using Data.Models;
using Data.Services;

namespace Presenters.Posts
{
    public class PostPresenters
    {
        private PostServices _service;

        public PostPresenters(string db)
        {
            _service = new PostServices(db);
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

        public void Create(string title, string sumDescription, string description, string GitLink, string? photoLink)
        {
            var post = new Post()
            {
                Title = title,
                SummaryDescription = sumDescription,
                Description = description,
                GithubLink = GitLink,
                PhotoLink = photoLink ?? "https://res.cloudinary.com/daidpbgul/image/upload/v1643386473/depositphotos_318221368-stock-illustration-missing-picture-page-for-website_q0uwgh.jpg"
            };
            _service.InsertPost(post);
        }

        public void Delete(Guid id)
        {
            _service.DeletePost(id);
        }

    }
}
