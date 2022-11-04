using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60_MOD05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarometerPage : ContentPage
    {
        public BarometerPage()
        {
            InitializeComponent();
            try
            {
            Barometer.ReadingChanged += ReadingChanged;
            Barometer.Start(SensorSpeed.UI);
            }
            catch (FeatureNotEnabledException fnsEx)
            {
                lblMeasure.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {

            }
        }
        void ReadingChanged(object sender, BarometerChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Pressure In Hectopascals: X:{data.PressureInHectopascals}";
        }
    }
}