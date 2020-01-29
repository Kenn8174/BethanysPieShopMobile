using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BethanysPieShopMobile.Helpers;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        async private void btnBasketView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketView());
        }

        async private void btnContactusView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactusView());
        }

        async private void btnHomePageView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePageView());
        }

        async private void btnPieOverviewView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PieOverviewView());
        }
    }
}