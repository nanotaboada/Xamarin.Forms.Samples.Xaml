using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace Xamarin.Forms.Samples.Xaml
{
	public partial class App : Application
	{
		public App()
		{
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
			InitializeComponent();
			MainPage = new LoginPage();
		}

		protected override void OnStart()
		{ 
			
		}

		protected override void OnSleep()
		{
			
		}

		protected override void OnResume()
		{
			
		}
	}
}