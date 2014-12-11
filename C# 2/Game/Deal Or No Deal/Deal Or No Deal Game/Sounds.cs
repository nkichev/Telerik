using System;
using System.IO;
using System.Media;
using System.Net;

namespace Telerik.TeamProject.DealOrNoDealGame
{
    public class Sounds
    {
        public static void SetUpAidio()
        {
            if (!File.Exists(@"..\..\Applause.wav")
                && !File.Exists(@"..\..\Intro Music.wav")
                && !File.Exists(@"..\..\Game Music.wav")
                && !File.Exists(@"..\..\Phone is calling.wav")
                && !File.Exists(@"..\..\Thinking Music.wav"))
            {
                DownloadSounds("http://marbel.bg/GameSounds/");
            }         
        }

        private static void DownloadSounds(string webHost)
        {
            Console.Write("Downloading sounds from internet.");

            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(webHost + "Applause.wav", @"..\..\Applause.wav");
                Client.DownloadFile(webHost + "Intro Music.wav", @"..\..\Intro Music.wav");
                Client.DownloadFile(webHost + "Game Music.wav", @"..\..\Game Music.wav");
                Client.DownloadFile(webHost + "Phone is calling.wav", @"..\..\Phone is calling.wav");
                Client.DownloadFile(webHost + "Thinking Music.wav", @"..\..\Thinking Music.wav");
            }

            Console.Clear();
        }

        public static void PlayIntroMusic()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Intro Music.wav");
            sp.Play();
        }

        public static void PlayGameMusic()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Game Music.wav");
            sp.PlayLooping();
        }

        public static void PlayBankOfferMusic()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Phone is calling.wav");
            sp.Play();
        }

        public static void PlayThinkingMusic()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Thinking Music.wav");
            sp.Play();
        }

        public static void PlayApplause()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Applause.wav");
            sp.Play();
        }
    }
}
