# Odd Even App [![Build and Upload .NET Project](https://github.com/sounddrill31/OddEvenApp/actions/workflows/main.yml/badge.svg)](https://github.com/sounddrill31/OddEvenApp/actions/workflows/main.yml)

Simple C# App built using Avalonia UI. It checks the number entered and sees if it is Odd or Even

![App Screenshot](https://github.com/user-attachments/assets/1a474d71-768d-4122-a796-f47ec1158fb8)


## Install
### Windows/Linux
- Go to [Releases](https://github.com/sounddrill31/OddEvenApp/releases/latest)
- Click on the zip file for the OS you're using(OddEvenApp-ubuntu-latest.zip for 64bit Linux, OddEvenApp-windows-latest.zip for 64bit Windows)
- Extract the Zip and run the exe file OddEvenApp.Destkop.exe(./OddEvenApp.Desktop for linux users)

### Android
- Go to [Releases](https://github.com/sounddrill31/OddEvenApp/releases/latest)
- Download the signed APK and install it on your device
- Open the App

## Building
- Git clone and Enter the folder
  ```bash
  git clone https://github.com/sounddrill31/OddEvenApp;
  cd OddEvenApp
  ```
- Set up a .NET 8.0 Environment using the [install script](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script).
- Run the restore command to install deps quickly:
  ```bash
  dotnet workload restore
  ```
- Compile the Program
  ```bash
  dotnet build OddEvenApp/OddEvenApp.Desktop --configuration Release 
  ```
    - Remember to replace Desktop with Android, iOS, or Browser if you're building for a different target.
    - If you're building for Android, remember to set up your [Android SDK environment](https://docs.avaloniaui.net/docs/0.10.x/tutorials/developing-for-mobile/android/setting-up-your-developer-environment-for-android)
- Package the Program
  ```bash
  dotnet publish OddEvenApp/OddEvenApp.Desktop --configuration Release --output ./output
  ```
- Retrieve the Built Files from the output folder

## Known Issues
- On (x)Wayland, the blur is broken and X11 is untested. The AvaloniaUI Media Player App guide says this about the blur stuff:
  > Note, Linux users can not yet take advantage of this due to limitations of X11. The code will run and the window will still work on Linux, but the full effect will not be realised.
  - This same issue exists on Android as well
- No Native Wayland support is available
- Mac, iOS, Web support is broken/untested
- Clicking on the button before entering the string crashes the app
## Credits
- [Dan Walmsley](https://github.com/danwalmsley) for the [Music Store App Guide](https://docs.avaloniaui.net/docs/0.10.x/tutorials/music-store-app/)
- [Joel Paul](https://github.com/Jack-Pots) for helping me out in-person
