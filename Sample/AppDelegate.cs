using System;
using Foundation;
using UIKit;
using RevMob.iOS;

namespace Sample
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public static string MediaID { get; private set; }
		public static RevMobAds Ads {get; private set;}

		public override UIWindow Window {
			get;
			set;
		}
 
		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Replace with your RevMob Media ID
			MediaID = "paste your RevMob Media ID here";

			// Handlers
			var success = new  Action (() => Console.WriteLine("success"));
			var fail = new  Action<NSError> (e => Console.WriteLine(e));

			// Start the session
			Ads = RevMobAds.StartSessionWithAppID (MediaID,success,fail);
			Ads.TestingMode = RevMobAdsTestingMode.RevMobAdsTestingModeWithAds;

			// Show the Ads
			ShowBannerAd ();
			ShowFullScreenAd ();

			return true;
		}

		public void ShowFullScreenAd()
		{	
			try{
				var success = new  Action<RevMobFullscreen> (e => Ads.ShowFullscreen());
				var fail = new  Action<RevMobFullscreen, NSError> ((r, e) => Console.WriteLine(e));
				var onclick = new Action (() => Console.WriteLine ("clicked"));
				var onclose = new Action(() => Console.WriteLine ("closed"));
				var fullScreenAd = Ads.Fullscreen ();
				fullScreenAd.LoadWithSuccessHandler (success, fail, onclick, onclose);
			}
			catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
		}

		public void ShowBannerAd()
		{
			try{
				var success = new  Action<RevMobBanner> (e => Ads.ShowBanner ());
				var fail = new  Action<RevMobBanner, NSError> ((r, e) => Console.WriteLine(e));
				var onclick = new Action<RevMobBanner> ( e => Console.WriteLine ("clicked"));
				var bannerAd = Ads.Banner ();
				bannerAd.LoadWithSuccessHandler (success, fail, onclick);
			}
			catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}
		}
	}
}