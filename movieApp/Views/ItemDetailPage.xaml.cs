using movieApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace movieApp.Views
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