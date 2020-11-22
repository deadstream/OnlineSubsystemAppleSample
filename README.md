# OnlineSubsystemApple
this is a OnlineSubsystemApple plugin for unreal engine 4, both c++ and blueprint supported.

# Step1 - Edit your Unreal [Engine.ini] Config/DefaultEngine.ini, Config/Windows/WindowsEngine.ini, Config/Android/AndroidEngine.ini

 [OnlineSubsystemApple.OnlineIdentityApple]<br />
 ClientId=com.onlinesubsystem.apple.service<br />
 LoginRedirectUrl="https://onlinesubsystem.azurewebsites.net/api/apple/redirect" <br />
 CheckBackendUrl="https://onlinesubsystem.azurewebsites.net/api/apple/check" <br />
 

# Step2 - YourProject.Build.cs
  PublicDependencyModuleNames.Add("OnlineSubsystemApple");


# Step3 - Use In Blueprint
![ScreenShot](img/Step14.png)


# Step4 - If u build on IOS. You have to add config DefaultEngine.ini

 [/Script/IOSRuntimeSettings.IOSRuntimeSettings]<br />
 bEnableSignInWithAppleSupport=True
