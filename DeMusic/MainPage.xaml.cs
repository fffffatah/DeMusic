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
using System.IO;
using FileIoOperation;
using System.Threading;

namespace DeMusic
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        //NavigationService navigationService;
        public MainPage()
        {
            InitializeComponent();
            new ControlAllPageComponent(this).CheckData();
        }
        
        private void closeOnClick(object sender, RoutedEventArgs e) => Application.Current.MainWindow.Close();
        private void minimizeOnClick(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;

        private void windowsDrag(object sender, MouseButtonEventArgs e) => Application.Current.MainWindow.DragMove();

        private void playPauseOnClick(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).PlayPauseControl();
        }
        private void prevButtonOnClick(object sender, RoutedEventArgs e)
        {

        }

        private void nextButtonOnClick(object sender, RoutedEventArgs e)
        {

        }

        private void albumButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            albumButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
        }

        private void allSongsButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
        }

        private void recentlyPlayedButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
        }
        private void artistButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            artistButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
        }
        private void topLeftBackButton_Click(object sender, RoutedEventArgs e)
        {
           /* if (navigationService.CanGoBack)
            {
                navigationService.GoBack();
            } */
        }

        private void settingButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            settingPageFrame.Visibility = Visibility.Visible;
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).HighlightHide();
            aboutPageFrame.Visibility = Visibility.Visible;
        }
    }
}
