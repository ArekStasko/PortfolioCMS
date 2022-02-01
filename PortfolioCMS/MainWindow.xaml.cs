using System;
using System.Windows;
using Presenters.User;
using Presenters.Factories;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Succeed()
        {
            var postsView = new PostsView();
            postsView.Show();
            this.Close();
        }

        public void Login(object sender, RoutedEventArgs e)
        {
            IUserPresenters userPresenters = PresFactory.GetUserPresentersInstance();
            userPresenters.AuthenticateUser(Usn.Text, Psw.Password);
            if (userPresenters.AuthenticateUser(Usn.Text, Psw.Password)) 
                Login_Succeed();
            else
            {
                string errorMessage = "You provided wrong Data";
                string caption = "Wrong Data";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(errorMessage, caption, button, icon);
                Usn.Text = String.Empty;
                Psw.Password = String.Empty;
            }
        }
    }
}
