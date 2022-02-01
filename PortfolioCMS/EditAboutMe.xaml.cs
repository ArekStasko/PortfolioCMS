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
    /// Interaction logic for EditAboutMe.xaml
    /// </summary>
    public partial class EditAboutMe : Window
    {
        private AboutMePresenters aboutPresenters = new AboutMePresenters("TestPosts");
        private readonly AboutMe _about;

        public EditAboutMe()
        {
            InitializeComponent();
            _about = aboutPresenters.GetAboutMe();
            this.DataContext = _about;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            _about.Title = Title.Text;
            _about.AboutDescription = Description.Text;
            _about.AboutSkills = AboutSkills.Text;

            aboutPresenters.Update(_about);
            this.Close();
        }
    }
}
