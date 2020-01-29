using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            
        }

        private void Slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblAmount.Text = $"$ {Math.Round(sliderMoney.Value, 2).ToString()}";
        }

        private void stepperPies_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblPies.Text = $"You can order {stepperPies.Value} pie(s) per month";
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            activitySave.IsRunning = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            activitySave.IsRunning = false;
        }
    }
}