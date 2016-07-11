using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DasQuiz.Interfaces;
using DasQuiz.Droid.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(AudioService))]

namespace DasQuiz.Droid.Services
{
   public  class AudioService : IAudioService
   {
       private MediaPlayer _mediaPlayer;

        public bool PlayCorrectSound()
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.applause);
            _mediaPlayer.Start();
            return true;
        }

        public bool PlayFaildSound()
       {
           _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.FaildSound);
            _mediaPlayer.Start();
           return true;
       }

        public bool PlayHighScore()
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.HighScore);
            _mediaPlayer.Start();
            return true;
        }

        public bool PlayWinSound()
        {
            throw new NotImplementedException();
        }

       public bool PlayCountdown(bool on_off)
       {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.countdown);
            if(on_off)
            _mediaPlayer.Start();
            else                
            _mediaPlayer.Stop();
            return true;
        }
   }
}