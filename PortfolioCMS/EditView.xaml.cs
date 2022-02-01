using System;
using System.Windows;
using Presenters.Posts;
using Presenters.Factories;
using Data.Models;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for EditView.xaml
    /// </summary>
    public partial class EditView : Window
    {
        private IPostPresenters postPresenters = PresFactory.GetPostPresentersInstance();
        internal Post _post;
        private PostsView _postView;

        public EditView(PostsView postView, Guid Id)
        {
            InitializeComponent();
            _postView = postView;
            _post = postPresenters.GetPostByID(Id);
            this.DataContext = _post;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _post.Title = Title.Text;
            _post.SummaryDescription = SumDescription.Text;
            _post.Description = Description.Text;
            _post.GithubLink = GitLink.Text;
            _post.PhotoLink = ImgLink.Text;

            postPresenters.Update(_post);
            _postView.Load_Elements();
            this.Close();
        }
    }
}
