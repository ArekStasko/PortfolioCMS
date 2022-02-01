using System;

namespace Data.Models
{
    public interface IPost
    {
        public Guid _id { get; set; }
        public string Title { get; set; }
        public string GithubLink { get; set; }
        public string SummaryDescription { get; set; }
        public string PhotoLink { get; set; }
        public string Description { get; set; }
    }
}
