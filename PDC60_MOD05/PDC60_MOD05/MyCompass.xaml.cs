using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60_MOD05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCompass : ContentPage
    {
        public MyCompass()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StartCommand.Execute(null);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (!DesignMode.IsDesignModeEnabled)
                ((MyCompassViewModel)BindingContext).StopCommand.Execute(null);
        }
    }
}