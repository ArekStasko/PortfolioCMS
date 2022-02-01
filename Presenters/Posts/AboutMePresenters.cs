using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Services;
using Data.Models;

namespace Presenters.Posts
{
    public class AboutMePresenters
    {
        private AboutServices _service;
        public AboutMePresenters(string db)
        {
            _service = new AboutServices(db);
        }

        public AboutMe GetAboutMe()
        {
            return _service.GetAboutMe();
        }

        public void Create(List<string> data)
        {
            AboutMe aboutMe = new AboutMe();
            aboutMe.Title = data[0];
            aboutMe.AboutDescription = data[1];
            aboutMe.AboutSkills = data[2];

            _service.CreateAboutMe(aboutMe);
        }

        public void Update(AboutMe aboutMe)
        {
            _service.UpdateAboutMe(aboutMe);
        }

    }
}
