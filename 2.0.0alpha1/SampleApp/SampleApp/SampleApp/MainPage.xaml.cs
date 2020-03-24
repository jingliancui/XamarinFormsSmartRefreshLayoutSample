using SampleApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void HeaderClassicsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeaderClassicsPage());
        }

        private async void HeaderFalsifyBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeaderFalsifyPage());
        }

        private async void HeaderMaterialBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeaderMaterialPage());
        }

        private async void HeaderRadarBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeaderRadarPage());
        }

        private async void HeaderTwoLevelBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeaderTwoLevelPage());
        }

        private async void FooterBallBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FooterBallPage());
        }

        private async void FooterClassicsBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FooterClassicsPage());
        }
    }
}
