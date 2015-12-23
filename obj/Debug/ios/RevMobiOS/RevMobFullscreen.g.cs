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
	[Register("RevMobFullscreen", true)]
	public unsafe partial class RevMobFullscreen : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("RevMobFullscreen");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RevMobFullscreen () : base (NSObjectFlag.Empty)
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
		protected RevMobFullscreen (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RevMobFullscreen (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hideAd")]
		[CompilerGenerated]
		public virtual void HideAd ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideAd"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideAd"));
			}
		}
		
		[Export ("loadAd")]
		[CompilerGenerated]
		public virtual void LoadAd ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadAd"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadAd"));
			}
		}
		
		[Export ("loadWithSuccessHandler:andLoadFailHandler:")]
		[CompilerGenerated]
		public unsafe virtual void LoadWithSuccessHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<RevMobFullscreen> onAdLoadedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<RevMobFullscreen, NSError> onAdFailedHandler)
		{
			if (onAdLoadedHandler == null)
				throw new ArgumentNullException ("onAdLoadedHandler");
			if (onAdFailedHandler == null)
				throw new ArgumentNullException ("onAdFailedHandler");
			BlockLiteral *block_ptr_onAdLoadedHandler;
			BlockLiteral block_onAdLoadedHandler;
			block_onAdLoadedHandler = new BlockLiteral ();
			block_ptr_onAdLoadedHandler = &block_onAdLoadedHandler;
			block_onAdLoadedHandler.SetupBlock (Trampolines.SDActionArity1V5.Handler, onAdLoadedHandler);
			BlockLiteral *block_ptr_onAdFailedHandler;
			BlockLiteral block_onAdFailedHandler;
			block_onAdFailedHandler = new BlockLiteral ();
			block_ptr_onAdFailedHandler = &block_onAdFailedHandler;
			block_onAdFailedHandler.SetupBlock (Trampolines.SDActionArity2V4.Handler, onAdFailedHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler);
			}
			block_ptr_onAdLoadedHandler->CleanupBlock ();
			block_ptr_onAdFailedHandler->CleanupBlock ();
			
		}
		
		[Export ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:onCloseHandler:")]
		[CompilerGenerated]
		public unsafe virtual void LoadWithSuccessHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V5))]global::System.Action<RevMobFullscreen> onAdLoadedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<RevMobFullscreen, NSError> onAdFailedHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onClickHandler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onCloseHandler)
		{
			if (onAdLoadedHandler == null)
				throw new ArgumentNullException ("onAdLoadedHandler");
			if (onAdFailedHandler == null)
				throw new ArgumentNullException ("onAdFailedHandler");
			if (onClickHandler == null)
				throw new ArgumentNullException ("onClickHandler");
			if (onCloseHandler == null)
				throw new ArgumentNullException ("onCloseHandler");
			BlockLiteral *block_ptr_onAdLoadedHandler;
			BlockLiteral block_onAdLoadedHandler;
			block_onAdLoadedHandler = new BlockLiteral ();
			block_ptr_onAdLoadedHandler = &block_onAdLoadedHandler;
			block_onAdLoadedHandler.SetupBlock (Trampolines.SDActionArity1V5.Handler, onAdLoadedHandler);
			BlockLiteral *block_ptr_onAdFailedHandler;
			BlockLiteral block_onAdFailedHandler;
			block_onAdFailedHandler = new BlockLiteral ();
			block_ptr_onAdFailedHandler = &block_onAdFailedHandler;
			block_onAdFailedHandler.SetupBlock (Trampolines.SDActionArity2V4.Handler, onAdFailedHandler);
			BlockLiteral *block_ptr_onClickHandler;
			BlockLiteral block_onClickHandler;
			block_onClickHandler = new BlockLiteral ();
			block_ptr_onClickHandler = &block_onClickHandler;
			block_onClickHandler.SetupBlock (Trampolines.SDAction.Handler, onClickHandler);
			BlockLiteral *block_ptr_onCloseHandler;
			BlockLiteral block_onCloseHandler;
			block_onCloseHandler = new BlockLiteral ();
			block_ptr_onCloseHandler = &block_onCloseHandler;
			block_onCloseHandler.SetupBlock (Trampolines.SDAction.Handler, onCloseHandler);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:onCloseHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler, (IntPtr) block_ptr_onClickHandler, (IntPtr) block_ptr_onCloseHandler);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("loadWithSuccessHandler:andLoadFailHandler:onClickHandler:onCloseHandler:"), (IntPtr) block_ptr_onAdLoadedHandler, (IntPtr) block_ptr_onAdFailedHandler, (IntPtr) block_ptr_onClickHandler, (IntPtr) block_ptr_onCloseHandler);
			}
			block_ptr_onAdLoadedHandler->CleanupBlock ();
			block_ptr_onAdFailedHandler->CleanupBlock ();
			block_ptr_onClickHandler->CleanupBlock ();
			block_ptr_onCloseHandler->CleanupBlock ();
			
		}
		
		[Export ("showAd")]
		[CompilerGenerated]
		public virtual void ShowAd ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showAd"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showAd"));
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
		object __mt_SupportedInterfaceOrientations_var;
		[CompilerGenerated]
		public virtual NSObject[] SupportedInterfaceOrientations {
			[Export ("supportedInterfaceOrientations", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("supportedInterfaceOrientations")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedInterfaceOrientations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SupportedInterfaceOrientations_var = ret;
				return ret;
			}
			
			[Export ("setSupportedInterfaceOrientations:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSupportedInterfaceOrientations:"), nsa_value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSupportedInterfaceOrientations:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SupportedInterfaceOrientations_var = value;
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
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
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
				__mt_SupportedInterfaceOrientations_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class RevMobFullscreen */
}
