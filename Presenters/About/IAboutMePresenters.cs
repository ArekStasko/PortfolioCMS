using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Presenters.About
{
    public interface IAboutMePresenters
    {
        public AboutMe GetAboutMe();
        public void Create(List<string> data);
        public void Update(AboutMe aboutMe);
    }
}
