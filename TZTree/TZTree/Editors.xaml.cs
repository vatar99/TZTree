using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TZTree
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editors : ContentPage
    {
        public Editors()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Editor1.FontSize = Slider.Value;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if(e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;

                Stepper.Value = e.NewValue;
            }
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;

                Slider.Value = e.NewValue;
            }
        }
    }
}