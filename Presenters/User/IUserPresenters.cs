using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.User
{
    public interface IUserPresenters
    {
        public bool AuthenticateUser(string usr, string psw);
    }
}
