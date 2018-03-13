using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content.PM;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace App1.Droid
{
    [Activity(Label = "EP", Icon = "@drawable/hhsshield", Theme = "@style/splashScreen", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() =>
            {
                Task.Delay(2000);

            });
            startupWork.ContinueWith(t =>
            {
                StartActivity(new Intent(ApplicationContext, typeof(MainActivity)));
            }, TaskScheduler.FromCurrentSynchronizationContext());
            startupWork.Start();
        }
       
    }
}