# OnlineSubsystemApple
this is a OnlineSubsystemApple plugin for unreal engine 4, both c++ and blueprint supported.

# MUST WATCH !! 
 Just 5 min
 https://youtu.be/xp9QjQfUzTk

# Prerequired
 - Ready iOS Device or Mac for Two-Factor Authentication
 - You have to Activate Two-Factor Authentication - https://support.apple.com/HT204915 <br/>
  

# Step1 - Edit your Unreal [DefaultEngine.ini]

 [OnlineSubsystemApple.OnlineIdentityApple]<br />
 ClientId=com.onlinesubsystem.apple.service<br />
 LoginRedirectUrl="https://onlinesubsystem.azurewebsites.net/api/apple/redirect" <br />
 CheckBackendUrl="https://onlinesubsystem.azurewebsites.net/api/apple/check" <br />

 [/Script/IOSRuntimeSettings.IOSRuntimeSettings]<br />
 bEnableSignInWithAppleSupport=True
 
# Step2 - Must Restart Unreal Editor.
 Test On Editor.  For read again Engine.ini Step2's configuration.

# FAQ
 After You edit DefaultEngine.ini (Step1). But still show Invlid_Request in SignIn process <br />
  - Check Double quotes LoginRedirectUrl and CheckBackendUrl. Like "https://onlinesubsystem.azurewebsites.net/api/apple/redirect"
  - Restart Unreal Editor. for read again DefaultEngine.ini.

# Use In Blueprint
![ScreenShot](img/Step14.png)

