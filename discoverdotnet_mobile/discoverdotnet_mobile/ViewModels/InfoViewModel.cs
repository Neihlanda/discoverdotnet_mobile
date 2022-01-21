using discoverdotnet_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace discoverdotnet_mobile.ViewModels
{
    public class InfoViewModel : BaseViewModel
    {
        public List<Package> PackageUsed { get; set; }

        public InfoViewModel() : base()
        {
            PackageUsed = new List<Package>()
            {
                new Package() { Name = "Newtonsoft.Json", Version = "13.0.1", ProjectUri = "https://github.com/JamesNK/Newtonsoft.Json"},
                new Package() { Name = "Sharpnado.TaskLoaderView", Version = "2.4.0", ProjectUri = "https://github.com/roubachof/Sharpnado.TaskLoaderView" },
                new Package() { Name = "sqlite-net-pcl", Version = "1.8.116", ProjectUri = "https://github.com/praeclarum/sqlite-net" },
                new Package() { Name = "Xamarin.CommunityToolkit", Version = "1.3.2", ProjectUri = "https://github.com/xamarin/XamarinCommunityToolkit" },
                new Package() { Name = "Xamarin.Forms", Version = "5.0.0.2291", ProjectUri = "https://github.com/xamarin/Xamarin.Forms" },
                new Package() { Name = "Xamarin.Essentials", Version = "1.7.0", ProjectUri = "https://github.com/xamarin/Essentials" }
            };
        }
    }
}
