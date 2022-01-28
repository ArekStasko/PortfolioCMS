using NUnit.Framework;
using Data.Services;
using Data.Models;
using FluentAssertions;
using System.Linq;

namespace Data.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var _service = new PostServices("DataTestPosts");
            var posts = _service.GetPosts();
            foreach(var post in posts)
            {
                _service.DeletePost(post._id);
            }
        }

        [Test]
        public void GetPosts_ShouldReturn_AllPosts()
        {
            var post = new Post()
            {
                Title = "TeTisttle",
                SummaryDescription = "Summary Description",
                Description = "Description Description Description"
            };
            var _service = new PostServices("DataTestPosts");
            _service.InsertPost(post);
            var posts = _service.GetPosts();
            posts.Should().Contain(p => p.Title == post.Title);

            posts = _service.GetPosts();
            posts.Should().NotBeEmpty();
        }

        [Test]
        public void InsertPost_ShouldAdd_OnePost()
        {
            var post = new Post()
            {
                Title = "TeTisttle",
                SummaryDescription = "Summary Description",
                Description = "Description Description Description"
            };
            var _service = new PostServices("DataTestPosts");
            _service.InsertPost(post);
            var posts = _service.GetPosts();
            posts.Should().Contain(p => p.Title == post.Title);
        }

        [Test]
        public void DeletePost_ShouldDelete_OnePost()
        {
            var post = new Post()
            {
                Title = "TeTisttle",
                SummaryDescription = "Summary Description",
                Description = "Description Description Description"
            };
            var _service = new PostServices("DataTestPosts");
            _service.InsertPost(post);

            post = _service.GetPosts().Where(pst => pst.Title == post.Title).FirstOrDefault();
            _service.DeletePost(post._id);
            _service.GetPosts().Should().BeEmpty();
        }

        [Test]
        public void UpdatePost_ShouldUpdate_OnePost()
        {
            var post = new Post()
            {
                Title = "TeTisttle",
                SummaryDescription = "Summary Description",
                Description = "Description Description Description"
            };
            var _service = new PostServices("DataTestPosts");
            _service.InsertPost(post);

            post = _service.GetPosts().Where(pst => pst.Title == post.Title).FirstOrDefault();
            post.Title = "elttsiTeT";
            post.SummaryDescription = "noitpircseD yrammuS";
            post.Description = "noitpircseD noitpircseD noitpircseD";

            _service.UpdatePost(post);
            _service.GetPosts().Should().Contain(pst => pst.Title == "elttsiTeT");
        }

    }
}