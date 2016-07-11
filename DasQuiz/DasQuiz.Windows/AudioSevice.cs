using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using DasQuiz.Interfaces;
using DasQuiz.Windows;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioSevice))]
namespace DasQuiz.Windows
{
    public class AudioSevice : IAudioService
    {
        private MediaPlayer player;

        public bool PlayFaildSound()
        {
            throw new NotImplementedException();
        }

        public bool PlayCorrectSound()
        {
            throw new NotImplementedException();
        }

        public bool PlayHighScore()
        {
            throw new NotImplementedException();
        }

        public bool PlayWinSound()
        {
            throw new NotImplementedException();
        }

        public bool PlayCountdown(bool on_off)
        {
            throw new NotImplementedException();
        }
    }
}
