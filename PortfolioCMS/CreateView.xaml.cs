using System.Collections.Generic;
using System.Windows;
using Presenters.Posts;
using Presenters.Factories;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for CreateView.xaml
    /// </summary>
    public partial class CreateView : Window
    {
        private PostsView _postView;

        public CreateView(PostsView postView)
        {
            InitializeComponent();
            _postView = postView;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>()
            {
                Title.Text,
                SumDescription.Text,
                Description.Text,
                GitLink.Text,
                ImgLink.Text,
            };

            IPostPresenters _postsPrezenters = PresFactory.GetPostPresentersInstance();
            _postsPrezenters.Create(data);
            _postView.Load_Elements();
            this.Close();
        }
    }
}
