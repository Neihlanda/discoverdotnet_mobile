using discoverdotnet_mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace discoverdotnet_mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookmarkPage : ContentPage
    {
        public BookmarkPage()
        {
            InitializeComponent();
            this.BindingContext = new BookmarkViewModel();
        }

        protected async override void OnAppearing()
        {
            await ((BookmarkViewModel)this.BindingContext).InitializeAsync(null);
        }
    }
}