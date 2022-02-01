using Presenters.About;
using Presenters.Posts;
using Presenters.User;

namespace Presenters.Factories
{
    public static class PresFactory
    {
        public static IAboutMePresenters GetAboutPresentersInstance()
        {
            return new AboutMePresenters();
        }

        public static IUserPresenters GetUserPresentersInstance()
        {
            return new UserPresenters();
        }

        public static IPostPresenters GetPostPresentersInstance()
        {
            return new PostPresenters();
        }
    }
}
