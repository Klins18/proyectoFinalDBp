using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace App11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarCurso : ContentPage
    {
        public string NombreCancion;
        public ISimpleAudioPlayer audioPlayer;
        public AgregarCurso()
        {
            InitializeComponent();
            audioPlayer = CrossSimpleAudioPlayer.Current;
        }
        public void Playlist1_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3");
            NombreCancion = "App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3";
        }
        public void Playlist2_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.15 Minute Timer Lofi.mp3");
            NombreCancion = "App11.Sonidos.15 Minute Timer Lofi.mp3";
        }
        public void Playlist3_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.30 Minute Beautiful Jellyfish Timer with Soothing Music.mp3");
            NombreCancion = "App11.Sonidos.30 Minute Beautiful Jellyfish Timer with Soothing Music.mp3";
        }
        public void Playlist4_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.30 Minute Lo-Fi Hiphop Beats Study Timer.mp3");
            NombreCancion = "App11.Sonidos.30 Minute Lo-Fi Hiphop Beats Study Timer.mp3";

        }
        public void Playlist5_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.30 Minute Timer - Relaxing Instrumental Music.mp3");
            NombreCancion = "App11.Sonidos.30 Minute Timer - Relaxing Instrumental Music.mp3";

        }
        public void Playlist6_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.30 Minute Timer Lofi.mp3");
            NombreCancion = "App11.Sonidos.30 Minute Timer Lofi.mp3";
        }
        public void Playlist7_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.330 a.m. ~ lofi hip hop  jazzhop  chillhop mix [studysleephomework music].mp3");
            NombreCancion = "App11.Sonidos.330 a.m. ~ lofi hip hop  jazzhop  chillhop mix [studysleephomework music].mp3";
        }
        public void Playlist8_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.45 Minute Timer Lofi.mp3");
            NombreCancion = "App11.Sonidos.45 Minute Timer Lofi.mp3";
        }
        public void Playlist9_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.a playlist for night studies (dark academia).mp3");
            NombreCancion = "App11.Sonidos.a playlist for night studies (dark academia).mp3";

        }
        public void Playlist10_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Clouds 30 Minute Timer[lofi hip-hoprelaxing beats].mp3");

        }
        public void Playlist11_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Study with me l 45 min cozy Lofi music light study session light academia desk motivation to study.mp3");

        }
        public void Playlist12_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Sleep Music 30 Minutes Lofi.mp3");

        }
        public void Playlist13_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Deep Focus Lofi Mix ~ lofi study work  chill beats.mp3");

        }
        public void Playlist14_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.retro movie nights. [lofi  jazzhop  chill beats].mp3");

        }
        public void Playlist15_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3");

        }
        public void Playlist16_Clicked(object sender, EventArgs e)
        {
            Player("Sonidos.Purrple Cat - City Nights.mp3");
        }
        public void Playlist17_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Lofi Musicsleepaestheticrelaxstudywork.mp3");
        }
        public void Playlist18_Clicked(object sender, EventArgs e)
        {
            Player("App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3");
        }
        public void Player(string sonido)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream(sonido);
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
        }
        public void PauseButton_Clicked(object sender, EventArgs e)
        {
            if (audioPlayer != null)
            {
                if (audioPlayer.IsPlaying)
                {
                    audioPlayer.Pause();
                
                }
                else
                {
                    audioPlayer.Play();          
                }
            }
        }
    }
}
