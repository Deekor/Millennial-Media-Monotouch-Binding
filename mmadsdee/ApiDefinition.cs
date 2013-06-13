
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.CoreLocation;


namespace MMedia {


	public delegate void MMCompletionBlock (bool success, NSError error);

	[BaseType (typeof (UIView))]
	public partial interface MMAdView {

		[Export ("rootViewController")]
		UIViewController RootViewController { get; set; }

		[Export ("overlayOrientation")]
		UIInterfaceOrientation OverlayOrientation { get; set; }

		[Export ("initWithFrame:apid:rootViewController:")]
		MMAdView InitWithFrame (RectangleF frame, string apid, UIViewController viewController);

		[Export ("getAd:")]
		void GetAd (MMCompletionBlock callback);

		[Export ("getAdWithRequest:onCompletion:")]
		void GetAdWithRequest (MMRequest request, MMCompletionBlock callback);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MmiNterstitial {

		[Static, Export ("fetchWithRequest:apid:onCompletion:")]
		void FetchWithRequest (MMRequest request, string apid, MMCompletionBlock callback);

		[Static, Export ("isAdAvailableForApid:")]
		bool IsAdAvailableForApid (string apid);

		[Static, Export ("displayForApid:fromViewController:withOrientation:onCompletion:")]
		void DisplayForApid (string apid, UIViewController viewController, UIInterfaceOrientation overlayOrientation, MMCompletionBlock callback);
	}

	public enum  MMEducation  {
		MMEducationUnknown = 0,
		MMEducationNone = 1,
		MMEducationHighSchool = 2,
		MMEducationSomeCollege = 3,
		MMEducationBachelors = 4,
		MMEducationMasters = 5,
		MMEducationDoctorate = 6
	}

	public enum MMGender {
		MMGenderUnknown = 0,
		MMGenderMale = 1,
		MMGenderFemale = 2
	}

	public enum MMEthnicity {
		MMEthnicityUnknown = 0,
		MMEthnicityMiddleEastern = 1,
		MMEthnicityAsian = 2,
		MMEthnicityBlack = 3,
		MMEthnicityHispanic = 4,
		MMEthnicityIndian = 5,
		MMEthnicityNativeAmerican = 6,
		MMEthnicityPacificIslander = 7,
		MMEthnicityWhite = 8,
		MMEthnicityOther = 9
	}

	public enum  MMMaritalStatus {
		MMMaritalUnknown = 0,
		MMMaritalSingle = 1,
		MMMaritalMarried = 2,
		MMMaritalDivorced = 3,
		MMMaritalEngaged = 4
	}

	public enum  MMSexualOrientation {
		MMSexualOrientationUnknown = 0,
		MMSexualOrientationGay = 1,
		MMSexualOrientationStraight = 2,
		MMSexualOrientationBisexual = 3,
		MMSexualOrientationTransgender = 4
	}

	[BaseType (typeof (NSObject))]
	public partial interface MMRequest {

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

		[Field ("MillennialMediaAdWillTerminateApplication")]
		NSString MillennialMediaAdWillTerminateApplication { get; }

		[Field ("MillennialMediaAdWasTapped")]
		NSString MillennialMediaAdWasTapped { get; }

		[Field ("MillennialMediaAdModalWillAppear")]
		NSString MillennialMediaAdModalWillAppear { get; }

		[Field ("MillennialMediaAdModalDidAppear")]
		NSString MillennialMediaAdModalDidAppear { get; }

		[Field ("MillennialMediaAdModalWillDismiss")]
		NSString MillennialMediaAdModalWillDismiss { get; }

		[Field ("MillennialMediaAdModalDidDismiss")]
		NSString MillennialMediaAdModalDidDismiss { get; }

		[Field ("MillennialMediaKeyboardWillObscureAd")]
		NSString MillennialMediaKeyboardWillObscureAd { get; }

		[Field ("MillennialMediaKeyboardWillHide")]
		NSString MillennialMediaKeyboardWillHide { get; }

		[Field ("MillennialMediaAdObjectKey")]
		NSString MillennialMediaAdObjectKey { get; }

		[Field ("MillennialMediaAPIDKey")]
		NSString MillennialMediaApidkEy { get; }

		[Field ("MillennialMediaAdTypeKey")]
		NSString MillennialMediaAdTypeKey { get; }

		[Field ("MillennialMediaAdTypeBanner")]
		NSString MillennialMediaAdTypeBanner { get; }

		[Field ("MillennialMediaAdTypeInterstitial")]
		NSString MillennialMediaAdTypeInterstitial { get; }
	}

	public enum ErrorCode {
		MMAdUnknownError = 0,
		MMAdServerError = -500,
		MMAdUnavailable = -503,
		MMAdDisabled = -9999999
	}

	public enum MMLogLevel {
		MMLOG_LEVEL_OFF = 0,
		MMLOG_LEVEL_INFO = 1,
		MMLOG_LEVEL_DEBUG = 2,
		MMLOG_LEVEL_ERROR = 4,
		MMLOG_LEVEL_FATAL = 8
	}

	[BaseType (typeof (NSObject))]
	public partial interface MMSDK {

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
	}
}
