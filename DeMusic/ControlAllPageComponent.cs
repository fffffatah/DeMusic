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
        static MainPage mainPageObj;
        static AboutPage aboutPageObj;
        static SettingPage settingPageObj;
        static MusicControl musicControl = new MusicControl();
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
        //THIS CHANGES THE STATE OF BUTTONS
        public void ChangeButtonState(bool state)
        {
            mainPageObj.albumButton.IsEnabled = state;
            mainPageObj.artistButton.IsEnabled = state;
            mainPageObj.allSongsButton.IsEnabled = state;
            mainPageObj.recentlyPlayedButton.IsEnabled = state;
            mainPageObj.topLeftBackButton.IsEnabled = state;
            mainPageObj.musicSeekBar.IsEnabled = state;
            mainPageObj.volumeSlider.IsEnabled = state;
        }
        //THIS METHOD CHECKS FOR THE DB FILE IN APPDATA
        public void CheckData()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DeMusic\songdatabase.db"))
            {
                mainPageObj.lonelyPageFrame.Visibility = Visibility.Hidden;
                ChangeButtonState(true);
            }
            else
            {
               mainPageObj.lonelyPageFrame.Visibility = Visibility.Visible;
                ChangeButtonState(false);
            }
            
        }
        //THIS MEHTOD SHOWS THE PLAY AND PAUSE BUTTON IMAGE ACCORDING TO MUSIC STATE
        public void PlayPauseControl()
        {
            
            if (mainPageObj.playButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Hidden;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Visible;
                musicControl.Play();
            }
            else if (mainPageObj.pauseButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Visible;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Hidden;
                musicControl.Pause();
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
            mainPageObj.albumsPageFrame.Visibility = Visibility.Hidden;
            mainPageObj.artistPageFrame.Visibility = Visibility.Hidden;
            mainPageObj.recentlyPlayedPageFrame.Visibility = Visibility.Hidden;
            mainPageObj.allSongsPageFrame.Visibility = Visibility.Hidden;
            mainPageObj.topLeftBigLabel.Visibility = Visibility.Hidden;
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
