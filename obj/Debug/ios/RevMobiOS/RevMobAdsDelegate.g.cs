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
	[Protocol (Name = "RevMobAdsDelegate", WrapperType = typeof (RevMobAdsDelegateWrapper))]
	public interface IRevMobAdsDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("revmobAdDidFailWithError:")]
		[Preserve (Conditional = true)]
		void RevmobAdDidFailWithError (NSError error);
		
	}
	
	public static partial class RevMobAdsDelegate_Extensions {
		[CompilerGenerated]
		public static void RevmobSessionIsStarted (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobSessionIsStarted"));
		}
		
		[CompilerGenerated]
		public static void RevmobSessionNotStartedWithError (this IRevMobAdsDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("revmobSessionNotStartedWithError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void RevmobAdDidReceive (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobAdDidReceive"));
		}
		
		[CompilerGenerated]
		public static void RevmobAdDisplayed (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobAdDisplayed"));
		}
		
		[CompilerGenerated]
		public static void RevmobUserClickedInTheAd (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobUserClickedInTheAd"));
		}
		
		[CompilerGenerated]
		public static void RevmobUserClosedTheAd (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("revmobUserClosedTheAd"));
		}
		
		[CompilerGenerated]
		public static void InstallDidReceive (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("installDidReceive"));
		}
		
		[CompilerGenerated]
		public static void InstallDidFail (this IRevMobAdsDelegate This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("installDidFail"));
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
		
		[Export ("revmobAdDidFailWithError:")]
		[CompilerGenerated]
		public void RevmobAdDidFailWithError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("revmobAdDidFailWithError:"), error.Handle);
		}
		
	}
}
namespace RevMob.iOS {
	[Protocol]
	[Register("RevMobAdsDelegate", true)]
	[Model]
	public unsafe abstract partial class RevMobAdsDelegate : NSObject, IRevMobAdsDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected RevMobAdsDelegate () : base (NSObjectFlag.Empty)
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
		public abstract void RevmobAdDidFailWithError (NSError error);
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
		
	} /* class RevMobAdsDelegate */
}
