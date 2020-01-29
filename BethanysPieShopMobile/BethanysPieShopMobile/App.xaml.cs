using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BethanysPieShopMobile.Views;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            #region Andre opgaver
            /*Frit*/
            //MainPage = new PlayGroundView();
            //MainPage = new CalculatorView();
            //MainPage = new ViewTestingView();


            //MainPage = new NavigationPage(new ContentPageView());
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            //MainPage = new MasterDetailPageView();
            //MainPage = new CarouselPageView();
            //MainPage = new LoginWithStackLayout();
            #endregion

            /*Bethanys Pie Shop Projekt Views*/
            //MainPage = new LoginView();
            //MainPage = new RegisterView();
            //MainPage = new ContactView();
            //MainPage = new SettingsView();
            //MainPage = new WebPageView();
            //MainPage = new PieDetailView();
            //MainPage = new PieOverview();

            //MainPage = new NavigationPage(new PieOverview());

            var alreadyRegistered = false;

            if (alreadyRegistered)
            {
                MainPage = new MainView();
            }
            else
            {
                MainPage = new NavigationPage(new LoginView());
            }

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
