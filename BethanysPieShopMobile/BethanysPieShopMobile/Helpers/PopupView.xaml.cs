using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Helpers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        async private void btnOK_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Tryk OK", "Dette er en popup med OK", "OK");
        }

        async private void btnYesOrNo_Clicked(object sender, EventArgs e)
        {
            bool asnwer = await DisplayAlert("Ja eller Nej", "Skal Kristian give kage?", "JA", "Nej");

            if (asnwer == false)
            {
                await DisplayAlert("HOV!", "Du mente vel ja, ikk?", "SELVFØLGELIG :)");
            }

        }

        async private void btnGuide_Clicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("Vil du dele denne meddelse?", "Cancel", null, "Email", "Twitter", "Facebook");
        }

        async private void btnAction_Clicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("Vil du dele denne meddelse?", "Cancel", "Delete", "Photo Roll", "Email");
        }
    }
}