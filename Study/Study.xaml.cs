using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Caprasimo-Regular.ttf", Alias = "Caprasimo")]

namespace App11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Study : ContentPage
    {
        public ISimpleAudioPlayer audioPlayer;
        private TimeSpan prevTime;

        public Study()
        {
            InitializeComponent();
            audioPlayer = CrossSimpleAudioPlayer.Current;
            var viewModel = new PageViewModel();
            BindingContext = viewModel;
        }

        public void MovePage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new MainPage());
        }

        public void GetTime(object obj, EventArgs args)
        {
            PageViewModel viewModel = BindingContext as PageViewModel;
            viewModel.SetTime();
            string savedPrevTime = Preferences.Get("PrevTime", string.Empty);
            if (!string.IsNullOrEmpty(savedPrevTime))
            {
                prevTime = TimeSpan.Parse(savedPrevTime);
            }
            Alert(prevTime.ToString());
           

        }

        public async void Alert(string time)
        {
            await DisplayAlert("Alert", $"Time is: {time}", "OK");
        }
        public void PauseButton_Clicked(object sender, EventArgs e)
        {
            PageViewModel model = BindingContext as PageViewModel;
            if (audioPlayer != null)
            {
                if (audioPlayer.IsPlaying)
                {
                    audioPlayer.Pause();
                    model.Stop();
                }
                else
                {
                    audioPlayer.Play();
                    model.Start();
                }
            }
        }
    }
}