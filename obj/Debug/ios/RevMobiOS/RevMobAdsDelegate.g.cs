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
	[Protocol (Name = "RevMobAdsDelegate", WrapperType = typeof (RevMobAdsDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobSessionIsStarted", Selector = "revmobSessionIsStarted")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobSessionNotStartedWithError", Selector = "revmobSessionNotStartedWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobAdDidReceive", Selector = "revmobAdDidReceive")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobAdDidFailWithError", Selector = "revmobAdDidFailWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobAdDisplayed", Selector = "revmobAdDisplayed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobUserClickedInTheAd", Selector = "revmobUserClickedInTheAd")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobUserClosedTheAd", Selector = "revmobUserClosedTheAd")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobVideoDidLoad", Selector = "revmobVideoDidLoad")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobVideoNotCompletelyLoaded", Selector = "revmobVideoNotCompletelyLoaded")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobVideoDidStart", Selector = "revmobVideoDidStart")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobVideoDidFinish", Selector = "revmobVideoDidFinish")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedVideoDidLoad", Selector = "revmobRewardedVideoDidLoad")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedVideoNotCompletelyLoaded", Selector = "revmobRewardedVideoNotCompletelyLoaded")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedVideoDidStart", Selector = "revmobRewardedVideoDidStart")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedVideoDidFinish", Selector = "revmobRewardedVideoDidFinish")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedVideoComplete", Selector = "revmobRewardedVideoComplete")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RevmobRewardedPreRollDisplayed", Selector = "revmobRewardedPreRollDisplayed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InstallDidReceive", Selector = "installDidReceive")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InstallDidFail", Selector = "installDidFail")]
	public interface IRevMobAdsDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class RevMobAdsDelegate_Extensions {
		[CompilerGenerated]
		public static void RevmobSessionIsStarted (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobSessionIsStarted"));
		}
		
		[CompilerGenerated]
		public static void RevmobSessionNotStartedWithError (this IRevMobAdsDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("revmobSessionNotStartedWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void RevmobAdDidReceive (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobAdDidReceive"));
		}
		
		[CompilerGenerated]
		public static void RevmobAdDidFailWithError (this IRevMobAdsDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("revmobAdDidFailWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void RevmobAdDisplayed (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobAdDisplayed"));
		}
		
		[CompilerGenerated]
		public static void RevmobUserClickedInTheAd (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobUserClickedInTheAd"));
		}
		
		[CompilerGenerated]
		public static void RevmobUserClosedTheAd (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobUserClosedTheAd"));
		}
		
		[CompilerGenerated]
		public static void RevmobVideoDidLoad (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobVideoDidLoad"));
		}
		
		[CompilerGenerated]
		public static void RevmobVideoNotCompletelyLoaded (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobVideoNotCompletelyLoaded"));
		}
		
		[CompilerGenerated]
		public static void RevmobVideoDidStart (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobVideoDidStart"));
		}
		
		[CompilerGenerated]
		public static void RevmobVideoDidFinish (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobVideoDidFinish"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedVideoDidLoad (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedVideoDidLoad"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedVideoNotCompletelyLoaded (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedVideoNotCompletelyLoaded"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedVideoDidStart (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedVideoDidStart"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedVideoDidFinish (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedVideoDidFinish"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedVideoComplete (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedVideoComplete"));
		}
		
		[CompilerGenerated]
		public static void RevmobRewardedPreRollDisplayed (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobRewardedPreRollDisplayed"));
		}
		
		[CompilerGenerated]
		public static void InstallDidReceive (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("installDidReceive"));
		}
		
		[CompilerGenerated]
		public static void InstallDidFail (this IRevMobAdsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("installDidFail"));
		}
		
	}
	
	internal sealed class RevMobAdsDelegateWrapper : BaseWrapper, IRevMobAdsDelegate {
		public RevMobAdsDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public RevMobAdsDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace RevMob.iOS {
	[Protocol]
	[Register("RevMobAdsDelegate", false)]
	[Model]
	public unsafe partial class RevMobAdsDelegate : NSObject, IRevMobAdsDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RevMobAdsDelegate () : base (NSObjectFlag.Empty)
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
		protected RevMobAdsDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RevMobAdsDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("installDidFail")]
		[CompilerGenerated]
		public virtual void InstallDidFail ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("installDidReceive")]
		[CompilerGenerated]
		public virtual void InstallDidReceive ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobAdDidFailWithError:")]
		[CompilerGenerated]
		public virtual void RevmobAdDidFailWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobAdDidReceive")]
		[CompilerGenerated]
		public virtual void RevmobAdDidReceive ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobAdDisplayed")]
		[CompilerGenerated]
		public virtual void RevmobAdDisplayed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedPreRollDisplayed")]
		[CompilerGenerated]
		public virtual void RevmobRewardedPreRollDisplayed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedVideoComplete")]
		[CompilerGenerated]
		public virtual void RevmobRewardedVideoComplete ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedVideoDidFinish")]
		[CompilerGenerated]
		public virtual void RevmobRewardedVideoDidFinish ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedVideoDidLoad")]
		[CompilerGenerated]
		public virtual void RevmobRewardedVideoDidLoad ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedVideoDidStart")]
		[CompilerGenerated]
		public virtual void RevmobRewardedVideoDidStart ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobRewardedVideoNotCompletelyLoaded")]
		[CompilerGenerated]
		public virtual void RevmobRewardedVideoNotCompletelyLoaded ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobSessionIsStarted")]
		[CompilerGenerated]
		public virtual void RevmobSessionIsStarted ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobSessionNotStartedWithError:")]
		[CompilerGenerated]
		public virtual void RevmobSessionNotStartedWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobUserClickedInTheAd")]
		[CompilerGenerated]
		public virtual void RevmobUserClickedInTheAd ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobUserClosedTheAd")]
		[CompilerGenerated]
		public virtual void RevmobUserClosedTheAd ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobVideoDidFinish")]
		[CompilerGenerated]
		public virtual void RevmobVideoDidFinish ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobVideoDidLoad")]
		[CompilerGenerated]
		public virtual void RevmobVideoDidLoad ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobVideoDidStart")]
		[CompilerGenerated]
		public virtual void RevmobVideoDidStart ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revmobVideoNotCompletelyLoaded")]
		[CompilerGenerated]
		public virtual void RevmobVideoNotCompletelyLoaded ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class RevMobAdsDelegate */
}
