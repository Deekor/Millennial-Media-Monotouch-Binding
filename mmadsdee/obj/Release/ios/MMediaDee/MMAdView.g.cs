//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace MMediaDee {
	[Register("MMAdView", true)]
	public unsafe partial class MMAdView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selRootViewController = "rootViewController";
		static readonly IntPtr selRootViewControllerHandle = Selector.GetHandle ("rootViewController");
		[CompilerGenerated]
		const string selSetRootViewController_ = "setRootViewController:";
		static readonly IntPtr selSetRootViewController_Handle = Selector.GetHandle ("setRootViewController:");
		[CompilerGenerated]
		const string selOverlayOrientation = "overlayOrientation";
		static readonly IntPtr selOverlayOrientationHandle = Selector.GetHandle ("overlayOrientation");
		[CompilerGenerated]
		const string selSetOverlayOrientation_ = "setOverlayOrientation:";
		static readonly IntPtr selSetOverlayOrientation_Handle = Selector.GetHandle ("setOverlayOrientation:");
		[CompilerGenerated]
		const string selInitWithFrameApidRootViewController_ = "initWithFrame:apid:rootViewController:";
		static readonly IntPtr selInitWithFrameApidRootViewController_Handle = Selector.GetHandle ("initWithFrame:apid:rootViewController:");
		[CompilerGenerated]
		const string selGetAd_ = "getAd:";
		static readonly IntPtr selGetAd_Handle = Selector.GetHandle ("getAd:");
		[CompilerGenerated]
		const string selGetAdWithRequestOnCompletion_ = "getAdWithRequest:onCompletion:";
		static readonly IntPtr selGetAdWithRequestOnCompletion_Handle = Selector.GetHandle ("getAdWithRequest:onCompletion:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MMAdView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MMAdView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MMAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMAdView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMAdView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:apid:rootViewController:")]
		[CompilerGenerated]
		public virtual MMAdView InitWithFrame (global::System.Drawing.RectangleF frame, string apid, global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (apid == null)
				throw new ArgumentNullException ("apid");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			var nsapid = NSString.CreateNative (apid);
			
			MMAdView ret;
			if (IsDirectBinding) {
				ret = (MMAdView) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_RectangleF_IntPtr_IntPtr (this.Handle, selInitWithFrameApidRootViewController_Handle, frame, nsapid, viewController.Handle));
			} else {
				ret = (MMAdView) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_RectangleF_IntPtr_IntPtr (this.SuperHandle, selInitWithFrameApidRootViewController_Handle, frame, nsapid, viewController.Handle));
			}
			NSString.ReleaseNative (nsapid);
			
			return ret;
		}
		
		[Export ("getAd:")]
		[CompilerGenerated]
		public unsafe virtual void GetAd (MMCompletionBlock callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDMMCompletionBlock.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selGetAd_Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetAd_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("getAdWithRequest:onCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void GetAdWithRequest (MMRequest request, MMCompletionBlock callback)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDMMCompletionBlock.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selGetAdWithRequestOnCompletion_Handle, request.Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selGetAdWithRequestOnCompletion_Handle, request.Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_RootViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RootViewController {
			[Export ("rootViewController")]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRootViewControllerHandle));
				} else {
					ret = (global::MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRootViewControllerHandle));
				}
				MarkDirty ();
				__mt_RootViewController_var = ret;
				return ret;
			}
			
			[Export ("setRootViewController:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRootViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRootViewController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_RootViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIInterfaceOrientation OverlayOrientation {
			[Export ("overlayOrientation")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIInterfaceOrientation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOverlayOrientationHandle);
				} else {
					return (global::MonoTouch.UIKit.UIInterfaceOrientation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selOverlayOrientationHandle);
				}
			}
			
			[Export ("setOverlayOrientation:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetOverlayOrientation_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetOverlayOrientation_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RootViewController_var = null;
			}
		}
	} /* class MMAdView */
	public delegate void MMCompletionBlock (bool success, NSError error);
}
