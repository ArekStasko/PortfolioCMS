using Data.Models;
using Data.Services;

namespace Data.Factories
{
    public static class DataFactory
    {
        public static IAboutMe GetAboutMeModel() => new AboutMe();
        public static IPost GetPostModel() => new Post();
        public static IUser GetUserModel() => new User();

        public static AboutServices GetAboutServiceInstance(this string db)
        {
            return new AboutServices(db);
        }

        public static PostServices GetPostServiceInstance(this string db)
        {
            return new PostServices(db);
        }

        public static Service GetServiceInstance(this string db)
        {
            return new Service(db);
        }

        public static UserServices GetUserServiceInstance(this string db)
        {
            return new UserServices(db);
        }
    }
}
