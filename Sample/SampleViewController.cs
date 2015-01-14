using System;
using UIKit;

namespace Sample
{
	public partial class SampleViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public SampleViewController (IntPtr handle) : base (handle)
		{
		}
			
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.Black;

			// Check to see if the media ID is missing
			if (AppDelegate.MediaID == "paste your RevMob Media ID here") {
				new UIAlertView ("RevMob Media ID", "Please paste your RevMob Media ID into the Finished Launching event in the App Delegate.  Get yours at RevMob.com", null, "OK", null).Show();
			}
		}
	}
}