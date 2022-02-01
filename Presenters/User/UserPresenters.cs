using Data.Services;
using Data.Factories;

namespace Presenters.User
{
    public class UserPresenters : IUserPresenters
    {
        private UserServices _service;

        public UserPresenters()
        {
            _service = DataFactory.GetUserServiceInstance("TestPosts");
        }

        public bool AuthenticateUser(string usr, string psw)
        {
            if (string.IsNullOrWhiteSpace(usr) || string.IsNullOrWhiteSpace(psw)) return false;
            return _service.CheckAuthentication(usr, psw);
        }

    }
}
