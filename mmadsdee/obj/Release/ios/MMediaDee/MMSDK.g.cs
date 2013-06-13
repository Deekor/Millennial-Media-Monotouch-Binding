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
	[Register("MMSDK", true)]
	public unsafe partial class MMSDK : NSObject {
		[CompilerGenerated]
		const string selVersion = "version";
		static readonly IntPtr selVersionHandle = Selector.GetHandle ("version");
		[CompilerGenerated]
		const string selSetLogLevel_ = "setLogLevel:";
		static readonly IntPtr selSetLogLevel_Handle = Selector.GetHandle ("setLogLevel:");
		[CompilerGenerated]
		const string selInitialize = "initialize";
		static readonly IntPtr selInitializeHandle = Selector.GetHandle ("initialize");
		[CompilerGenerated]
		const string selTrackConversionWithGoalId_ = "trackConversionWithGoalId:";
		static readonly IntPtr selTrackConversionWithGoalId_Handle = Selector.GetHandle ("trackConversionWithGoalId:");
		[CompilerGenerated]
		const string selTrackConversionWithGoalIdRequestData_ = "trackConversionWithGoalId:requestData:";
		static readonly IntPtr selTrackConversionWithGoalIdRequestData_Handle = Selector.GetHandle ("trackConversionWithGoalId:requestData:");
		[CompilerGenerated]
		const string selTrackEventWithId_ = "trackEventWithId:";
		static readonly IntPtr selTrackEventWithId_Handle = Selector.GetHandle ("trackEventWithId:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MMSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MMSDK () : base (NSObjectFlag.Empty)
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
		public MMSDK (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public MMSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initialize")]
		[CompilerGenerated]
		public static void Initialize ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selInitializeHandle);
		}
		
		[Export ("trackConversionWithGoalId:")]
		[CompilerGenerated]
		public static void TrackConversionWithGoalId (string goalId)
		{
			if (goalId == null)
				throw new ArgumentNullException ("goalId");
			var nsgoalId = NSString.CreateNative (goalId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selTrackConversionWithGoalId_Handle, nsgoalId);
			NSString.ReleaseNative (nsgoalId);
			
		}
		
		[Export ("trackConversionWithGoalId:requestData:")]
		[CompilerGenerated]
		public static void TrackConversionWithGoalId (string goalId, MMRequest request)
		{
			if (goalId == null)
				throw new ArgumentNullException ("goalId");
			if (request == null)
				throw new ArgumentNullException ("request");
			var nsgoalId = NSString.CreateNative (goalId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selTrackConversionWithGoalIdRequestData_Handle, nsgoalId, request.Handle);
			NSString.ReleaseNative (nsgoalId);
			
		}
		
		[Export ("trackEventWithId:")]
		[CompilerGenerated]
		public static void TrackEventWithId (string eventId)
		{
			if (eventId == null)
				throw new ArgumentNullException ("eventId");
			var nseventId = NSString.CreateNative (eventId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selTrackEventWithId_Handle, nseventId);
			NSString.ReleaseNative (nseventId);
			
		}
		
		[CompilerGenerated]
		public virtual string Version {
			[Export ("version")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVersionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVersionHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MMLogLevel LogLevel {
			[Export ("setLogLevel:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLogLevel_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLogLevel_Handle, (int)value);
				}
			}
		}
		
	} /* class MMSDK */
}
