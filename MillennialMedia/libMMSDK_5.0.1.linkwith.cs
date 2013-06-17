using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMMSDK_5.0.1.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, Frameworks = "AudioToolbox AVFoundation CoreGraphics CoreLocation MediaPlayer MobileCoreServices QuartzCore StoreKit SystemConfiguration", WeakFrameworks = "AdSupport PassKit Social ", LinkerFlags = "-lz", ForceLoad = true)]
