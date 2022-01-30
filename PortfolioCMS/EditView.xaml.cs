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
using System.Windows.Shapes;
using Presenters.Posts;
using Data.Models;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for EditView.xaml
    /// </summary>
    public partial class EditView : Window
    {
        private PostPresenters postPresenters = new PostPresenters("TestPosts");
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
