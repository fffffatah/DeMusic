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
using FileIoOperation;

namespace DeMusic
{
    /// <summary>
    /// Interaction logic for SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void closeSettingButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Activate();
            Close();
        }

        private void addDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            BrowseForDirectory browse = new BrowseForDirectory();
            ListBoxItem itm = new ListBoxItem();
            itm.Content = browse.FolderPath.SongFolderPath;
            songDirectoryListbox.Items.Add(itm);
        }

        private void removeDirectoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveSettingButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
