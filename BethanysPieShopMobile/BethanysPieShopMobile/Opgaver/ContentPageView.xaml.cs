﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageView : ContentPage
    {
        public ContentPageView()
        {
            InitializeComponent();
        }

        async private void btnNavigation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPageView());
        }
    }
}