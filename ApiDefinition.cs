using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
//using RevMobAds.iOS;
using UIKit;

namespace RevMob.iOS
{

// @protocol RevMobAdsDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface RevMobAdsDelegate
{
	// @optional -(void)revmobSessionIsStarted;
	[Export ("revmobSessionIsStarted")]
	void RevmobSessionIsStarted ();

	// @optional -(void)revmobSessionNotStartedWithError:(NSError *)error;
	[Export ("revmobSessionNotStartedWithError:")]
	void RevmobSessionNotStartedWithError (NSError error);

	// @optional -(void)revmobAdDidReceive;
	[Export ("revmobAdDidReceive")]
	void RevmobAdDidReceive ();

	// @optional -(void)revmobAdDidFailWithError:(NSError *)error;
	[Export ("revmobAdDidFailWithError:")]
	void RevmobAdDidFailWithError (NSError error);

	// @optional -(void)revmobAdDisplayed;
	[Export ("revmobAdDisplayed")]
	void RevmobAdDisplayed ();

	// @optional -(void)revmobUserClickedInTheAd;
	[Export ("revmobUserClickedInTheAd")]
	void RevmobUserClickedInTheAd ();

	// @optional -(void)revmobUserClosedTheAd;
	[Export ("revmobUserClosedTheAd")]
	void RevmobUserClosedTheAd ();

	// @optional -(void)revmobVideoDidLoad;
	[Export ("revmobVideoDidLoad")]
	void RevmobVideoDidLoad ();

	// @optional -(void)revmobVideoNotCompletelyLoaded;
	[Export ("revmobVideoNotCompletelyLoaded")]
	void RevmobVideoNotCompletelyLoaded ();

	// @optional -(void)revmobVideoDidStart;
	[Export ("revmobVideoDidStart")]
	void RevmobVideoDidStart ();

	// @optional -(void)revmobVideoDidFinish;
	[Export ("revmobVideoDidFinish")]
	void RevmobVideoDidFinish ();

	// @optional -(void)revmobRewardedVideoDidLoad;
	[Export ("revmobRewardedVideoDidLoad")]
	void RevmobRewardedVideoDidLoad ();

	// @optional -(void)revmobRewardedVideoNotCompletelyLoaded;
	[Export ("revmobRewardedVideoNotCompletelyLoaded")]
	void RevmobRewardedVideoNotCompletelyLoaded ();

	// @optional -(void)revmobRewardedVideoDidStart;
	[Export ("revmobRewardedVideoDidStart")]
	void RevmobRewardedVideoDidStart ();

	// @optional -(void)revmobRewardedVideoDidFinish;
	[Export ("revmobRewardedVideoDidFinish")]
	void RevmobRewardedVideoDidFinish ();

	// @optional -(void)revmobRewardedVideoComplete;
	[Export ("revmobRewardedVideoComplete")]
	void RevmobRewardedVideoComplete ();

	// @optional -(void)revmobRewardedPreRollDisplayed;
	[Export ("revmobRewardedPreRollDisplayed")]
	void RevmobRewardedPreRollDisplayed ();

	// @optional -(void)installDidReceive;
	[Export ("installDidReceive")]
	void InstallDidReceive ();

	// @optional -(void)installDidFail;
	[Export ("installDidFail")]
	void InstallDidFail ();
}

// typedef void (^RevMobAdLinkSuccessfullHandler)(RevMobAdLink *);
delegate void RevMobAdLinkSuccessfullHandler (RevMobAdLink arg0);

// typedef void (^RevMobAdLinkFailureHandler)(RevMobAdLink *, NSError *);
delegate void RevMobAdLinkFailureHandler (RevMobAdLink arg0, NSError arg1);

// @interface RevMobAdLink : NSObject
[BaseType (typeof(NSObject))]
interface RevMobAdLink
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(RevMobAdLinkSuccessfullHandler)onAdLoadedHandler andLoadFailHandler:(RevMobAdLinkFailureHandler)onAdFailedHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:")]
	void LoadWithSuccessHandler (RevMobAdLinkSuccessfullHandler onAdLoadedHandler, RevMobAdLinkFailureHandler onAdFailedHandler);

	// -(void)openLink;
	[Export ("openLink")]
	void OpenLink ();
}

// typedef void (^RevMobBannerViewSuccessfullHandler)(RevMobBannerView *);
delegate void RevMobBannerViewSuccessfullHandler (RevMobBannerView arg0);

// typedef void (^RevMobBannerViewFailureHandler)(RevMobBannerView *, NSError *);
delegate void RevMobBannerViewFailureHandler (RevMobBannerView arg0, NSError arg1);

