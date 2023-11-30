using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using System.Reflection;
namespace App11
{

    public partial class Page1 : ContentPage
    {
        
        public Page1()
        {
            InitializeComponent();
           
        }
        public void MovePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3");
        }
        public void MovePage1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.15 Minute Timer Lofi.mp3");
        }
        public void MovePage2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.30 Minute Beautiful Jellyfish Timer with Soothing Music.mp3");
        }
        public void MovePage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.30 Minute Lo-Fi Hiphop Beats Study Timer.mp3");
        }
        public void MovePage4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.30 Minute Timer - Relaxing Instrumental Music.mp3");
        }
        public void MovePage5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.30 Minute Timer Lofi.mp3");
        }
        public void MovePage6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.330 a.m. ~ lofi hip hop  jazzhop  chillhop mix [studysleephomework music].mp3");
        }
        public void MovePage7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.45 Minute Timer Lofi.mp3");
        }
        public void MovePage8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.a playlist for night studies (dark academia).mp3");
        }
        public void MovePage9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Clouds 30 Minute Timer[lofi hip-hoprelaxing beats].mp3");
        }
        public void MovePage10(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Study with me l 45 min cozy Lofi music light study session light academia desk motivation to study.mp3");
        }
        public void MovePage11(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Sleep Music 30 Minutes Lofi.mp3");
        }
        public void MovePage12(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Deep Focus Lofi Mix ~ lofi study work  chill beats.mp3");
        }
        public void MovePage13(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.retro movie nights. [lofi  jazzhop  chill beats].mp3");
        }
        public void MovePage14(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Study());
            Player("App11.Sonidos.Charly García - Demoliendo Hoteles (Audio).mp3");
        }
        public void MoveTo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nuevo());
        }
        public void Player(string sonido)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream(sonido);
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
        }
      

    }

}
