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

namespace MMedia {
	[Register("MmiNterstitial", true)]
	public unsafe partial class MmiNterstitial : NSObject {
		[CompilerGenerated]
		const string selFetchWithRequestApidOnCompletion_ = "fetchWithRequest:apid:onCompletion:";
		static readonly IntPtr selFetchWithRequestApidOnCompletion_Handle = Selector.GetHandle ("fetchWithRequest:apid:onCompletion:");
		[CompilerGenerated]
		const string selIsAdAvailableForApid_ = "isAdAvailableForApid:";
		static readonly IntPtr selIsAdAvailableForApid_Handle = Selector.GetHandle ("isAdAvailableForApid:");
		[CompilerGenerated]
		const string selDisplayForApidFromViewControllerWithOrientationOnCompletion_ = "displayForApid:fromViewController:withOrientation:onCompletion:";
		static readonly IntPtr selDisplayForApidFromViewControllerWithOrientationOnCompletion_Handle = Selector.GetHandle ("displayForApid:fromViewController:withOrientation:onCompletion:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MmiNterstitial");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MmiNterstitial () : base (NSObjectFlag.Empty)
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
		public MmiNterstitial (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public MmiNterstitial (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MmiNterstitial (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("fetchWithRequest:apid:onCompletion:")]
		[CompilerGenerated]
		public unsafe static void FetchWithRequest (MMRequest request, string apid, MMCompletionBlock callback)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (apid == null)
				throw new ArgumentNullException ("apid");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsapid = NSString.CreateNative (apid);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDMMCompletionBlock.Handler, callback);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selFetchWithRequestApidOnCompletion_Handle, request.Handle, nsapid, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsapid);
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("isAdAvailableForApid:")]
		[CompilerGenerated]
		public static bool IsAdAvailableForApid (string apid)
		{
			if (apid == null)
				throw new ArgumentNullException ("apid");
			var nsapid = NSString.CreateNative (apid);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selIsAdAvailableForApid_Handle, nsapid);
			NSString.ReleaseNative (nsapid);
			
			return ret;
		}
		
		[Export ("displayForApid:fromViewController:withOrientation:onCompletion:")]
		[CompilerGenerated]
		public unsafe static void DisplayForApid (string apid, global::MonoTouch.UIKit.UIViewController viewController, global::MonoTouch.UIKit.UIInterfaceOrientation overlayOrientation, MMCompletionBlock callback)
		{
			if (apid == null)
				throw new ArgumentNullException ("apid");
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsapid = NSString.CreateNative (apid);
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDMMCompletionBlock.Handler, callback);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_int_IntPtr (class_ptr, selDisplayForApidFromViewControllerWithOrientationOnCompletion_Handle, nsapid, viewController.Handle, (int)overlayOrientation, (IntPtr) block_ptr_callback);
			NSString.ReleaseNative (nsapid);
			block_ptr_callback->CleanupBlock ();
			
		}
		
	} /* class MmiNterstitial */
}
