using NUnit.Framework;
using Data.Services;
using Data.Models;
using FluentAssertions;

namespace Data.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetPosts_ShouldReturn_AllPosts()
        {
            var _service = new PostServices("TestPosts");
            var posts = _service.GetPosts();
            posts.Should().NotBeEmpty();
        }
        //TODO -> Write all tests for test database
        /*
        [Test]
        public void InsertPost_ShouldAdd_OnePost()
        {
            var post = new Post()
            {
                Title = "TeTisttle",
                SummaryDescription = "Summary Description",
                Description = "Description Description Description"
            };
            var _service = new PostServices("TestPosts");
            _service.InsertPost(post);
            var posts = _service.GetPosts();
            posts.Should().Contain(p => p.Title == post.Title);
        }
        */
    }
}