// typedef void (^RevMobBannerViewOnclickHandler)(RevMobBannerView *);
delegate void RevMobBannerViewOnclickHandler (RevMobBannerView arg0);

// @interface RevMobBannerView : UIView <UIWebViewDelegate>
[BaseType (typeof(UIView))]
interface RevMobBannerView : IUIWebViewDelegate
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(RevMobBannerViewSuccessfullHandler)onAdLoadedHandler andLoadFailHandler:(RevMobBannerViewFailureHandler)onAdFailedHandler onClickHandler:(RevMobBannerViewOnclickHandler)onClickHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
	void LoadWithSuccessHandler (RevMobBannerViewSuccessfullHandler onAdLoadedHandler, RevMobBannerViewFailureHandler onAdFailedHandler, RevMobBannerViewOnclickHandler onClickHandler);

	// -(void)showAd;
	[Export ("showAd")]
	void ShowAd ();

	// -(void)showAd:(CGFloat)x y:(CGFloat)y width:(CGFloat)w height:(CGFloat)h view:(UIView *)v;
	[Export ("showAd:y:width:height:view:")]
	void ShowAd (nfloat x, nfloat y, nfloat w, nfloat h, UIView v);

	// -(void)showAd:(CGFloat)x y:(CGFloat)y width:(CGFloat)w height:(CGFloat)h;
	[Export ("showAd:y:width:height:")]
	void ShowAd (nfloat x, nfloat y, nfloat w, nfloat h);
}

// typedef void (^RevMobBannerSuccessfullHandler)(RevMobBanner *);
delegate void RevMobBannerSuccessfullHandler (RevMobBanner arg0);

// typedef void (^RevMobBannerFailureHandler)(RevMobBanner *, NSError *);
delegate void RevMobBannerFailureHandler (RevMobBanner arg0, NSError arg1);

// typedef void (^RevMobBannerOnClickHandler)(RevMobBanner *);
delegate void RevMobBannerOnClickHandler (RevMobBanner arg0);

// @interface RevMobBanner : NSObject
[BaseType (typeof(NSObject))]
interface RevMobBanner
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) CGRect frame;
	[Export ("frame", ArgumentSemantic.Assign)]
	CGRect Frame { get; set; }

	// @property (nonatomic, strong) NSArray * supportedInterfaceOrientations;
	[Export ("supportedInterfaceOrientations", ArgumentSemantic.Strong)]
	NSObject[] SupportedInterfaceOrientations { get; set; }

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(RevMobBannerSuccessfullHandler)onAdLoadedHandler andLoadFailHandler:(RevMobBannerFailureHandler)onAdFailedHandler onClickHandler:(RevMobBannerOnClickHandler)onClickHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
	void LoadWithSuccessHandler (RevMobBannerSuccessfullHandler onAdLoadedHandler, RevMobBannerFailureHandler onAdFailedHandler, RevMobBannerOnClickHandler onClickHandler);

	// -(void)showAd;
	[Export ("showAd")]
	void ShowAd ();

	// -(void)hideAd;
	[Export ("hideAd")]
	void HideAd ();
}

// typedef void (^RevMobButtonSuccessfullHandler)(RevMobButton *);
delegate void RevMobButtonSuccessfullHandler (RevMobButton arg0);

// typedef void (^RevMobButtonFailureHandler)(RevMobButton *, NSError *);
delegate void RevMobButtonFailureHandler (RevMobButton arg0, NSError arg1);

// typedef void (^RevMobButtonOnclickHandler)(RevMobButton *);
delegate void RevMobButtonOnclickHandler (RevMobButton arg0);

// @interface RevMobButton : UIButton
[BaseType (typeof(UIButton))]
interface RevMobButton
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, atomic) RevMobButtonStatus status;
	[Export ("status")]
	RevMobButtonStatus Status { get; }

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(RevMobButtonSuccessfullHandler)onAdLoadedHandler andLoadFailHandler:(RevMobButtonFailureHandler)onAdFailedHandler onClickHandler:(RevMobButtonOnclickHandler)onClickHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
	void LoadWithSuccessHandler (RevMobButtonSuccessfullHandler onAdLoadedHandler, RevMobButtonFailureHandler onAdFailedHandler, RevMobButtonOnclickHandler onClickHandler);
}

