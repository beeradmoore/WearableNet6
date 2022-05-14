# WearableNet6

Test project created by making a new Xamarin.Android project in Visual Studio for Mac 2019, followed by a net6.0-android app via `dotnet new android` (which is in the `src/` folder) which I build in Visual Studio 2022 for Mac Preview.

From there I updated references for nuget, resources, and class files in the new net6.0-android project from what they are in the original Xamarin.Android app.

This project currnetly fails building with

```
obj/Debug/net6.0-android/android/AndroidManifest.xml : warning XA4218: Unable to find //manifest/application/uses-library at path: /Users/bradmoore/Library/Developer/Xamarin/android-sdk-macosx/platforms/android-31/optional/com.google.android.wearable.jar
obj/Debug/net6.0-android/android/AndroidManifest.xml : warning XA4218: Unable to find //manifest/application/uses-library at path: /Users/bradmoore/Library/Developer/Xamarin/android-sdk-macosx/platforms/android-31/optional/androidx.window.extensions.jar
obj/Debug/net6.0-android/android/AndroidManifest.xml : warning XA4218: Unable to find //manifest/application/uses-library at path: /Users/bradmoore/Library/Developer/Xamarin/android-sdk-macosx/platforms/android-31/optional/androidx.window.sidecar.jar
/usr/local/share/dotnet/packs/Microsoft.Android.Sdk.Darwin/32.0.300-rc.3.45/tools/Xamarin.Android.D8.targets(79,5): error : java.lang.RuntimeException: com.android.tools.r8.CompilationFailedException: Compilation failed to complete, origin: obj/Debug/net6.0-android/lp/59/jl/classes.jar : android/support/v4/app/INotificationSideChannel$Stub.class
```
