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
	[Register("RevMobButton", true)]
	public unsafe partial class RevMobButton : global::UIKit.UIButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RevMobButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RevMobButton () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public RevMobButton (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RevMobButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RevMobButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadAd")]
		[CompilerGenerated]
		public virtual void LoadAd ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadAd"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadAd"));
			}
		}
		
		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:")]
		[CompilerGenerated]
		public unsafe virtual void LoadWithSuccessHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRevMobButtonSuccessfullHandler))]RevMobButtonSuccessfullHandler onAdLoadedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRevMobButtonFailureHandler))]RevMobButtonFailureHandler onAdFailedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDRevMobButtonOnclickHandler))]RevMobButtonOnclickHandler onClickHandler)
		{
			if (onAdLoadedHandler == null)
				throw new ArgumentNullException ("onAdLoadedHandler");
			if (onAdFailedHandler == null)
				throw new ArgumentNullException ("onAdFailedHandler");
			if (onClickHandler == null)
				throw new ArgumentNullException ("onClickHandler");
			BlockLiteral *block_ptr_onAdLoadedHandler;
			BlockLiteral block_onAdLoadedHandler;
			block_onAdLoadedHandler = new BlockLiteral ();
			block_ptr_onAdLoadedHandler = &block_onAdLoadedHandler;
			block_onAdLoadedHandler.SetupBlock (Trampolines.SDRevMobButtonSuccessfullHandler.Handler, onAdLoadedHandler);
			BlockLiteral *block_ptr_onAdFailedHandler;
			BlockLiteral block_onAdFailedHandler;
			block_onAdFailedHandler = new BlockLiteral ();
			block_ptr_onAdFailedHandler = &block_onAdFailedHandler;
			block_onAdFailedHandler.SetupBlock (Trampolines.SDRevMobButtonFailureHandler.Handler, onAdFailedHandler);
			BlockLiteral *block_ptr_onClickHandler;
			BlockLiteral block_onClickHandler;
			block_onClickHandler = new BlockLiteral ();
			block_ptr_onClickHandler = &block_onClickHandler;
			block_onClickHandler.SetupBlock (Trampolines.SDRevMobButtonOnclickHandler.Handler, onClickHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler, (IntPtr) block_ptr_onClickHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler, (IntPtr) block_ptr_onClickHandler);
			}
			block_ptr_onAdLoadedHandler->CleanupBlock ();
			block_ptr_onAdFailedHandler->CleanupBlock ();
			block_ptr_onClickHandler->CleanupBlock ();
			
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
		public virtual global::RevMobButtonStatus Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return (global::RevMobButtonStatus) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
				} else {
					return (global::RevMobButtonStatus) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
				}
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
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class RevMobButtonAppearance : global::UIKit.UIButton.UIButtonAppearance {
			protected internal RevMobButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new RevMobButtonAppearance Appearance {
			get { return new RevMobButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new RevMobButtonAppearance GetAppearance<T> () where T: RevMobButton {
			return new RevMobButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new RevMobButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new RevMobButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new RevMobButtonAppearance GetAppearance (UITraitCollection traits) {
			return new RevMobButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new RevMobButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new RevMobButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new RevMobButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: RevMobButton {
			return new RevMobButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new RevMobButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: RevMobButton{
			return new RevMobButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class RevMobButton */
}
