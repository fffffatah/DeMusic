using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
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
            mainPageObj.playPauseButton.IsEnabled = state;
            mainPageObj.nextButton.IsEnabled = state;
            mainPageObj.prevButton.IsEnabled = state;
            mainPageObj.shuffleButton.IsEnabled = state;
            mainPageObj.repeatButton.IsEnabled = state;
            mainPageObj.newPlaylistButton.IsEnabled = state;
        }
    }
}
