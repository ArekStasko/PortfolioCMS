using System;
using System.Collections.Generic;
using Data.Models;
using Presenters.Posts;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Presenters.Factories;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for PostsView.xaml
    /// </summary>
    public partial class PostsView : Window
    {
        private List<IPost> _posts;
        private Guid _id;
        private IPostPresenters _postsPrezenters;

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
            _postsPrezenters = PresFactory.GetPostPresentersInstance();
        }

        internal void Load_Elements()
        {
            Posts = _postsPrezenters.GetAll();
            icPosts.ItemsSource = Posts;
        }

        private void OpenAboutMe_Click(object sender, RoutedEventArgs e)
        {
            var editAboutMe = new EditAboutMe();
            editAboutMe.Show();
        }

        private void icPosts_Loaded(object sender, RoutedEventArgs e) => Load_Elements();

        private void DeletePost_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            Id = (Guid)button.Tag;
            _postsPrezenters.Delete(Id);
            Load_Elements();
        }

        private void EditPost_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            Id = (Guid)button.Tag;
            var editView = new EditView(this, Id);
            editView.Show();
        }

        private void OpenCreateView_Click(object sender, RoutedEventArgs e)
        {
            var createView = new CreateView(this);
            createView.Show();
        }

    }
}
