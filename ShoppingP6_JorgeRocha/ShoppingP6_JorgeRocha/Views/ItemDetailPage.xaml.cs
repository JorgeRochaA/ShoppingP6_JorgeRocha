using ShoppingP6_JorgeRocha.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShoppingP6_JorgeRocha.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}