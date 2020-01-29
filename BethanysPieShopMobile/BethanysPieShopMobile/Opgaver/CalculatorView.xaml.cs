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
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (lbl.Text == "0")
            {
                lbl.Text = "";
            }

            lbl.Text += ((Button)sender).Text;
        }

        private void ButtonDelete_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "0";
        }
    }
}