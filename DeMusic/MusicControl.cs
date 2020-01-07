using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace DeMusic
{
    public class MusicControl
    {
        //NAUDIO VARIABLES
        static WaveOutEvent outputDevice;
        static AudioFileReader audioFile;
        //THIS CONSTRUCTOR RECEIVES THE SONG LOCATION AND INITIALIZES THE AVOBE VARIABLES
        public void SetSong(string song)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(song);
                outputDevice.Init(audioFile);
            }
        }
        public void Play()
        {
            outputDevice.Play();
        }
        public void Pause()
        {
            outputDevice.Pause();
        }
    }
}
