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
    public partial class ProjectPage : ContentPage
    {
        public ProjectPage()
        {
            InitializeComponent();
            this.BindingContext = new ProjectViewModel();
            ((ProjectViewModel)this.BindingContext).InitializeAsync(null);
        }
    }
}