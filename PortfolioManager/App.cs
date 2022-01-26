using MvvmCross.ViewModels;
using MvxPortfolioManager.Core.ViewModels;

namespace MvxPortfolioManager.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<AuthorizationViewModel>();
        }
    }
}
