using discoverdotnet_mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace discoverdotnet_mobile
{
    public static class NavigationHelper
    {
        public static void RegisterAppRoute()
        {
            Routing.RegisterRoute(nameof(NewsPage), typeof(NewsPage));
            Routing.RegisterRoute(nameof(ProjectPage), typeof(ProjectPage));
            Routing.RegisterRoute(nameof(BookmarkPage), typeof(BookmarkPage));
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
        }
    }
}
