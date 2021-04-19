using discoverdotnet_mobile.ViewModels;
using discoverdotnet_mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace discoverdotnet_mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            NavigationHelper.RegisterAppRoute();
        }
    }
}
