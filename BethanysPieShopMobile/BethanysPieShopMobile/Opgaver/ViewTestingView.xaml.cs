using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTestingView : ContentPage
    {
        public ViewTestingView()
        {
            InitializeComponent();
            pgrsBar.ProgressColor = Color.Blue;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            pgrsBar.Progress = Math.Round(value, 2);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            

            if (pgrsBar.Progress == 1.0)
            {
                await pgrsBar.ProgressTo(0, 1000, Easing.Linear);
            }
            else if (pgrsBar.Progress == 0.0)
            {
                await pgrsBar.ProgressTo(1, 1000, Easing.Linear);
            }
            else if (pgrsBar.Progress < 0.51 && pgrsBar.Progress > 0.49)
            {
                await pgrsBar.ProgressTo(0.5, 0, Easing.Linear);
            }
            else
            {
                //await pgrsBar.ProgressTo(pgrsBar.Progress, 1, Easing.Linear);
                if (pgrsBar.Progress < 0.5)
                {
                    
                    await pgrsBar.ProgressTo(1, Convert.ToUInt32(1000 * (1 + pgrsBar.Progress)), Easing.Linear);
                }
                else
                {
                    await pgrsBar.ProgressTo(0, Convert.ToUInt32(1000 * (1 + pgrsBar.Progress)), Easing.Linear);
                }
            }
        }

        private void pgrsBar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lblAntal.Text = Convert.ToString(pgrsBar.Progress);
        }
    }
}