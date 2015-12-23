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
using Metal;
using MapKit;
using ModelIO;
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
using AVFoundation;
using NewsstandKit;
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

		[Export ("adLinkWithPlacementId:")]
		[CompilerGenerated]
		public virtual RevMobAdLink AdLinkWithPlacementId (string placementId)
		{
			if (placementId == null)
				throw new ArgumentNullException ("placementId");
			var nsplacementId = NSString.CreateNative (placementId);
			
			RevMobAdLink ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<RevMobAdLink> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("adLinkWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobAdLink> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("adLinkWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
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
				ret =  Runtime.GetNSObject<RevMobBannerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("bannerViewWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobBannerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("bannerViewWithPlacementId:"), nsplacementId));
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
				ret =  Runtime.GetNSObject<RevMobBanner> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("bannerWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobBanner> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("bannerWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
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
				ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("buttonUnloadedWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("buttonUnloadedWithPlacementId:"), nsplacementId));
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
				ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("buttonWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("buttonWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
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
				ret =  Runtime.GetNSObject<RevMobFullscreen> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fullscreenWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobFullscreen> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("fullscreenWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("hideBanner")]
		[CompilerGenerated]
		public virtual void HideBanner ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideBanner"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideBanner"));
			}
		}
		
		[Export ("openAdLinkWithDelegate:")]
		[CompilerGenerated]
		public virtual void OpenAdLinkWithDelegate (RevMobAdsDelegate adelegate)
		{
			if (adelegate == null)
				throw new ArgumentNullException ("adelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("openAdLinkWithDelegate:"), adelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("openAdLinkWithDelegate:"), adelegate.Handle);
			}
		}
		
		[Export ("openLink")]
		[CompilerGenerated]
		public virtual void OpenLink ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("openLink"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("openLink"));
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
				ret =  Runtime.GetNSObject<RevMobPopup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("popupWithPlacementId:"), nsplacementId));
			} else {
				ret =  Runtime.GetNSObject<RevMobPopup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("popupWithPlacementId:"), nsplacementId));
			}
			NSString.ReleaseNative (nsplacementId);
			
			return ret;
		}
		
		[Export ("printEnvironmentInformation")]
		[CompilerGenerated]
		public virtual void PrintEnvironmentInformation ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("printEnvironmentInformation"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printEnvironmentInformation"));
			}
		}
		
		[Export ("showBanner")]
		[CompilerGenerated]
		public virtual void ShowBanner ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showBanner"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showBanner"));
			}
		}
		
		[Export ("showFullscreen")]
		[CompilerGenerated]
		public virtual void ShowFullscreen ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showFullscreen"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showFullscreen"));
			}
		}
		
		[Export ("showPopup")]
		[CompilerGenerated]
		public virtual void ShowPopup ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showPopup"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showPopup"));
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
			ret =  Runtime.GetNSObject<RevMobAds> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:"), nsanAppId));
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
			ret =  Runtime.GetNSObject<RevMobAds> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:andDelegate:"), nsanAppId, adelegate.Handle));
			NSString.ReleaseNative (nsanAppId);
			
			return ret;
		}
		
		[Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:")]
		[CompilerGenerated]
		public unsafe static RevMobAds StartSessionWithAppID (string anAppId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onSessionStartedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> onSessionNotStartedHandler)
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
			block_onSessionNotStartedHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, onSessionNotStartedHandler);
			
			RevMobAds ret;
			ret =  Runtime.GetNSObject<RevMobAds> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("startSessionWithAppID:withSuccessHandler:andFailHandler:"), nsanAppId, (IntPtr) block_ptr_onSessionStartedHandler, (IntPtr) block_ptr_onSessionNotStartedHandler));
			NSString.ReleaseNative (nsanAppId);
			block_ptr_onSessionStartedHandler->CleanupBlock ();
			block_ptr_onSessionNotStartedHandler->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startSessionWithAppID:withSuccessHandler:andFailHandler:url:key:")]
		[CompilerGenerated]
		public unsafe static RevMobAds StartSessionWithAppID (string anAppId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onSessionStartedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSError> onSessionNotStartedHandler, string serverUrl, int sessionKey)
		{
			if (anAppId == null)
				throw new ArgumentNullException ("anAppId");
			if (onSessionStartedHandler == null)
				throw new ArgumentNullException ("onSessionStartedHandler");
			if (onSessionNotStartedHandler == null)
				throw new ArgumentNullException ("onSessionNotStartedHandler");
			if (serverUrl == null)
				throw new ArgumentNullException ("serverUrl");
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
			block_onSessionNotStartedHandler.SetupBlock (Trampolines.SDActionArity1V1.Handler, onSessionNotStartedHandler);
			var nsserverUrl = NSString.CreateNative (serverUrl);
			
			RevMobAds ret;
			ret =  Runtime.GetNSObject<RevMobAds> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_int (class_ptr, Selector.GetHandle ("startSessionWithAppID:withSuccessHandler:andFailHandler:url:key:"), nsanAppId, (IntPtr) block_ptr_onSessionStartedHandler, (IntPtr) block_ptr_onSessionNotStartedHandler, nsserverUrl, sessionKey));
			NSString.ReleaseNative (nsanAppId);
			block_ptr_onSessionStartedHandler->CleanupBlock ();
			block_ptr_onSessionNotStartedHandler->CleanupBlock ();
			NSString.ReleaseNative (nsserverUrl);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_AdLink_var;
		[CompilerGenerated]
		public virtual RevMobAdLink AdLink {
			[Export ("adLink")]
			get {
				RevMobAdLink ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobAdLink> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("adLink")));
				} else {
					ret =  Runtime.GetNSObject<RevMobAdLink> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("adLink")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdLink_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Banner_var;
		[CompilerGenerated]
		public virtual RevMobBanner Banner {
			[Export ("banner")]
			get {
				RevMobBanner ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobBanner> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("banner")));
				} else {
					ret =  Runtime.GetNSObject<RevMobBanner> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("banner")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Banner_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BannerView_var;
		[CompilerGenerated]
		public virtual RevMobBannerView BannerView {
			[Export ("bannerView")]
			get {
				RevMobBannerView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobBannerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bannerView")));
				} else {
					ret =  Runtime.GetNSObject<RevMobBannerView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bannerView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BannerView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Button_var;
		[CompilerGenerated]
		public virtual RevMobButton Button {
			[Export ("button")]
			get {
				RevMobButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("button")));
				} else {
					ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("button")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Button_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ButtonUnloaded_var;
		[CompilerGenerated]
		public virtual RevMobButton ButtonUnloaded {
			[Export ("buttonUnloaded")]
			get {
				RevMobButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonUnloaded")));
				} else {
					ret =  Runtime.GetNSObject<RevMobButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonUnloaded")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ButtonUnloaded_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint ConnectionTimeout {
			[Export ("connectionTimeout")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("connectionTimeout"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionTimeout"));
				}
			}
			
			[Export ("setConnectionTimeout:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setConnectionTimeout:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setConnectionTimeout:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public RevMobAdsDelegate Delegate {
			get {
				return WeakDelegate as /**/RevMobAdsDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Fullscreen_var;
		[CompilerGenerated]
		public virtual RevMobFullscreen Fullscreen {
			[Export ("fullscreen")]
			get {
				RevMobFullscreen ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobFullscreen> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fullscreen")));
				} else {
					ret =  Runtime.GetNSObject<RevMobFullscreen> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fullscreen")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Fullscreen_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::RevMobParallaxMode ParallaxMode {
			[Export ("parallaxMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (global::RevMobParallaxMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("parallaxMode"));
				} else {
					return (global::RevMobParallaxMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parallaxMode"));
				}
			}
			
			[Export ("setParallaxMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setParallaxMode:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setParallaxMode:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Popup_var;
		[CompilerGenerated]
		public virtual RevMobPopup Popup {
			[Export ("popup")]
			get {
				RevMobPopup ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<RevMobPopup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("popup")));
				} else {
					ret =  Runtime.GetNSObject<RevMobPopup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popup")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Popup_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_Session_var_static;
		[CompilerGenerated]
		public static RevMobAds Session {
			[Export ("session")]
			get {
				RevMobAds ret;
				ret =  Runtime.GetNSObject<RevMobAds> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("session")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Session_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::RevMobAdsTestingMode TestingMode {
			[Export ("testingMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (global::RevMobAdsTestingMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("testingMode"));
				} else {
					return (global::RevMobAdsTestingMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("testingMode"));
				}
			}
			
			[Export ("setTestingMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTestingMode:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTestingMode:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint UserAgeRangeMax {
			[Export ("userAgeRangeMax")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("userAgeRangeMax"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userAgeRangeMax"));
				}
			}
			
			[Export ("setUserAgeRangeMax:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setUserAgeRangeMax:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setUserAgeRangeMax:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint UserAgeRangeMin {
			[Export ("userAgeRangeMin")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("userAgeRangeMin"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userAgeRangeMin"));
				}
			}
			
			[Export ("setUserAgeRangeMin:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setUserAgeRangeMin:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setUserAgeRangeMin:"), value);
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
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userBirthday")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userBirthday")));
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
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserBirthday:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserBirthday:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserBirthday_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::RevMobUserGender UserGender {
			[Export ("userGender", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (global::RevMobUserGender) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("userGender"));
				} else {
					return (global::RevMobUserGender) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGender"));
				}
			}
			
			[Export ("setUserGender:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUserGender:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUserGender:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserInterests_var;
		[CompilerGenerated]
		public virtual NSString[] UserInterests {
			[Export ("userInterests", ArgumentSemantic.Retain)]
			get {
				NSString[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterests")));
				} else {
					ret = NSArray.ArrayFromHandle<NSString>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userInterests")));
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
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterests:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserInterests:"), nsa_value.Handle);
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
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userPage")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userPage")));
				}
			}
			
			[Export ("setUserPage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserPage:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserPage:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
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
				__mt_AdLink_var = null;
				__mt_Banner_var = null;
				__mt_BannerView_var = null;
				__mt_Button_var = null;
				__mt_ButtonUnloaded_var = null;
				__mt_Fullscreen_var = null;
				__mt_Popup_var = null;
				__mt_UserBirthday_var = null;
				__mt_UserInterests_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class RevMobAds */
}
