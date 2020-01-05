using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using FileIoOperation;
using System.Windows.Controls;

namespace DeMusic
{
    public class ControlAllPageComponent
    {
        //PAGE OBJECTS IN THIS ASSEMBLY
        private static MainPage mainPageObj;
        private static AboutPage aboutPageObj;
        private static SettingPage settingPageObj;
        //OVERLOADED CONSTRUCTORS
        public ControlAllPageComponent(MainPage obj)
        {
            mainPageObj = obj;
        }
        public ControlAllPageComponent(AboutPage obj)
        {
            aboutPageObj = obj;
        }
        public ControlAllPageComponent(SettingPage obj)
        {
            settingPageObj = obj;
        }
        //THIS METHOD CHECKS FOR THE DB FILE IN APPDATA
        public void CheckData()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DeMusic\songdatabase.db"))
            {
               mainPageObj.lonelyPageFrame.Visibility = Visibility.Hidden;
            }
            else
            {
               mainPageObj.lonelyPageFrame.Visibility = Visibility.Visible;
            }
        }
        //THIS MEHTOD SHOWS THE PLAY AND PAUSE BUTTON IMAGE ACCORDING TO MUSIC STATE
        public void PlayPauseControl()
        {
            if (mainPageObj.playButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Hidden;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Visible;
            }
            else if (mainPageObj.pauseButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Visible;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Hidden;
            }
        }
        //THIS METHOD HIDES HIGHLIGHT,ABOUT,SETTING COMPONENT
        public void HighlightHide()
        {
            mainPageObj.allSongsButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            mainPageObj.recentlyPlayedButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            mainPageObj.artistButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            mainPageObj.albumButtonSelectedHighlightIcon.Visibility = Visibility.Hidden;
            mainPageObj.aboutPageFrame.Visibility = Visibility.Hidden;
            mainPageObj.settingPageFrame.Visibility = Visibility.Hidden;
        }
        //THIS METHOD IS FOR ADD BUTTON IN SETTING PAGE
        public void AddDirectory()
        {
            BrowseForDirectory browse = new BrowseForDirectory();
            ListBoxItem itm = new ListBoxItem();
            itm.Content = browse.FolderPath.SongFolderPath;
            settingPageObj.songDirectoryListbox.Items.Add(itm);
        }
    }
}
