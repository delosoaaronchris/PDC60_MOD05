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
    public partial class MagnetometerPage : ContentPage
    {
        public MagnetometerPage()
        {
            InitializeComponent();
            try
            {
                Magnetometer.ReadingChanged += ReadingChanged;
                Magnetometer.Start(SensorSpeed.UI);
            }
            catch (FeatureNotEnabledException fnsEx)
            {
                lblMeasure.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblMeasure.Text = ex.Message;
            }

        }
        void ReadingChanged(object sender, MagnetometerChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Readings: \n X:{data.MagneticField.X}, \n Y: {data.MagneticField.Y}";
        }
    }
}