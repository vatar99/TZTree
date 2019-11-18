using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TZTree
{
 
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Player_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Player());
        }

        private async void Editor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Editors());
        }

        private async void Entrys_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entrys());
        }
    }
}
