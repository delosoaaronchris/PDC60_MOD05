using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC60_MOD05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void AccelerometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1()); 

        }
        private async void BarometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarometerPage());

        }
        private async void ConnectivityPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());

        }
        private async void MagnetometerPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagnetometerPage());

        }
        private async void MyCompass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyCompass());

        }
    }
}
