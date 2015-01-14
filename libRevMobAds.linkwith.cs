using ObjCRuntime;

[assembly: LinkWith ("libRevMobAds.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s, SmartLink = true, ForceLoad = true, Frameworks = "MediaPlayer AdSupport StoreKit SystemConfiguration")]
