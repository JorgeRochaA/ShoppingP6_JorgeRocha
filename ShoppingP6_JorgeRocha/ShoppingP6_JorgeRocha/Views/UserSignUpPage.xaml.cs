using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingP6_JorgeRocha.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingP6_JorgeRocha.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSignUpPage : ContentPage
    {
        UserViewModel viewModel;
        public UserSignUpPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new UserViewModel();

            loadUsersRoleList();
        }

        private async void loadUsersRoleList()
        {
            pickUserRole.ItemsSource = await viewModel.GetUserRolesList();
        }

        private async void cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}