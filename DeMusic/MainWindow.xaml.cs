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
using System.Threading;
using System.Diagnostics;
namespace DeMusic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void closeOnClick(object sender, RoutedEventArgs e) => Close();
        private void minimizeOnClick(object sender, RoutedEventArgs e)=> WindowState = WindowState.Minimized;

        private void windowsDrag(object sender, MouseButtonEventArgs e)=> this.DragMove();

        private void playPauseOnClick(object sender, RoutedEventArgs e)
        {
            if (playButtonImage.Visibility==Visibility.Visible)
            {
                playButtonImage.Visibility = Visibility.Hidden;
                pauseButtonImage.Visibility = Visibility.Visible;
            }
            else if(pauseButtonImage.Visibility==Visibility.Visible)
            {
                playButtonImage.Visibility = Visibility.Visible;
                pauseButtonImage.Visibility = Visibility.Hidden;
            }
        }
        private void prevButtonOnClick(object sender, RoutedEventArgs e)
        {

        }

        private void nextButtonOnClick(object sender, RoutedEventArgs e)
        {

        }

        private void albumButton_Click(object sender, RoutedEventArgs e)
        {
            albumButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
            allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            artistButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
        }

        private void allSongsButton_Click(object sender, RoutedEventArgs e)
        {
            albumButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
            recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            artistButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
        }

        private void recentlyPlayedButton_Click(object sender, RoutedEventArgs e)
        {
            albumButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
            artistButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
        }
        private void artistButton_Click(object sender, RoutedEventArgs e)
        {
            albumButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            artistButtonSelectedHighlightIcon.Visibility = Visibility.Visible;
        }
        private void topLeftBackButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void settingButton_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow settingWindowObj = new SettingWindow();
            settingWindowObj.Owner = Application.Current.MainWindow;
            settingWindowObj.Show();
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindowObj = new AboutWindow();
            aboutWindowObj.Owner = Application.Current.MainWindow;
            aboutWindowObj.Show();
        }

        
    }
}
