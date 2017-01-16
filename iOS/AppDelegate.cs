using Foundation;
using UIKit;

namespace Xamarin.Forms.Samples.Xaml.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Forms.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
