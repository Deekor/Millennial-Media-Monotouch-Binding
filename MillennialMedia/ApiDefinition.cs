using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace MillennialMedia
{
	public delegate void MMCompletionBlock (bool success, NSError error);

	[DisableDefaultCtor]
	[BaseType (typeof (UIView))]
	public interface MMAdView {

		[Export ("rootViewController")]
		UIViewController RootViewController { get; set; }

		[Export ("overlayOrientation")]
		UIInterfaceOrientation OverlayOrientation { get; set; }

		[Export ("initWithFrame:apid:rootViewController:")]
		IntPtr Constructor (RectangleF frame, string apid, UIViewController viewController);

		[Export ("getAd:")]
		void GetAd (MMCompletionBlock callback);

		[Export ("getAdWithRequest:onCompletion:")]
		void GetAd (MMRequest request, MMCompletionBlock callback);
	}

	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	public interface MMInterstitial {

		[Static, Export ("fetchWithRequest:apid:onCompletion:")]
		void Fetch (MMRequest request, string apid, MMCompletionBlock callback);

		[Static, Export ("isAdAvailableForApid:")]
		bool IsAdAvailable (string apid);

		[Static, Export ("displayForApid:fromViewController:withOrientation:onCompletion:")]
		void Display (string apid, UIViewController viewController, UIInterfaceOrientation overlayOrientation, MMCompletionBlock callback);
	}

	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	public interface MMRequest {

		[Export ("request")]
		MMRequest Request { get; }

		[Static, Export ("requestWithLocation:")]
		MMRequest RequestWithLocation (CLLocation location);

		[Export ("location")]
		CLLocation Location { get; set; }

		[Export ("education")]
		MMEducation Education { get; set; }

		[Export ("gender")]
		MMGender Gender { get; set; }

		[Export ("ethnicity")]
		MMEthnicity Ethnicity { get; set; }

		[Export ("maritalStatus")]
		MMMaritalStatus MaritalStatus { get; set; }

		[Export ("orientation")]
		MMSexualOrientation Orientation { get; set; }

		[Export ("age")]
		NSNumber Age { get; set; }

		[Export ("zipCode")]
		string ZipCode { get; set; }

		[Export ("keywords")]
		NSMutableArray Keywords { get; set; }

		[Export ("addKeyword:")]
		void AddKeyword (string keyword);

		[Export ("setValue:forKey:")]
		void SetValue (NSObject value, string key);

		[Export ("dataParameters")]
		NSMutableDictionary DataParameters { get; }
	}

	[DisableDefaultCtor]
	[BaseType (typeof (NSObject))]
	public interface MMSDK {

		[Static, Export ("initialize")]
		void Initialize ();

		[Export ("version")]
		string Version { get; }

		[Static, Export ("trackConversionWithGoalId:")]
		void TrackConversionWithGoalId (string goalId);

		[Static, Export ("trackConversionWithGoalId:requestData:")]
		void TrackConversionWithGoalId (string goalId, MMRequest request);

		[Export ("logLevel")]
		MMLogLevel LogLevel { set; }

		[Static, Export ("trackEventWithId:")]
		void TrackEventWithId (string eventId);

		[Field ("MillennialMediaAdWillTerminateApplication", "__Internal")]
		[Notification]
		NSString AdWillTerminateApplicationNotification { get; }

		[Field ("MillennialMediaAdModalWillAppear", "__Internal")]
		[Notification]
		NSString AdModalWillAppearNotification { get; }

		[Field ("MillennialMediaAdModalDidAppear", "__Internal")]
		[Notification]
		NSString AdModalDidAppearNotification { get; }

		[Field ("MillennialMediaAdModalWillDismiss", "__Internal")]
		[Notification]
		NSString AdModalWillDismissNotification { get; }

		[Field ("MillennialMediaAdModalDidDismiss", "__Internal")]
		[Notification]
		NSString AdModalDidDismissNotification { get; }

		[Field ("MillennialMediaKeyboardWillHide", "__Internal")]
		[Notification]
		NSString KeyboardWillHideNotification { get; }

		[Field ("MillennialMediaAdTypeBanner", "__Internal")]
		NSString AdTypeBanner { get; }

		[Field ("MillennialMediaAdTypeInterstitial", "__Internal")]
		NSString AdTypeInterstitial { get; }

		[Field ("MillennialMediaAdWasTapped", "__Internal")]
		//[Notification (typeof (MMAdWasTappedEventArgs))] // Does Not Build
		[Notification]
		NSString AdWasTappedNotification { get; }

		[Field ("MillennialMediaKeyboardWillObscureAd", "__Internal")]
		//[Notification (typeof (MMKeyboardWillObscureAdEventArgs))] // Does not build
		[Notification]
		NSString KeyboardWillObscureAdNotification { get; }
	}

	public interface MMAdWasTappedEventArgs {
		[Export ("MillennialMediaAdObjectKey")]
		MMAdView AdObject { get; }

		[Export ("MillennialMediaAPIDKey")]
		string APIDKey { get; }

		[Export ("MillennialMediaAdTypeKey")]
		NSString AdType { get; }
	}

	public interface MMKeyboardWillObscureAdEventArgs {
		[Export ("MillennialMediaAdObjectKey")]
		MMAdView AdObject { get; }
	}
}

