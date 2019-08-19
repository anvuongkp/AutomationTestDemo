- Download and install .NET Core for Windows (https://www.microsoft.com/net/download)

- Verfiy .NET Core installed successfully

 `dotnet --version`

- Download nuget.exe from https://www.nuget.org/downloads

- Restore required packages from "CSharp(Windows)/packages.config" file using nuget.exe

`nuget restore packages.config -PackagesDirectory packages`

- Modify APPIUM_URL, DEVICE_NAME, PLATFORM_VERSION, DEVICE_UDID in the "CSharp(Windows)/Utils/Configuration.cs" file

- Build project

`dotnet build`

- run test

+ run all test

`dotnet test`

+ run specific test

`dotnet test --filter "Namespace.Class.TestCase"`

ex: dotnet test --filter "Appium.Testcases.WebTest.LoginHerokuWebsiteTest"
