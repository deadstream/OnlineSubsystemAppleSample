# OnlineSubsystemApple
this is a OnlineSubsystemApple plugin for unreal engine 4, both c++ and blueprint supported.

# MUST WATCH !! 
 Just 5 min
 https://youtu.be/xp9QjQfUzTk

# Step1 - Prerequired
 On Windows, Android and Unreal Editor<br/>
 You have to Two-Factor Authentication Required Apple Id - https://support.apple.com/HT204915

# Step2 - Edit your Unreal [Engine.ini] Config/DefaultEngine.ini, Config/Windows/WindowsEngine.ini, Config/Android/AndroidEngine.ini

 [OnlineSubsystemApple.OnlineIdentityApple]<br />
 ClientId=com.onlinesubsystem.apple.service<br />
 LoginRedirectUrl="https://onlinesubsystem.azurewebsites.net/api/apple/redirect" <br />
 CheckBackendUrl="https://onlinesubsystem.azurewebsites.net/api/apple/check" <br />
 
# Step3 - Must Restart Unreal Editor.
 Test On Editor.  For read again Engine.ini Step2's configuration.

# Use In Blueprint
![ScreenShot](img/Step14.png)


# If u build on IOS. You have to add config to DefaultEngine.ini

 [/Script/IOSRuntimeSettings.IOSRuntimeSettings]<br />
 bEnableSignInWithAppleSupport=True
