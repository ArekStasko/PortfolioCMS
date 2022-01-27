using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Presenters.Posts;
using Presenters.User;

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
            var userPresenters = new UserPresenters();
            if (userPresenters.AuthenticateUser("username", "password")) 
                Login_Succeed();
            else
            {
                string errorMessage = "You provided wrong Data";
                string caption = "Wrong Data";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(errorMessage, caption, button, icon);
            }

        }
    }
}
