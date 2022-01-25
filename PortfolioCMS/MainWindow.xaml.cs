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

        public void GetPosts(object sender, RoutedEventArgs e)
        {
            var postsPresenters = new PostPresenters();
            var posts = postsPresenters.GetAllPosts();

            int count = 0;
            foreach(var post in posts)
            {
                count++;
                text1.Text = count.ToString();
            }
        }
    }
}
