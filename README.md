
A Xamarin wrapper around the RevMob iOS SDK ( http://sdk.revmobmobileadnetwork.com/ios.html )

I will create a sample project in a future build.

For the technical specifications and documentation of the SDK, see http://sdk.revmobmobileadnetwork.com/ios.html

I appreciate all your input, feedback, and especially contributions!

This is my personal project, I'm not affiliated with RevMob in any way.

Building
=======
The binding was built using Xamarin Studio v5.7 as a Unified API iOS Binding Project using RevMob iOS SDK version 8.1.0

1. Download the RevMob iOS SDK version 8.1.0 from http://sdk.revmobmobileadnetwork.com/ios.html
2. Extract the SDK files.
3. Copy and rename the file "revmob-ios-sdk/RevMobAds.Framework/Versions/A/RevMobAds" to "revmob-ios-sdk/RevMobAds.Framework/Versions/A/libRevMobAds.a"
4. Add "libRevMobAds.a" to the Xamarin binding project and set its build action to ObjCBindingNativeLibrary
5. Open the automatically generated created code behind file "libRevMobAds.linkwith.cs" and replace with the content below:
	using ObjCRuntime;
	[assembly: LinkWith ("libRevMobAds.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s,  SmartLink = true, ForceLoad = true, Frameworks = "MediaPlayer AdSupport StoreKit SystemConfiguration")]
6. Build and Done.

Credits
=======
RevMob deserves all the credit as all I have done is create a Xamarin.iOS binding for the SDK.

License
=======
The binding is licensed under the MIT X11 license:

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Author
======
Robert Foll
