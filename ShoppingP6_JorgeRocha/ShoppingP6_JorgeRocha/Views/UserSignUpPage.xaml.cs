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

        private async void signUp(object sender, EventArgs e)
        {
            bool response = await viewModel.addNewUser(
                txtName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPassword.Text.Trim(),
                txtEmailBackup.Text.Trim(),
                txtPhone.Text.Trim()
                );

            if (response)
            {
                await DisplayAlert(":)","User Created Succesfully","OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":C", "There was a problem creating the user", "OK");
            }
        }
    }
}