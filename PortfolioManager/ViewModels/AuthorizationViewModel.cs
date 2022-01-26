using MvvmCross.ViewModels;


namespace MvxPortfolioManager.Core.ViewModels
{
    public class AuthorizationViewModel : MvxViewModel
    {
        private string _username;
        private string _password;
        public string Username
        {
            get => _username; 
            set { SetProperty(ref _username, value); }
        }
        public string Password
        {
            get => _password;
            set { SetProperty(ref _password, value); }
        }
        //TODO make passwordbox binding
        /*
        public void PasswordBox_PasswordChanged(object sender, )
        {

        }
        */
    }
}
