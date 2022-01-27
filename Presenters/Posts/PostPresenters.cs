using System;
using System.Collections.Generic;
using Data.Models;
using Data.Services;

namespace Presenters.Posts
{
    public class PostPresenters
    {
        private PostServices _service;

        public PostPresenters()
        {
            _service = new PostServices("TestPosts");
        }

        public IEnumerable<IPost> GetAll()
        {
            var posts = _service.GetPosts();
            foreach(var post in posts)
            {
                yield return post;
            }
        }

        public void Update(Guid id)
        {
            var post = _service.GetPostByID(id);
            _service.UpdatePost(post);
        }

        public IPost Create()
        {
            var post = new Post();
            _service.InsertPost(post);
            return post;
        }

        public void Delete(Guid id)
        {
            _service.DeletePost(id);
        }

    }
}
