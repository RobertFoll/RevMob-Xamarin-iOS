using System;
using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace RevMob.iOS
{
	//Built for and tested with RevMob iOS SDK Version 8.1.0

	[BaseType (typeof (NSObject))]
	public interface RevMobAds {

		[Availability (Deprecated = Platform.iOS_8_0)]
		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Availability (Deprecated = Platform.iOS_8_0)]
		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("connectionTimeout", ArgumentSemantic.UnsafeUnretained)]
		nuint ConnectionTimeout { get; set; }

		[Export ("testingMode", ArgumentSemantic.UnsafeUnretained)]
		RevMobAdsTestingMode TestingMode { get; set; }

		[Export ("parallaxMode", ArgumentSemantic.UnsafeUnretained)]
		RevMobParallaxMode ParallaxMode { get; set; }

		[Export ("userGender", ArgumentSemantic.UnsafeUnretained)]
		RevMobUserGender UserGender { get; set; }

		[Export ("userAgeRangeMin", ArgumentSemantic.UnsafeUnretained)]
		nuint UserAgeRangeMin { get; set; }

		[Export ("userAgeRangeMax", ArgumentSemantic.UnsafeUnretained)]
		nuint UserAgeRangeMax { get; set; }

		[Export ("userBirthday", ArgumentSemantic.Retain)]
		NSDate UserBirthday { get; set; }

		[Export ("userInterests", ArgumentSemantic.Retain)]
		NSObject [] UserInterests { get; set; }

		[Export ("userPage", ArgumentSemantic.Retain)]
		string UserPage { get; set; }

		[Export ("setUserLatitude:userLongitude:userAccuracy:")]
		void SetUserLatitude (double userLatitude, double userLongitude, double userAccuracy);

		[Static, Export ("startSessionWithAppID:")]
		RevMobAds StartSessionWithAppID (string anAppId);

		[Static, Export ("startSessionWithAppID:andDelegate:")]
		RevMobAds StartSessionWithAppID (string anAppId, RevMobAdsDelegate adelegate);

		[Static, Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:")]
		RevMobAds StartSessionWithAppID (string anAppId, Action onSessionStartedHandler, Action<NSError> onSessionNotStartedHandler);

		[Static, Export ("session")]
		RevMobAds Session ();

		[Export ("printEnvironmentInformation")]
		void PrintEnvironmentInformation ();

		[Export ("showFullscreen")]
		void ShowFullscreen ();

		[Export ("showBanner")]
		void ShowBanner ();

		[Export ("hideBanner")]
		void HideBanner ();

		[Export ("showPopup")]
		void ShowPopup ();

		[Export ("openAdLinkWithDelegate:")]
		void OpenAdLinkWithDelegate (RevMobAdsDelegate adelegate);

		[Export ("fullscreen")]
		RevMobFullscreen Fullscreen ();

		[Export ("fullscreenWithPlacementId:")]
		RevMobFullscreen FullscreenWithPlacementId (string placementId);

		[Export ("bannerView")]
		RevMobBannerView BannerView ();

		[Export ("bannerViewWithPlacementId:")]
		RevMobBannerView BannerViewWithPlacementId (string placementId);

		[Export ("banner")]
		RevMobBanner Banner ();

		[Export ("bannerWithPlacementId:")]
		RevMobBanner BannerWithPlacementId (string placementId);

		[Export ("button")]
		RevMobButton Button ();

		[Export ("buttonWithPlacementId:")]
		RevMobButton ButtonWithPlacementId (string placementId);

		[Export ("buttonUnloaded")]
		RevMobButton ButtonUnloaded ();

		[Export ("buttonUnloadedWithPlacementId:")]
		RevMobButton ButtonUnloadedWithPlacementId (string placementId);

		[Export ("adLink")]
		RevMobAdLink AdLink ();

		[Export ("adLinkWithPlacementId:")]
		RevMobAdLink AdLinkWithPlacementId (string placementId);

		[Export ("popup")]
		RevMobPopup Popup ();

		[Export ("popupWithPlacementId:")]
		RevMobPopup PopupWithPlacementId (string placementId);
	}

	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	public interface RevMobAdsDelegate {

		[Export ("revmobAdDidFailWithError:")]
		[Abstract]
		void RevmobAdDidFailWithError (NSError error);

		[Export ("revmobSessionIsStarted")]
		void RevmobSessionIsStarted ();

		[Export ("revmobSessionNotStartedWithError:")]
		void RevmobSessionNotStartedWithError (NSError error);

		[Export ("revmobAdDidReceive")]
		void RevmobAdDidReceive ();

		[Export ("revmobAdDisplayed")]
		void RevmobAdDisplayed ();

		[Export ("revmobUserClickedInTheAd")]
		void RevmobUserClickedInTheAd ();

		[Export ("revmobUserClosedTheAd")]
		void RevmobUserClosedTheAd ();

		[Export ("installDidReceive")]
		void InstallDidReceive ();

		[Export ("installDidFail")]
		void InstallDidFail ();
	}

	[BaseType (typeof (NSObject))]
	public interface RevMobAdLink {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:")]
		void LoadWithSuccessHandler (Action<RevMobAdLink> onAdLoadedHandler, Action<RevMobAdLink, NSError> onAdFailedHandler);

		[Export ("openLink")]
		void OpenLink ();
	}

	[BaseType (typeof (UIView))]
	public interface RevMobBannerView : IUIWebViewDelegate {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
		void LoadWithSuccessHandler (Action<RevMobBannerView> onAdLoadedHandler, Action<RevMobBannerView, NSError> onAdFailedHandler, Action<RevMobBannerView> onClickHandler);
	}

	[BaseType (typeof (NSObject))]
	public interface RevMobBanner {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("frame", ArgumentSemantic.UnsafeUnretained)]
		CGRect Frame { get; set; }

		[Export ("supportedInterfaceOrientations", ArgumentSemantic.Retain)]
		NSObject [] SupportedInterfaceOrientations { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
		void LoadWithSuccessHandler (Action<RevMobBanner> onAdLoadedHandler, Action<RevMobBanner, NSError> onAdFailedHandler, Action<RevMobBanner> onClickHandler);

		[Export ("showAd")]
		void ShowAd ();

		[Export ("hideAd")]
		void HideAd ();
	}

	[BaseType (typeof (UIButton))]
	public interface RevMobButton {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("status")]
		RevMobButtonStatus Status { get; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
		void LoadWithSuccessHandler (Action<RevMobButton> onAdLoadedHandler, Action<RevMobButton, NSError> onAdFailedHandler, Action<RevMobButton> onClickHandler);
	}

	[BaseType (typeof (NSObject))]
	public interface RevMobFullscreen {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("supportedInterfaceOrientations", ArgumentSemantic.Retain)]
		NSObject [] SupportedInterfaceOrientations { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:")]
		void LoadWithSuccessHandler (Action<RevMobFullscreen> onAdLoadedHandler, Action<RevMobFullscreen, NSError> onAdFailedHandler);

		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:onCloseHandler:")]
		void LoadWithSuccessHandler (Action<RevMobFullscreen> onAdLoadedHandler, Action<RevMobFullscreen, NSError> onAdFailedHandler, Action onClickHandler, Action onCloseHandler);

		[Export ("showAd")]
		void ShowAd ();

		[Export ("hideAd")]
		void HideAd ();
	}

	[BaseType (typeof (NSObject))]
	public interface RevMobPopup : IUIAlertViewDelegate {

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		RevMobAdsDelegate Delegate { get; set; }

		[Export ("loadAd")]
		void LoadAd ();

		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
		void LoadWithSuccessHandler (Action<RevMobPopup> onAdLoadedHandler, Action<RevMobPopup, NSError> onAdFailedHandler, Action<RevMobPopup> onClickHandler);

		[Export ("showAd")]
		void ShowAd ();
	}
}
