﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingP6_JorgeRocha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSignUpPage : ContentPage
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private async void cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}