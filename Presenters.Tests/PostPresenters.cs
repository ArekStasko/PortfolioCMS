using NUnit.Framework;
using Presenters.Posts;
using FluentAssertions;
using System.Linq;

namespace Presenters.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //TODO -> Write all tests for posts presenters
        [Test]
        public void GetAll_ShouldReturn_AllPosts()
        {
            var _presenters = new PostPresenters();
            var posts = _presenters.GetAll().ToList();
            posts.Should().NotBeEmpty();
        }
    }
}