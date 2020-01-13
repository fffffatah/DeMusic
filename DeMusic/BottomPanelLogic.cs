using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIoOperation;
using System.Windows.Controls;
using System.Windows;

namespace DeMusic
{
    public partial class ControlAllPageComponent
    {
        //MUSIC CONTROL CLASS VARIABLE
        static MusicControl musicControl = new MusicControl();
        //THIS METHOD SHOWS THE PLAY AND PAUSE BUTTON IMAGE ACCORDING TO MUSIC STATE
        public void PlayPauseControl()
        {

            if (mainPageObj.playButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Hidden;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Visible;
                musicControl.SetSong(@"E:\Music\Air Supply - The Definitive Collection (FLAC)\02-All Out Of Love.flac");
                musicControl.Play();
            }
            else if (mainPageObj.pauseButtonImage.Visibility == Visibility.Visible)
            {
                mainPageObj.playButtonImage.Visibility = Visibility.Visible;
                mainPageObj.pauseButtonImage.Visibility = Visibility.Hidden;
                musicControl.Pause();
            }
        }
        //THIS METHOD CONTROLS SHUFFLE BUTTON LOGIC
        public void ShuffleButtonControl()
        {
            if (mainPageObj.shuffleDisabledIcon.Visibility == Visibility.Visible)
            {
                mainPageObj.shuffleDisabledIcon.Visibility = Visibility.Hidden;
                mainPageObj.shuffleEnabledIcon.Visibility = Visibility.Visible;
            }
            else
            {
                mainPageObj.shuffleDisabledIcon.Visibility = Visibility.Visible;
                mainPageObj.shuffleEnabledIcon.Visibility = Visibility.Hidden;
            }
        }
        //THIS METHOD CONTROLS REPEAT BUTTON LOGIC
        public void RepeatButtonControl()
        {
            if (mainPageObj.repeatDisabledIcon.Visibility == Visibility.Visible)
            {
                mainPageObj.repeatDisabledIcon.Visibility = Visibility.Hidden;
                mainPageObj.repeatEnabledIcon.Visibility = Visibility.Visible;
            }
            else
            {
                mainPageObj.repeatDisabledIcon.Visibility = Visibility.Visible;
                mainPageObj.repeatEnabledIcon.Visibility = Visibility.Hidden;
            }
        }
    }
}
