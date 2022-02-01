using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public interface IUser
    {
        public Guid _id { get; set; }
        public string _username { get; set; }
        public string _passwordHash { get; set; }
    }
}
