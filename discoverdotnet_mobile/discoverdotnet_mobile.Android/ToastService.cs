using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using discoverdotnet_mobile.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: Xamarin.Forms.Dependency(typeof(IToast))]
namespace discoverdotnet_mobile.Droid
{  
    public class ToastService : IToast
    {
        public void Show(string Message)
        {
            Toast.MakeText(Application.Context, Message, ToastLength.Short).Show();
        }
    }
}