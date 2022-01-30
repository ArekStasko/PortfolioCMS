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

            var _postsPrezenters = new PostPresenters("TestPosts");
            _postsPrezenters.Create(data);
            _postView.Load_Elements();
            this.Close();
        }
    }
}
