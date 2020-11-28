# OnlineSubsystemApple
 - This is a OnlineSubsystemApple plugin for unreal engine 4, both c++ and blueprint supported.
 - Does not need Apple Developer Program on Android and Windows.

# MUST WATCH !! 
 Just 5 min https://youtu.be/ysZ-h2DjfGk

 # Prerequired - https://support.apple.com/HT204915
 - Apple Account <br/>
 - Ready iOS Device or Mac for Two-Factor Authentication<br/>
 - You have to Activate Two-Factor Authentication<br/>

 

# Step1 - Edit your Unreal Project [DefaultEngine.ini]

 [OnlineSubsystemApple.OnlineIdentityApple]<br />
 ClientId=com.onlinesubsystem.apple.service<br />
 LoginRedirectUrl="https://onlinesubsystem.azurewebsites.net/api/apple/redirect" <br />
 CheckBackendUrl="https://onlinesubsystem.azurewebsites.net/api/apple/check" <br />

 [/Script/IOSRuntimeSettings.IOSRuntimeSettings]<br />
 bEnableSignInWithAppleSupport=True
 
# Step2 - Restart Unreal Editor after edit DefaultEngine.ini
 - For read again DefaultEngine.ini

# Use in Blueprint
![ScreenShot](img/Step14.png) 

# Only iOS Build Require.
 - Need build plugin your own project.
 - Xcode 11 or later
 - iOS 13 or later
 - Uncomment OnlinesubsystemApple.Build.cs Line:86

# FAQ
 After You edit DefaultEngine.ini (Step1) and Restart Editor (Step2). But still show Invlid_Request in SignIn process <br />
  - Check Double quotes LoginRedirectUrl and CheckBackendUrl. <br />
     LoginRedirectUrl="https://onlinesubsystem.azurewebsites.net/api/apple/redirect" <br />
     CheckBackendUrl="https://onlinesubsystem.azurewebsites.net/api/apple/check" <br />

  - Restart Unreal Editor. for read again DefaultEngine.ini. <br />



