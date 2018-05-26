
using Android.App;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Plugin.Permissions;
using Android.Content.PM;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MyWeather.Droid
{
    [Activity(Label = "@string/app_name",
    Icon = "@mipmap/ic_launcher",
    LaunchMode = LaunchMode.SingleTask,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {

		protected override void OnCreate (Bundle bundle)
		{
			
		    ToolbarResource = Resource.Layout.Toolbar;
		    TabLayoutResource = Resource.Layout.Tabbar;
            Microsoft.AppCenter.AppCenter.Start("ddeac812-4770-4fb0-8dfe-5bf0a07f41c4", typeof(Analytics), typeof(Crashes));

		    base.OnCreate (bundle);

		    Forms.Init(this, bundle);
		
		    LoadApplication(new App());
            //Crashes.GenerateTestCrash();
            
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}


