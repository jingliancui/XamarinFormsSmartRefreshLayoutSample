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

        private async void DeliveryRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeliveryRefreshPage());
        }

        private async void DropBoxRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DropBoxRefreshPage());
        }

        private async void BezierRadarRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BezierRadarRefreshPage());
        }

        private async void BezierCircleRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BezierCircleRefreshPage());
        }

        private async void ClassicsRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClassicsRefreshPage());
        }

        private async void PhoenixRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhoenixRefreshPage());
        }

        private async void TaurusRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaurusRefreshPage());
        }

        private async void BattleCityRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BattleCityRefreshPage());
        }

        private async void HitBlockRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HitBlockRefreshPage());
        }

        private async void WaveSwipeRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaveSwipeRefreshPage());
        }

        private async void MaterialRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaterialRefreshPage());
        }

        private async void StoreHouseRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StoreHouseRefreshPage());
        }

        private async void WaterDropRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaterDropRefreshPage());
        }

        private async void FlyRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlyRefreshPage());
        }

        private async void HorizontalRefreshBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HorizontalRefreshPage());
        }
    }
}
