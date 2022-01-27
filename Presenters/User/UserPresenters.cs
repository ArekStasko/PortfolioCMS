using Data.Services;

namespace Presenters.User
{
    public class UserPresenters
    {
        public bool AuthenticateUser(string username, string password)
        {
            //TODO validation for values
            var service = new UserServices();
            return service.CheckAuthentication(username, password);
        }

    }
}
