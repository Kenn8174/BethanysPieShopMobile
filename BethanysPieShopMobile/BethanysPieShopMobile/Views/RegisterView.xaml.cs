using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            btnRegister.IsEnabled = false;
        }

        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            string date = dpBirthday.Date.ToString("dddd, MMMM dd, yyyy");

            string today = DateTime.Today.ToString("dddd, MMMM dd, yyyy");

            if (date == today)
            {
                await DisplayAlert("Alert", "You weren't born today I guess!", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "You have registered successfully!", "OK");
            }
        }

        private void check_Entries(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entryUsername.Text) && !string.IsNullOrWhiteSpace(entryPassword.Text))
            {
                btnRegister.IsEnabled = true;
            }
            else
            {
                btnRegister.IsEnabled = false;
            }
        }
    }
}