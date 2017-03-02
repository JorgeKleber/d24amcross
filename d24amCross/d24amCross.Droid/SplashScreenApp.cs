using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace d24amCross.Droid
{
    //[Activity( Label = "SplashScreenApp" )]
    [Activity( Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true )]
    public class SplashScreenApp : Activity
    {
        protected override void OnCreate( Bundle savedInstanceState )
        {
            base.OnCreate( savedInstanceState );

            StartActivity( typeof( MainActivity ) );
        }
    }
}