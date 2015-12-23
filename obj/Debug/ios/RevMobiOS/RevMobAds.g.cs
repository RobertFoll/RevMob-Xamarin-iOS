//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace RevMob.iOS {
	[Register("RevMobAds", true)]
	public unsafe partial class RevMobAds : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RevMobAds");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RevMobAds () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RevMobAds (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RevMobAds (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adLink")]
		[CompilerGenerated]
		public virtual RevMobAdLink AdLink ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobAdLink> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adLink")));
			} else {
				return  Runtime.GetNSObject<RevMobAdLink> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adLink")));
			}
		}
		
		[Export ("adLinkWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobAdLink AdLinkWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobAdLink ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobAdLink> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("adLinkWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobAdLink> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("adLinkWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("banner")]
		[CompilerGenerated]
		public virtual RevMobBanner Banner ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("banner")));
			} else {
				return  Runtime.GetNSObject<RevMobBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("banner")));
			}
		}
		
		[Export ("bannerView")]
		[CompilerGenerated]
		public virtual RevMobBannerView BannerView ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobBannerView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bannerView")));
			} else {
				return  Runtime.GetNSObject<RevMobBannerView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bannerView")));
			}
		}
		
		[Export ("bannerViewWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobBannerView BannerViewWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobBannerView ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobBannerView> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("bannerViewWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobBannerView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("bannerViewWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("bannerWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobBanner BannerWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobBanner ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("bannerWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobBanner> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("bannerWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("button")]
		[CompilerGenerated]
		public virtual RevMobButton Button ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("button")));
			} else {
				return  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("button")));
			}
		}
		
		[Export ("buttonUnloaded")]
		[CompilerGenerated]
		public virtual RevMobButton ButtonUnloaded ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonUnloaded")));
			} else {
				return  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonUnloaded")));
			}
		}
		
		[Export ("buttonUnloadedWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobButton ButtonUnloadedWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobButton ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("buttonUnloadedWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("buttonUnloadedWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("buttonWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobButton ButtonWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobButton ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("buttonWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobButton> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("buttonWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("fullscreen")]
		[CompilerGenerated]
		public virtual RevMobFullscreen Fullscreen ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobFullscreen> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fullscreen")));
			} else {
				return  Runtime.GetNSObject<RevMobFullscreen> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullscreen")));
			}
		}
		
		[Export ("fullscreenWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobFullscreen FullscreenWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobFullscreen ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobFullscreen> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fullscreenWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobFullscreen> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fullscreenWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("hideBanner")]
		[CompilerGenerated]
		public virtual void HideBanner ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideBanner"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideBanner"));
			}
		}
		
		[Export ("openAdLinkWithDelegate:")]
		[CompilerGenerated]
		public virtual void OpenAdLinkWithDelegate (RevMobAdsDelegate adelegate)
		{
			if (adelegate == null)
				throw new ArgumentNullException ("adelegate");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("openAdLinkWithDelegate:"), adelegate.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("openAdLinkWithDelegate:"), adelegate.Handle);
			}
		}
		
		[Export ("popup")]
		[CompilerGenerated]
		public virtual RevMobPopup Popup ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<RevMobPopup> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("popup")));
			} else {
				return  Runtime.GetNSObject<RevMobPopup> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popup")));
			}
		}
		
		[Export ("popupWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobPopup PopupWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobPopup ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobPopup> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("popupWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobPopup> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("popupWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("printEnvironmentInformation")]
		[CompilerGenerated]
		public virtual void PrintEnvironmentInformation ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("printEnvironmentInformation"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printEnvironmentInformation"));
			}
		}
		
		[Export ("session")]
		[CompilerGenerated]
		public static RevMobAds Session ()
		{
			return  Runtime.GetNSObject<RevMobAds> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("session")));
		}
		
		[Export ("setUserLatitude:userLongitude:userAccuracy:")]
		[CompilerGenerated]
		public virtual void SetUserLatitude (global::System.Double userLatitude, global::System.Double userLongitude, global::System.Double userAccuracy)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_Double_Double_Double (this.Handle, Selector.GetHandle ("setUserLatitude:userLongitude:userAccuracy:"), userLatitude, userLongitude, userAccuracy);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_Double_Double_Double (this.SuperHandle, Selector.GetHandle ("setUserLatitude:userLongitude:userAccuracy:"), userLatitude, userLongitude, userAccuracy);
			}
		}
		
		[Export ("showBanner")]
		[CompilerGenerated]
		public virtual void ShowBanner ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showBanner"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showBanner"));
			}
		}
		
		[Export ("showFullscreen")]
		[CompilerGenerated]
		public virtual void ShowFullscreen ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showFullscreen"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showFullscreen"));
			}
		}
		
		[Export ("showPopup")]
		[CompilerGenerated]
		public virtual void ShowPopup ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showPopup"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPopup"));
			}
		}
		
		[Export ("startSessionWithAppID:")]
		[CompilerGenerated]
		public static RevMobAds StartSessionWithAppID (string anAppId)
		{
			if (anAppId == null)
				throw new ArgumentNullException ("anAppId");
			var nsanAppId = NSString.CreateNative (anAppId);
			
			RevMobAds ret;
			ret =  Runtime.GetNSObject<RevMobAds> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:"), nsanAppId));
			NSString.ReleaseNative (nsanAppId);
			
			return ret;
		}
		
		[Export ("startSessionWithAppID:andDelegate:")]
		[CompilerGenerated]
		public static RevMobAds StartSessionWithAppID (string anAppId, RevMobAdsDelegate adelegate)
		{
			if (anAppId == null)
				throw new ArgumentNullException ("anAppId");
			if (adelegate == null)
				throw new ArgumentNullException ("adelegate");
			var nsanAppId = NSString.CreateNative (anAppId);
			
			RevMobAds ret;
			ret =  Runtime.GetNSObject<RevMobAds> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:andDelegate:"), nsanAppId, adelegate.Handle));
			NSString.ReleaseNative (nsanAppId);
			
			return ret;
		}
		
		[Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:")]
		[CompilerGenerated]
		public unsafe static RevMobAds StartSessionWithAppID (string anAppId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onSessionStartedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> onSessionNotStartedHandler)
		{
			if (anAppId == null)
				throw new ArgumentNullException ("anAppId");
			if (onSessionStartedHandler == null)
				throw new ArgumentNullException ("onSessionStartedHandler");
			if (onSessionNotStartedHandler == null)
				throw new ArgumentNullException ("onSessionNotStartedHandler");
			var nsanAppId = NSString.CreateNative (anAppId);
			BlockLiteral *block_ptr_onSessionStartedHandler;
			BlockLiteral block_onSessionStartedHandler;
			block_onSessionStartedHandler = new BlockLiteral ();
			block_ptr_onSessionStartedHandler = &block_onSessionStartedHandler;
			block_onSessionStartedHandler.SetupBlock (Trampolines.SDAction.Handler, onSessionStartedHandler);
			BlockLiteral *block_ptr_onSessionNotStartedHandler;
			BlockLiteral block_onSessionNotStartedHandler;
			block_onSessionNotStartedHandler = new BlockLiteral ();
			block_ptr_onSessionNotStartedHandler = &block_onSessionNotStartedHandler;
			block_onSessionNotStartedHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, onSessionNotStartedHandler);
			
			RevMobAds ret;
			ret =  Runtime.GetNSObject<RevMobAds> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:withSuccessHandler:andFailHandler:"), nsanAppId, (IntPtr) block_ptr_onSessionStartedHandler, (IntPtr) block_ptr_onSessionNotStartedHandler));
			NSString.ReleaseNative (nsanAppId);
			block_ptr_onSessionStartedHandler->CleanupBlock ();
			block_ptr_onSessionNotStartedHandler->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint ConnectionTimeout {
			[Export ("connectionTimeout", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("connectionTimeout"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionTimeout"));
				}
			}
			
			[Export ("setConnectionTimeout:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setConnectionTimeout:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setConnectionTimeout:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		[Availability (Deprecated = Platform.iOS_8_0)]
		public RevMobAdsDelegate Delegate {
			[Availability (Deprecated = Platform.iOS_8_0)]
			get {
				return WeakDelegate as /**/RevMobAdsDelegate;
			}
			[Availability (Deprecated = Platform.iOS_8_0)]
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual RevMobParallaxMode ParallaxMode {
			[Export ("parallaxMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (RevMobParallaxMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("parallaxMode"));
				} else {
					return (RevMobParallaxMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parallaxMode"));
				}
			}
			
			[Export ("setParallaxMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setParallaxMode:"), (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setParallaxMode:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual RevMobAdsTestingMode TestingMode {
			[Export ("testingMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (RevMobAdsTestingMode) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("testingMode"));
				} else {
					return (RevMobAdsTestingMode) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testingMode"));
				}
			}
			
			[Export ("setTestingMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTestingMode:"), (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTestingMode:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint UserAgeRangeMax {
			[Export ("userAgeRangeMax", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("userAgeRangeMax"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userAgeRangeMax"));
				}
			}
			
			[Export ("setUserAgeRangeMax:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setUserAgeRangeMax:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setUserAgeRangeMax:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint UserAgeRangeMin {
			[Export ("userAgeRangeMin", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("userAgeRangeMin"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userAgeRangeMin"));
				}
			}
			
			[Export ("setUserAgeRangeMin:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setUserAgeRangeMin:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setUserAgeRangeMin:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserBirthday_var;
		[CompilerGenerated]
		public virtual NSDate UserBirthday {
			[Export ("userBirthday", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBirthday")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBirthday")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserBirthday_var = ret;
				return ret;
			}
			
			[Export ("setUserBirthday:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBirthday:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBirthday:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserBirthday_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual RevMobUserGender UserGender {
			[Export ("userGender", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (RevMobUserGender) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("userGender"));
				} else {
					return (RevMobUserGender) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGender"));
				}
			}
			
			[Export ("setUserGender:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUserGender:"), (UInt32)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUserGender:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserInterests_var;
		[CompilerGenerated]
		public virtual NSObject[] UserInterests {
			[Export ("userInterests", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterests")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userInterests")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInterests_var = ret;
				return ret;
			}
			
			[Export ("setUserInterests:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterests:"), nsa_value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserInterests:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_UserInterests_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string UserPage {
			[Export ("userPage", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userPage")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userPage")));
				}
			}
			
			[Export ("setUserPage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserPage:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserPage:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		[Availability (Deprecated = Platform.iOS_8_0)]
		public virtual NSObject WeakDelegate {
			[Availability (Deprecated = Platform.iOS_8_0)]
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Availability (Deprecated = Platform.iOS_8_0)]
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UserBirthday_var = null;
				__mt_UserInterests_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class RevMobAds */
}
