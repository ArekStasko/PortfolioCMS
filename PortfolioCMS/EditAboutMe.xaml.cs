using System.Windows;
using Presenters.About;
using Presenters.Factories;
using Data.Models;
using System.Collections.Generic;

namespace PortfolioCMS
{
    /// <summary>
    /// Interaction logic for EditAboutMe.xaml
    /// </summary>
    public partial class EditAboutMe : Window
    {
        private IAboutMePresenters aboutPresenters = PresFactory.GetAboutPresentersInstance();
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
            _about.PhotoLink = ImgLink.Text;

            aboutPresenters.Update(_about);
            this.Close();
        }
    }
}
