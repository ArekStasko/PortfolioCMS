using Data.Services;

namespace Presenters.User
{
    public class UserPresenters
    {
        private UserServices _service;

        public UserPresenters(string db)
        {
            _service = new UserServices(db);
        }

        public bool AuthenticateUser(string usr, string psw)
        {
            if (string.IsNullOrWhiteSpace(usr) || string.IsNullOrWhiteSpace(psw)) return false;
            return _service.CheckAuthentication(usr, psw);
        }

    }
}
