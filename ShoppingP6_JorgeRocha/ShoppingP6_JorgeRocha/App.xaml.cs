using ShoppingP6_JorgeRocha.Services;
using ShoppingP6_JorgeRocha.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingP6_JorgeRocha
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new AppLoginPage());
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
