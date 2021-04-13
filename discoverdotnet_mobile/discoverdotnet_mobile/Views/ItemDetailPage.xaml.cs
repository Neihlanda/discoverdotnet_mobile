using discoverdotnet_mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace discoverdotnet_mobile.Views
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