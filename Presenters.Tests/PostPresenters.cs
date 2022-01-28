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
            var _presenters = new PostPresenters("DataTestPosts");
            var posts = _presenters.GetAll();
            foreach (var post in posts)
            {
                _presenters.Delete(post._id);
            }
        }

        [Test]
        public void GetAll_ShouldReturn_AllPosts()
        {
            var _presenters = new PostPresenters("DataTestPosts");

            string Title = "TeTisttle1";
            string SummaryDescription = "Summary Description";
            string Description = "Description Description Description";
            string GithubLink = "LinkLinkLink";

            _presenters.Create(Title, SummaryDescription, Description, GithubLink, null);
            var posts = _presenters.GetAll().ToList();
            posts.Should().NotBeEmpty();
        }

        [Test]
        public void Delete_ShouldDelete_OnePost()
        {
            var _presenters = new PostPresenters("DataTestPosts");

            string Title = "TeTisttle1";
            string SummaryDescription = "Summary Description";
            string Description = "Description Description Description";
            string GithubLink = "LinkLinkLink";

            _presenters.Create(Title, SummaryDescription, Description, GithubLink, null);
            var post = _presenters.GetAll().Where(pst => pst.Title == Title).First();
            _presenters.Delete(post._id);
            var posts = _presenters.GetAll();
            posts.Should().NotContain(pst => pst.Title == Title);
        }

        [Test]
        public void CreatePost_ShouldCreate_OnePost() 
        {
            var _presenters = new PostPresenters("DataTestPosts");

            string Title = "TeTisttle1";
            string SummaryDescription = "Summary Description";
            string Description = "Description Description Description";
            string GithubLink = "LinkLinkLink";

            _presenters.Create(Title, SummaryDescription, Description, GithubLink, null);
            var posts = _presenters.GetAll();
            posts.Should().NotBeEmpty();
        }

        [Test]
        public void UpdatePost_ShouldUpdate_OnePost()
        {
            var _presenters = new PostPresenters("DataTestPosts");

            string Title = "TeTisttle1";
            string SummaryDescription = "Summary Description";
            string Description = "Description Description Description";
            string GithubLink = "LinkLinkLink";

            _presenters.Create(Title, SummaryDescription, Description, GithubLink, null);
            var post = _presenters.GetAll().Where(pst => pst.Title == Title).First();
            post.Title = "elttsiTeT";
            post.SummaryDescription = "noitpircseD yrammuS";
            post.Description = "noitpircseD noitpircseD noitpircseD";
            _presenters.Update(post);

        }
    }
}