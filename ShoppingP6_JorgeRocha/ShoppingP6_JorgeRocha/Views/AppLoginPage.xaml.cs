using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingP6_JorgeRocha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppLoginPage : ContentPage
    {
        public AppLoginPage()
        {
            InitializeComponent();
        }

        private void togglePassword(object sender, ToggledEventArgs e)
        {
            if (showPassword.IsToggled){
                txtPassword.IsPassword = false;
            } else { 
                 txtPassword.IsPassword = true;
            }
        }

        private async void signUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserSignUpPage());
        }
    }
}