// @interface RevMobFullscreen : NSObject
[BaseType (typeof(NSObject))]
interface RevMobFullscreen
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, strong) NSArray * supportedInterfaceOrientations;
	[Export ("supportedInterfaceOrientations", ArgumentSemantic.Strong)]
	NSObject[] SupportedInterfaceOrientations { get; set; }

	// -(void)loadVideo;
	[Export ("loadVideo")]
	void LoadVideo ();

	// -(void)loadRewardedVideo;
	[Export ("loadRewardedVideo")]
	void LoadRewardedVideo ();

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(void (^)(RevMobFullscreen *))onAdLoadedHandler andLoadFailHandler:(void (^)(RevMobFullscreen *, NSError *))onAdFailedHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:")]
	void LoadWithSuccessHandler (Action<RevMobFullscreen> onAdLoadedHandler, Action<RevMobFullscreen, NSError> onAdFailedHandler);

	// -(void)loadWithSuccessHandler:(void (^)(RevMobFullscreen *))onAdLoadedHandler andLoadFailHandler:(void (^)(RevMobFullscreen *, NSError *))onAdFailedHandler onClickHandler:(void (^)())onClickHandler onCloseHandler:(void (^)())onCloseHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:onCloseHandler:")]
	void LoadWithSuccessHandler (Action<RevMobFullscreen> onAdLoadedHandler, Action<RevMobFullscreen, NSError> onAdFailedHandler, Action onClickHandler, Action onCloseHandler);

	// -(void)showAd;
	[Export ("showAd")]
	void ShowAd ();

	// -(void)showVideo;
	[Export ("showVideo")]
	void ShowVideo ();

	// -(void)showRewardedVideo;
	[Export ("showRewardedVideo")]
	void ShowRewardedVideo ();

	// -(void)hideAd;
	[Export ("hideAd")]
	void HideAd ();
}

// typedef void (^RevMobPopupSuccessfullHandler)(RevMobPopup *);
delegate void RevMobPopupSuccessfullHandler (RevMobPopup arg0);

// typedef void (^RevMobPopupFailureHandler)(RevMobPopup *, NSError *);
delegate void RevMobPopupFailureHandler (RevMobPopup arg0, NSError arg1);

// typedef void (^RevMobPopupOnClickHandler)(RevMobPopup *);
delegate void RevMobPopupOnClickHandler (RevMobPopup arg0);

// @interface RevMobPopup : NSObject <UIAlertViewDelegate>
[BaseType (typeof(NSObject))]
interface RevMobPopup : IUIAlertViewDelegate
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// -(void)loadAd;
	[Export ("loadAd")]
	void LoadAd ();

	// -(void)loadWithSuccessHandler:(RevMobPopupSuccessfullHandler)onAdLoadedHandler andLoadFailHandler:(RevMobPopupFailureHandler)onAdFailedHandler onClickHandler:(RevMobPopupOnClickHandler)onClickHandler;
	[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
	void LoadWithSuccessHandler (RevMobPopupSuccessfullHandler onAdLoadedHandler, RevMobPopupFailureHandler onAdFailedHandler, RevMobPopupOnClickHandler onClickHandler);

	// -(void)showAd;
	[Export ("showAd")]
	void ShowAd ();
}

