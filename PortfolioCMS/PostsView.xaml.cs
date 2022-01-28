using System;
using System.Collections.Generic;
using Data.Models;
using Presenters.Posts;
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
using System.Windows.Shapes;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for PostsView.xaml
    /// </summary>
    public partial class PostsView : Window
    {
        private List<IPost> _posts;
        private Guid _id;
        private PostPresenters _postsPrezenters;

        public IEnumerable<IPost> Posts
        {
            get => _posts;
            set
            {
                _posts = value.ToList();
            }
        }

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public PostsView()
        {
            InitializeComponent();
            _postsPrezenters = new PostPresenters("TestPosts");
        }

        private void icPosts_Loaded(object sender, RoutedEventArgs e)
        {
            Posts = _postsPrezenters.GetAll();
            icPosts.ItemsSource = Posts;
        }

        private void DeletePost_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            Id = (Guid)button.Tag;
            _postsPrezenters.Delete(Id);
        }
    }
}
