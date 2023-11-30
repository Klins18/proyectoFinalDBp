using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Caprasimo-Regular.ttf", Alias = "Caprasimo")]
[assembly: ExportFont("Lexend-Regular.ttf", Alias = "Lexend")]


namespace App11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horas : ContentPage
    {
        private TimeSpan prevTime;
        public Horas()
        {
            InitializeComponent();
            var viewModel = new PageViewModel();
            BindingContext = viewModel;
        }

        public void MovePage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Study());
        }
        public void GetTime(object obj, EventArgs args)
        {
            PageViewModel viewModel = BindingContext as PageViewModel;
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
    }
}