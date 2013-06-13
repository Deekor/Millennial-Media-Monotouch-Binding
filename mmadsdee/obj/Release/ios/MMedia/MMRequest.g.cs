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
	[Register("MMRequest", true)]
	public unsafe partial class MMRequest : NSObject {
		[CompilerGenerated]
		const string selRequest = "request";
		static readonly IntPtr selRequestHandle = Selector.GetHandle ("request");
		[CompilerGenerated]
		const string selLocation = "location";
		static readonly IntPtr selLocationHandle = Selector.GetHandle ("location");
		[CompilerGenerated]
		const string selSetLocation_ = "setLocation:";
		static readonly IntPtr selSetLocation_Handle = Selector.GetHandle ("setLocation:");
		[CompilerGenerated]
		const string selEducation = "education";
		static readonly IntPtr selEducationHandle = Selector.GetHandle ("education");
		[CompilerGenerated]
		const string selSetEducation_ = "setEducation:";
		static readonly IntPtr selSetEducation_Handle = Selector.GetHandle ("setEducation:");
		[CompilerGenerated]
		const string selGender = "gender";
		static readonly IntPtr selGenderHandle = Selector.GetHandle ("gender");
		[CompilerGenerated]
		const string selSetGender_ = "setGender:";
		static readonly IntPtr selSetGender_Handle = Selector.GetHandle ("setGender:");
		[CompilerGenerated]
		const string selEthnicity = "ethnicity";
		static readonly IntPtr selEthnicityHandle = Selector.GetHandle ("ethnicity");
		[CompilerGenerated]
		const string selSetEthnicity_ = "setEthnicity:";
		static readonly IntPtr selSetEthnicity_Handle = Selector.GetHandle ("setEthnicity:");
		[CompilerGenerated]
		const string selMaritalStatus = "maritalStatus";
		static readonly IntPtr selMaritalStatusHandle = Selector.GetHandle ("maritalStatus");
		[CompilerGenerated]
		const string selSetMaritalStatus_ = "setMaritalStatus:";
		static readonly IntPtr selSetMaritalStatus_Handle = Selector.GetHandle ("setMaritalStatus:");
		[CompilerGenerated]
		const string selOrientation = "orientation";
		static readonly IntPtr selOrientationHandle = Selector.GetHandle ("orientation");
		[CompilerGenerated]
		const string selSetOrientation_ = "setOrientation:";
		static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle ("setOrientation:");
		[CompilerGenerated]
		const string selAge = "age";
		static readonly IntPtr selAgeHandle = Selector.GetHandle ("age");
		[CompilerGenerated]
		const string selSetAge_ = "setAge:";
		static readonly IntPtr selSetAge_Handle = Selector.GetHandle ("setAge:");
		[CompilerGenerated]
		const string selZipCode = "zipCode";
		static readonly IntPtr selZipCodeHandle = Selector.GetHandle ("zipCode");
		[CompilerGenerated]
		const string selSetZipCode_ = "setZipCode:";
		static readonly IntPtr selSetZipCode_Handle = Selector.GetHandle ("setZipCode:");
		[CompilerGenerated]
		const string selKeywords = "keywords";
		static readonly IntPtr selKeywordsHandle = Selector.GetHandle ("keywords");
		[CompilerGenerated]
		const string selSetKeywords_ = "setKeywords:";
		static readonly IntPtr selSetKeywords_Handle = Selector.GetHandle ("setKeywords:");
		[CompilerGenerated]
		const string selDataParameters = "dataParameters";
		static readonly IntPtr selDataParametersHandle = Selector.GetHandle ("dataParameters");
		[CompilerGenerated]
		const string selRequestWithLocation_ = "requestWithLocation:";
		static readonly IntPtr selRequestWithLocation_Handle = Selector.GetHandle ("requestWithLocation:");
		[CompilerGenerated]
		const string selAddKeyword_ = "addKeyword:";
		static readonly IntPtr selAddKeyword_Handle = Selector.GetHandle ("addKeyword:");
		[CompilerGenerated]
		const string selSetValueForKey_ = "setValue:forKey:";
		static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle ("setValue:forKey:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MMRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MMRequest () : base (NSObjectFlag.Empty)
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
		public MMRequest (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public MMRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public MMRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestWithLocation:")]
		[CompilerGenerated]
		public static MMRequest RequestWithLocation (global::MonoTouch.CoreLocation.CLLocation location)
		{
			if (location == null)
				throw new ArgumentNullException ("location");
			return (MMRequest) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRequestWithLocation_Handle, location.Handle));
		}
		
		[Export ("addKeyword:")]
		[CompilerGenerated]
		public virtual void AddKeyword (string keyword)
		{
			if (keyword == null)
				throw new ArgumentNullException ("keyword");
			var nskeyword = NSString.CreateNative (keyword);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddKeyword_Handle, nskeyword);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddKeyword_Handle, nskeyword);
			}
			NSString.ReleaseNative (nskeyword);
			
		}
		
		[Export ("setValue:forKey:")]
		[CompilerGenerated]
		public virtual void SetValue (NSObject value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetValueForKey_Handle, value.Handle, nskey);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetValueForKey_Handle, value.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual MMRequest Request {
			[Export ("request")]
			get {
				MMRequest ret;
				if (IsDirectBinding) {
					ret = (MMRequest) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestHandle));
				} else {
					ret = (MMRequest) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestHandle));
				}
				MarkDirty ();
				__mt_Request_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Location_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.CoreLocation.CLLocation Location {
			[Export ("location")]
			get {
				global::MonoTouch.CoreLocation.CLLocation ret;
				if (IsDirectBinding) {
					ret = (global::MonoTouch.CoreLocation.CLLocation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocationHandle));
				} else {
					ret = (global::MonoTouch.CoreLocation.CLLocation) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocationHandle));
				}
				MarkDirty ();
				__mt_Location_var = ret;
				return ret;
			}
			
			[Export ("setLocation:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocation_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocation_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Location_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual MMEducation Education {
			[Export ("education")]
			get {
				if (IsDirectBinding) {
					return (MMEducation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selEducationHandle);
				} else {
					return (MMEducation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selEducationHandle);
				}
			}
			
			[Export ("setEducation:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetEducation_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetEducation_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMGender Gender {
			[Export ("gender")]
			get {
				if (IsDirectBinding) {
					return (MMGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selGenderHandle);
				} else {
					return (MMGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selGenderHandle);
				}
			}
			
			[Export ("setGender:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetGender_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetGender_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMEthnicity Ethnicity {
			[Export ("ethnicity")]
			get {
				if (IsDirectBinding) {
					return (MMEthnicity) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selEthnicityHandle);
				} else {
					return (MMEthnicity) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selEthnicityHandle);
				}
			}
			
			[Export ("setEthnicity:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetEthnicity_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetEthnicity_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMMaritalStatus MaritalStatus {
			[Export ("maritalStatus")]
			get {
				if (IsDirectBinding) {
					return (MMMaritalStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selMaritalStatusHandle);
				} else {
					return (MMMaritalStatus) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selMaritalStatusHandle);
				}
			}
			
			[Export ("setMaritalStatus:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMaritalStatus_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetMaritalStatus_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MMSexualOrientation Orientation {
			[Export ("orientation")]
			get {
				if (IsDirectBinding) {
					return (MMSexualOrientation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOrientationHandle);
				} else {
					return (MMSexualOrientation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selOrientationHandle);
				}
			}
			
			[Export ("setOrientation:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetOrientation_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetOrientation_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Age_var;
		[CompilerGenerated]
		public virtual NSNumber Age {
			[Export ("age")]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret = (NSNumber) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAgeHandle));
				} else {
					ret = (NSNumber) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAgeHandle));
				}
				MarkDirty ();
				__mt_Age_var = ret;
				return ret;
			}
			
			[Export ("setAge:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAge_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAge_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Age_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string ZipCode {
			[Export ("zipCode")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selZipCodeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selZipCodeHandle));
				}
			}
			
			[Export ("setZipCode:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetZipCode_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetZipCode_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Keywords_var;
		[CompilerGenerated]
		public virtual NSMutableArray Keywords {
			[Export ("keywords")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKeywordsHandle));
				} else {
					ret = (NSMutableArray) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKeywordsHandle));
				}
				MarkDirty ();
				__mt_Keywords_var = ret;
				return ret;
			}
			
			[Export ("setKeywords:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKeywords_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetKeywords_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Keywords_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DataParameters_var;
		[CompilerGenerated]
		public virtual NSMutableDictionary DataParameters {
			[Export ("dataParameters")]
			get {
				NSMutableDictionary ret;
				if (IsDirectBinding) {
					ret = (NSMutableDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDataParametersHandle));
				} else {
					ret = (NSMutableDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDataParametersHandle));
				}
				MarkDirty ();
				__mt_DataParameters_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static NSString _MillennialMediaAdWillTerminateApplication;
		[Field ("MillennialMediaAdWillTerminateApplication",  "MMedia")]
		public static NSString MillennialMediaAdWillTerminateApplication {
			get {
				if (_MillennialMediaAdWillTerminateApplication == null)
					_MillennialMediaAdWillTerminateApplication = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdWillTerminateApplication");
				return _MillennialMediaAdWillTerminateApplication;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdWasTapped;
		[Field ("MillennialMediaAdWasTapped",  "MMedia")]
		public static NSString MillennialMediaAdWasTapped {
			get {
				if (_MillennialMediaAdWasTapped == null)
					_MillennialMediaAdWasTapped = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdWasTapped");
				return _MillennialMediaAdWasTapped;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdModalWillAppear;
		[Field ("MillennialMediaAdModalWillAppear",  "MMedia")]
		public static NSString MillennialMediaAdModalWillAppear {
			get {
				if (_MillennialMediaAdModalWillAppear == null)
					_MillennialMediaAdModalWillAppear = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdModalWillAppear");
				return _MillennialMediaAdModalWillAppear;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdModalDidAppear;
		[Field ("MillennialMediaAdModalDidAppear",  "MMedia")]
		public static NSString MillennialMediaAdModalDidAppear {
			get {
				if (_MillennialMediaAdModalDidAppear == null)
					_MillennialMediaAdModalDidAppear = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdModalDidAppear");
				return _MillennialMediaAdModalDidAppear;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdModalWillDismiss;
		[Field ("MillennialMediaAdModalWillDismiss",  "MMedia")]
		public static NSString MillennialMediaAdModalWillDismiss {
			get {
				if (_MillennialMediaAdModalWillDismiss == null)
					_MillennialMediaAdModalWillDismiss = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdModalWillDismiss");
				return _MillennialMediaAdModalWillDismiss;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdModalDidDismiss;
		[Field ("MillennialMediaAdModalDidDismiss",  "MMedia")]
		public static NSString MillennialMediaAdModalDidDismiss {
			get {
				if (_MillennialMediaAdModalDidDismiss == null)
					_MillennialMediaAdModalDidDismiss = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdModalDidDismiss");
				return _MillennialMediaAdModalDidDismiss;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaKeyboardWillObscureAd;
		[Field ("MillennialMediaKeyboardWillObscureAd",  "MMedia")]
		public static NSString MillennialMediaKeyboardWillObscureAd {
			get {
				if (_MillennialMediaKeyboardWillObscureAd == null)
					_MillennialMediaKeyboardWillObscureAd = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaKeyboardWillObscureAd");
				return _MillennialMediaKeyboardWillObscureAd;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaKeyboardWillHide;
		[Field ("MillennialMediaKeyboardWillHide",  "MMedia")]
		public static NSString MillennialMediaKeyboardWillHide {
			get {
				if (_MillennialMediaKeyboardWillHide == null)
					_MillennialMediaKeyboardWillHide = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaKeyboardWillHide");
				return _MillennialMediaKeyboardWillHide;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdObjectKey;
		[Field ("MillennialMediaAdObjectKey",  "MMedia")]
		public static NSString MillennialMediaAdObjectKey {
			get {
				if (_MillennialMediaAdObjectKey == null)
					_MillennialMediaAdObjectKey = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdObjectKey");
				return _MillennialMediaAdObjectKey;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaApidkEy;
		[Field ("MillennialMediaAPIDKey",  "MMedia")]
		public static NSString MillennialMediaApidkEy {
			get {
				if (_MillennialMediaApidkEy == null)
					_MillennialMediaApidkEy = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAPIDKey");
				return _MillennialMediaApidkEy;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdTypeKey;
		[Field ("MillennialMediaAdTypeKey",  "MMedia")]
		public static NSString MillennialMediaAdTypeKey {
			get {
				if (_MillennialMediaAdTypeKey == null)
					_MillennialMediaAdTypeKey = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdTypeKey");
				return _MillennialMediaAdTypeKey;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdTypeBanner;
		[Field ("MillennialMediaAdTypeBanner",  "MMedia")]
		public static NSString MillennialMediaAdTypeBanner {
			get {
				if (_MillennialMediaAdTypeBanner == null)
					_MillennialMediaAdTypeBanner = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdTypeBanner");
				return _MillennialMediaAdTypeBanner;
			}
		}
		[CompilerGenerated]
		static NSString _MillennialMediaAdTypeInterstitial;
		[Field ("MillennialMediaAdTypeInterstitial",  "MMedia")]
		public static NSString MillennialMediaAdTypeInterstitial {
			get {
				if (_MillennialMediaAdTypeInterstitial == null)
					_MillennialMediaAdTypeInterstitial = Dlfcn.GetStringConstant (Libraries.MMedia.Handle, "MillennialMediaAdTypeInterstitial");
				return _MillennialMediaAdTypeInterstitial;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Request_var = null;
				__mt_Location_var = null;
				__mt_Age_var = null;
				__mt_Keywords_var = null;
				__mt_DataParameters_var = null;
			}
		}
	} /* class MMRequest */
}
