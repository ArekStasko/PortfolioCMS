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

        public void Create(List<string> data)
        {
            var post = new Post()
            {
                Title = data[0],
                SummaryDescription = data[1],
                Description = data[2],
                GithubLink = data[3],
                PhotoLink = data[4]
            };
            _service.InsertPost(post);
        }

        public void Delete(Guid id)
        {
            _service.DeletePost(id);
        }

    }
}
