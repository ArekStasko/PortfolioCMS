using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Data.Models
{
    public interface IAboutMe
    {
        public Guid _id { get; set; }
        public string Title { get; set; }
        public string AboutDescription { get; set; }
        public string AboutSkills { get; set; }
    }
}
