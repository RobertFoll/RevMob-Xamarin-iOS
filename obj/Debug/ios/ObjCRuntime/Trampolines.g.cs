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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobAdLinkSuccessfullHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobAdLinkSuccessfullHandler {
			static internal readonly DRevMobAdLinkSuccessfullHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobAdLinkSuccessfullHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobAdLinkSuccessfullHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobAdLink> (arg0));
			}
		} /* class SDRevMobAdLinkSuccessfullHandler */
		
		internal class NIDRevMobAdLinkSuccessfullHandler {
			IntPtr blockPtr;
			DRevMobAdLinkSuccessfullHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobAdLinkSuccessfullHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobAdLinkSuccessfullHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobAdLinkSuccessfullHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobAdLinkSuccessfullHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobAdLinkSuccessfullHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobAdLinkSuccessfullHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobAdLink arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobAdLinkSuccessfullHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobAdLinkFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobAdLinkFailureHandler {
			static internal readonly DRevMobAdLinkFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobAdLinkFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobAdLinkFailureHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobAdLink> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDRevMobAdLinkFailureHandler */
		
		internal class NIDRevMobAdLinkFailureHandler {
			IntPtr blockPtr;
			DRevMobAdLinkFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobAdLinkFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobAdLinkFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobAdLinkFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobAdLinkFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobAdLinkFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobAdLinkFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobAdLink arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDRevMobAdLinkFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerViewSuccessfullHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerViewSuccessfullHandler {
			static internal readonly DRevMobBannerViewSuccessfullHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerViewSuccessfullHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerViewSuccessfullHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBannerView> (arg0));
			}
		} /* class SDRevMobBannerViewSuccessfullHandler */
		
		internal class NIDRevMobBannerViewSuccessfullHandler {
			IntPtr blockPtr;
			DRevMobBannerViewSuccessfullHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerViewSuccessfullHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerViewSuccessfullHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerViewSuccessfullHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerViewSuccessfullHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerViewSuccessfullHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerViewSuccessfullHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBannerView arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobBannerViewSuccessfullHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerViewFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerViewFailureHandler {
			static internal readonly DRevMobBannerViewFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerViewFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerViewFailureHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBannerView> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDRevMobBannerViewFailureHandler */
		
		internal class NIDRevMobBannerViewFailureHandler {
			IntPtr blockPtr;
			DRevMobBannerViewFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerViewFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerViewFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerViewFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerViewFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerViewFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerViewFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBannerView arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDRevMobBannerViewFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerViewOnclickHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerViewOnclickHandler {
			static internal readonly DRevMobBannerViewOnclickHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerViewOnclickHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerViewOnclickHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBannerView> (arg0));
			}
		} /* class SDRevMobBannerViewOnclickHandler */
		
		internal class NIDRevMobBannerViewOnclickHandler {
			IntPtr blockPtr;
			DRevMobBannerViewOnclickHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerViewOnclickHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerViewOnclickHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerViewOnclickHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerViewOnclickHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerViewOnclickHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerViewOnclickHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBannerView arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobBannerViewOnclickHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerSuccessfullHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerSuccessfullHandler {
			static internal readonly DRevMobBannerSuccessfullHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerSuccessfullHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerSuccessfullHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBanner> (arg0));
			}
		} /* class SDRevMobBannerSuccessfullHandler */
		
		internal class NIDRevMobBannerSuccessfullHandler {
			IntPtr blockPtr;
			DRevMobBannerSuccessfullHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerSuccessfullHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerSuccessfullHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerSuccessfullHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerSuccessfullHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerSuccessfullHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerSuccessfullHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBanner arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobBannerSuccessfullHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerFailureHandler {
			static internal readonly DRevMobBannerFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerFailureHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBanner> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDRevMobBannerFailureHandler */
		
		internal class NIDRevMobBannerFailureHandler {
			IntPtr blockPtr;
			DRevMobBannerFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBanner arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDRevMobBannerFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobBannerOnClickHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobBannerOnClickHandler {
			static internal readonly DRevMobBannerOnClickHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobBannerOnClickHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobBannerOnClickHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobBanner> (arg0));
			}
		} /* class SDRevMobBannerOnClickHandler */
		
		internal class NIDRevMobBannerOnClickHandler {
			IntPtr blockPtr;
			DRevMobBannerOnClickHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobBannerOnClickHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobBannerOnClickHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobBannerOnClickHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobBannerOnClickHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobBannerOnClickHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobBannerOnClickHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobBanner arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobBannerOnClickHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobButtonSuccessfullHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobButtonSuccessfullHandler {
			static internal readonly DRevMobButtonSuccessfullHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobButtonSuccessfullHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobButtonSuccessfullHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobButton> (arg0));
			}
		} /* class SDRevMobButtonSuccessfullHandler */
		
		internal class NIDRevMobButtonSuccessfullHandler {
			IntPtr blockPtr;
			DRevMobButtonSuccessfullHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobButtonSuccessfullHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobButtonSuccessfullHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobButtonSuccessfullHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobButtonSuccessfullHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobButtonSuccessfullHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobButtonSuccessfullHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobButton arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobButtonSuccessfullHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobButtonFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobButtonFailureHandler {
			static internal readonly DRevMobButtonFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobButtonFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobButtonFailureHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobButton> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDRevMobButtonFailureHandler */
		
		internal class NIDRevMobButtonFailureHandler {
			IntPtr blockPtr;
			DRevMobButtonFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobButtonFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobButtonFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobButtonFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobButtonFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobButtonFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobButtonFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobButton arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDRevMobButtonFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobButtonOnclickHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobButtonOnclickHandler {
			static internal readonly DRevMobButtonOnclickHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobButtonOnclickHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobButtonOnclickHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobButton> (arg0));
			}
		} /* class SDRevMobButtonOnclickHandler */
		
		internal class NIDRevMobButtonOnclickHandler {
			IntPtr blockPtr;
			DRevMobButtonOnclickHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobButtonOnclickHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobButtonOnclickHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobButtonOnclickHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobButtonOnclickHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobButtonOnclickHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobButtonOnclickHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobButton arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobButtonOnclickHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::RevMob.iOS.RevMobFullscreen>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobFullscreen> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::RevMob.iOS.RevMobFullscreen> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::RevMob.iOS.RevMobFullscreen>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobFullscreen obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::RevMob.iOS.RevMobFullscreen, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobFullscreen> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::RevMob.iOS.RevMobFullscreen, NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::RevMob.iOS.RevMobFullscreen, NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobFullscreen arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobPopupSuccessfullHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobPopupSuccessfullHandler {
			static internal readonly DRevMobPopupSuccessfullHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobPopupSuccessfullHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobPopupSuccessfullHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobPopup> (arg0));
			}
		} /* class SDRevMobPopupSuccessfullHandler */
		
		internal class NIDRevMobPopupSuccessfullHandler {
			IntPtr blockPtr;
			DRevMobPopupSuccessfullHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobPopupSuccessfullHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobPopupSuccessfullHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobPopupSuccessfullHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobPopupSuccessfullHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobPopupSuccessfullHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobPopupSuccessfullHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobPopup arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobPopupSuccessfullHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobPopupFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobPopupFailureHandler {
			static internal readonly DRevMobPopupFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobPopupFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobPopupFailureHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobPopup> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDRevMobPopupFailureHandler */
		
		internal class NIDRevMobPopupFailureHandler {
			IntPtr blockPtr;
			DRevMobPopupFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobPopupFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobPopupFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobPopupFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobPopupFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobPopupFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobPopupFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobPopup arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDRevMobPopupFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DRevMobPopupOnClickHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDRevMobPopupOnClickHandler {
			static internal readonly DRevMobPopupOnClickHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DRevMobPopupOnClickHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::RevMob.iOS.RevMobPopupOnClickHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<RevMob.iOS.RevMobPopup> (arg0));
			}
		} /* class SDRevMobPopupOnClickHandler */
		
		internal class NIDRevMobPopupOnClickHandler {
			IntPtr blockPtr;
			DRevMobPopupOnClickHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDRevMobPopupOnClickHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DRevMobPopupOnClickHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDRevMobPopupOnClickHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::RevMob.iOS.RevMobPopupOnClickHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::RevMob.iOS.RevMobPopupOnClickHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDRevMobPopupOnClickHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::RevMob.iOS.RevMobPopup arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDRevMobPopupOnClickHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSError> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSError>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
	}
}
