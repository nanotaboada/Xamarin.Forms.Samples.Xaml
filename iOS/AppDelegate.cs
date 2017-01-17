using Foundation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Xamarin.Forms.Samples.Xaml.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Forms.Init();

			// Visual Studio Mobile Center
			// https://mobile.azure.com/users/nanotaboada/apps/codevel-micro-isv-ios
			MobileCenter.Start("361f4db3-224c-4b8f-8deb-f1dd1e83bf7a", typeof(Analytics), typeof(Crashes));

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
