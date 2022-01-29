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

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for CreateView.xaml
    /// </summary>
    public partial class CreateView : Window
    {
        private PostsView _postView;
        private string _title;
        private string _sumDescription;
        private string _description;
        private string _gitLink;
        private string _imgLink;
        public CreateView(PostsView postView)
        {
            InitializeComponent();
            _postView = postView;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            _title = Title.Text;
            _sumDescription = SumDescription.Text;
            _description = Description.Text;
            _gitLink = GitLink.Text;
            _imgLink = ImgLink.Text;

            var _postsPrezenters = new PostPresenters("TestPosts");
            _postsPrezenters.Create(_title, _sumDescription, _description, _gitLink, _imgLink);
            _postView.Load_Elements();
            this.Close();
        }
    }
}
