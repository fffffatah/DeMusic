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
                                                

namespace DeMusic
{
    /// <summary>
    /// Interaction logic for SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        public SettingPage()
        {
            InitializeComponent();
        }
        private void addDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            new ControlAllPageComponent(this).AddDirectory();
        }

        private void removeDirectoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveSettingButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
