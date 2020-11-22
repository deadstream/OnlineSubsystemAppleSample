# OnlineSubsystemApple
this is a OnlineSubsystemApple plugin for unreal engine 4, both c++ and blueprint supported.

# Step1 - Edit your Unreal [[Platform]Engine.ini]
 ex) Config/Windows/WindowsEngine.ini
 
 [OnlineSubsystemApple.OnlineIdentityApple]<br />
 ClientId=com.onlinesubsystem.apple.service<br />
 LoginRedirectUrl=https://onlinesubsystem.azurewebsites.net/api/apple/redirect <br />
 CheckBackendUrl=https://onlinesubsystem.azurewebsites.net/api/apple/check <br />


# Step2 - Build on IOS. You have to config DefaultEngine.ini

 [/Script/IOSRuntimeSettings.IOSRuntimeSettings]<br />
 bEnableSignInWithAppleSupport=True


# Step3 - YourProject.Build.cs
  PublicDependencyModuleNames.Add("OnlineSubsystemApple");


# Step4 - Use In Blueprint
![ScreenShot](img/Step14.png)


# Customize plugin, u have to registered Apple Developer Program.

 ![ScreenShot](img/Step1.jpg)

# Step1 - Create App Id
 ![ScreenShot](img/Step2.jpg)

 ### Select App Ids and Countinue
 ![ScreenShot](img/Step3.jpg)

 Countinue
 ![ScreenShot](img/Step4.jpg)

 ### Edit Description.
 ### Edit Bundle ID. example [com.onlinesubsystem.apple]
 ### Check Capabilities - Sign In with Apple. And Click Edit
 ![ScreenShot](img/Step5.jpg)


 ### Input ur Backend Notification Server URL.
 ### Apple callback when users change mail, delete account.. etc.
 ### This PlugIn provide default Notificate URL. "https://onlinesubsystem.azurewebsites.net/api/apple/notificate"
 ![ScreenShot](img/Step6.jpg)


 ### Register App Id
 ![ScreenShot](img/Step7.jpg)


# Step2 - Create Service Id
 ![ScreenShot](img/Step8.jpg)

 Select Services IDs and Countinue
 ![ScreenShot](img/Step9.jpg)


 ### Edit Description.
 ### Edit your Identifier. example [com.onlinesubsystem.apple.service]
 ### THIS IDENTIFIER IS ClientId
 ![ScreenShot](img/Step10.jpg)

 ### Check Sign In with Apple. And Configure.
 ![ScreenShot](img/Step11.jpg)


 ### 1. Check Step1 AppId.
 ### 2. Edit Domains.
 ### 3. Edit Return URLs. This PlugIn provide default ReturnURL. "https://onlinesubsystem.azurewebsites.net/api/apple/Redirect"
 ### 4. Click Next.
 ![ScreenShot](img/Step12.jpg)


 Continue and Register.
 ![ScreenShot](img/Step13.jpg)





# Done. 
  This PlugIn Provide simple ASP.net core Backend Server with source code. You can customize ReturnURL.<br />
  Remember Step2 Apple Service IDs Indentifier is ClientId in DefaultEngine.ini