// @interface RevMobAds : NSObject
[BaseType (typeof(NSObject))]
interface RevMobAds
{
	[Wrap ("WeakDelegate")]
	RevMobAdsDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<RevMobAdsDelegate> delegate __attribute__((deprecated("")));
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) NSUInteger connectionTimeout;
	[Export ("connectionTimeout")]
	nuint ConnectionTimeout { get; set; }

	// @property (assign, nonatomic) RevMobAdsTestingMode testingMode;
	[Export ("testingMode", ArgumentSemantic.Assign)]
	RevMobAdsTestingMode TestingMode { get; set; }

	// @property (assign, nonatomic) RevMobParallaxMode parallaxMode;
	[Export ("parallaxMode", ArgumentSemantic.Assign)]
	RevMobParallaxMode ParallaxMode { get; set; }

	// @property (assign, nonatomic) RevMobUserGender userGender;
	[Export ("userGender", ArgumentSemantic.Assign)]
	RevMobUserGender UserGender { get; set; }

	// @property (assign, nonatomic) NSUInteger userAgeRangeMin;
	[Export ("userAgeRangeMin")]
	nuint UserAgeRangeMin { get; set; }

	// @property (assign, nonatomic) NSUInteger userAgeRangeMax;
	[Export ("userAgeRangeMax")]
	nuint UserAgeRangeMax { get; set; }

	// @property (nonatomic, strong) NSDate * userBirthday;
	[Export ("userBirthday", ArgumentSemantic.Strong)]
	NSDate UserBirthday { get; set; }

	// @property (nonatomic, strong) NSArray * userInterests;
	[Export ("userInterests", ArgumentSemantic.Strong)]
	NSString[] UserInterests { get; set; }

	// @property (nonatomic, strong) NSString * userPage;
	[Export ("userPage", ArgumentSemantic.Strong)]
	string UserPage { get; set; }

	// +(RevMobAds *)startSessionWithAppID:(NSString *)anAppId;
	[Static]
	[Export ("startSessionWithAppID:")]
	RevMobAds StartSessionWithAppID (string anAppId);

	// +(RevMobAds *)startSessionWithAppID:(NSString *)anAppId andDelegate:(id<RevMobAdsDelegate>)adelegate;
	[Static]
	[Export ("startSessionWithAppID:andDelegate:")]
	RevMobAds StartSessionWithAppID (string anAppId, RevMobAdsDelegate adelegate);

	// +(RevMobAds *)startSessionWithAppID:(NSString *)anAppId withSuccessHandler:(void (^)())onSessionStartedHandler andFailHandler:(void (^)(NSError *))onSessionNotStartedHandler;
	[Static]
	[Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:")]
	RevMobAds StartSessionWithAppID (string anAppId, Action onSessionStartedHandler, Action<NSError> onSessionNotStartedHandler);

	// +(RevMobAds *)startSessionWithAppID:(NSString *)anAppId withSuccessHandler:(void (^)())onSessionStartedHandler andFailHandler:(void (^)(NSError *))onSessionNotStartedHandler url:(NSString *)serverUrl key:(int)sessionKey;
	[Static]
	[Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:url:key:")]
	RevMobAds StartSessionWithAppID (string anAppId, Action onSessionStartedHandler, Action<NSError> onSessionNotStartedHandler, string serverUrl, int sessionKey);

	// +(RevMobAds *)session;
	[Static]
	[Export ("session")]
	RevMobAds Session { get; }

	// -(void)printEnvironmentInformation;
	[Export ("printEnvironmentInformation")]
	void PrintEnvironmentInformation ();

	// -(void)showFullscreen;
	[Export ("showFullscreen")]
	void ShowFullscreen ();

	// -(void)showBanner;
	[Export ("showBanner")]
	void ShowBanner ();

	// -(void)hideBanner;
	[Export ("hideBanner")]
	void HideBanner ();

	// -(void)showPopup;
	[Export ("showPopup")]
	void ShowPopup ();

	// -(void)openAdLinkWithDelegate:(id<RevMobAdsDelegate>)adelegate;
	[Export ("openAdLinkWithDelegate:")]
	void OpenAdLinkWithDelegate (RevMobAdsDelegate adelegate);

	// -(RevMobFullscreen *)fullscreen;
	[Export ("fullscreen")]
	RevMobFullscreen Fullscreen { get; }

	// -(RevMobFullscreen *)fullscreenWithPlacementId:(NSString *)placementId;
	[Export ("fullscreenWithPlacementId:")]
	RevMobFullscreen FullscreenWithPlacementId (string placementId);

	// -(RevMobBannerView *)bannerView;
	[Export ("bannerView")]
	RevMobBannerView BannerView { get; }

	// -(RevMobBannerView *)bannerViewWithPlacementId:(NSString *)placementId;
	[Export ("bannerViewWithPlacementId:")]
	RevMobBannerView BannerViewWithPlacementId (string placementId);

	// -(RevMobBanner *)banner;
	[Export ("banner")]
	RevMobBanner Banner { get; }

	// -(RevMobBanner *)bannerWithPlacementId:(NSString *)placementId;
	[Export ("bannerWithPlacementId:")]
	RevMobBanner BannerWithPlacementId (string placementId);

	// -(RevMobButton *)button;
	[Export ("button")]
	RevMobButton Button { get; }

	// -(RevMobButton *)buttonWithPlacementId:(NSString *)placementId;
	[Export ("buttonWithPlacementId:")]
	RevMobButton ButtonWithPlacementId (string placementId);

	// -(RevMobButton *)buttonUnloaded;
	[Export ("buttonUnloaded")]
	RevMobButton ButtonUnloaded { get; }

	// -(RevMobButton *)buttonUnloadedWithPlacementId:(NSString *)placementId;
	[Export ("buttonUnloadedWithPlacementId:")]
	RevMobButton ButtonUnloadedWithPlacementId (string placementId);

	// -(RevMobAdLink *)adLink;
	[Export ("adLink")]
	RevMobAdLink AdLink { get; }

	// -(RevMobAdLink *)adLinkWithPlacementId:(NSString *)placementId;
	[Export ("adLinkWithPlacementId:")]
	RevMobAdLink AdLinkWithPlacementId (string placementId);

	// -(RevMobPopup *)popup;
	[Export ("popup")]
	RevMobPopup Popup { get; }

	// -(void)openLink;
	[Export ("openLink")]
	void OpenLink ();

	// -(RevMobPopup *)popupWithPlacementId:(NSString *)placementId;
	[Export ("popupWithPlacementId:")]
	RevMobPopup PopupWithPlacementId (string placementId);
}
}
