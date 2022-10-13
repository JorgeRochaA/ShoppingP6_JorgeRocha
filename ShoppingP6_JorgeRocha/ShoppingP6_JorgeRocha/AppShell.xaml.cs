using ShoppingP6_JorgeRocha.ViewModels;
using ShoppingP6_JorgeRocha.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShoppingP6_JorgeRocha
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
