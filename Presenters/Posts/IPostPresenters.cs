using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Presenters.Posts
{
    public interface IPostPresenters
    {
        public IEnumerable<IPost> GetAll();
        public Post GetPostByID(Guid Id);
        public void Update(Post post);
        public void Create(List<string> data);
        public void Delete(Guid id);
    }
}
