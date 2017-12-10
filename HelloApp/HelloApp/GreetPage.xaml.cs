using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            sliderHello.Value = 0.5;
                        
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblHello.Text = String.Format("Value is{0:F3}", e.NewValue);
        }
    }
}