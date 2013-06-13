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

namespace MonoTouch {
	
	[CompilerGenerated]
	static class Trampolines {
		
		internal delegate void DMMCompletionBlock (IntPtr block, bool success, IntPtr error);
		
		static internal class SDMMCompletionBlock {
			
			static internal readonly DMMCompletionBlock Handler = TMMCompletionBlock;
			
			[MonoPInvokeCallback (typeof (DMMCompletionBlock))]
			static unsafe void TMMCompletionBlock (IntPtr block, bool success, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MMedia.MMCompletionBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
				if (del != null)
					del (success, (MonoTouch.Foundation.NSError) Runtime.GetNSObject (error));
			}
		}
	}
}
