using System.Collections.Generic;
using Data.Models;
using Data.Services;

namespace Presenters.Posts
{
    public class PostPresenters
    {
        private PostServices postsServices;

        public PostPresenters()
        {
            postsServices = new PostServices("TestPosts");
        }

        public IEnumerable<Post> GetAllPosts()
        {
            var posts = postsServices.GetPosts();
            foreach(var post in posts)
            {
                yield return post;
            }
        }

    }
}
