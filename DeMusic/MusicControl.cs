using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace DeMusic
{
    class MusicControl
    {
        //NAUDIO VARIABLES
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public void Play()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"E:\Music\Air Supply - The Definitive Collection (FLAC)\02-All Out Of Love.flac");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }
        public void Pause()
        {
            outputDevice.Pause();
        }
    }
}
