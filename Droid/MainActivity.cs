using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms.Platform.Android;

namespace Xamarin.Forms.Samples.Xaml.Droid
{
	[Activity(Label = "Xamarin.Forms.Samples.Xaml.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			Forms.Init(this, bundle);

			// Visual Studio Mobile Center
			// https://mobile.azure.com/users/nanotaboada/apps/codevel-micro-isv-android/
			MobileCenter.Start("b1558f84-6e3a-473d-940c-dcedd44b2856", typeof(Analytics), typeof(Crashes));

			LoadApplication(new App());
		}
	}
}
