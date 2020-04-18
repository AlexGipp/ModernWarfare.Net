#tool "nuget:?package=xunit.runner.console&version=2.2.0"

var target = Argument("target", "Default");

Task("Default")
  .IsDependentOn("xUnit");

Task("Build")
  .Does(() =>
{
  MSBuild("./src/ModernWarfare.Net.sln");
});

Task("xUnit")
  .IsDependentOn("Build")
  .Does(() => 
  {
    DotNetCoreTest("./src/ModernWarfare.NetTests/ModernWarfare.NetTests.csproj");
  });

RunTarget(target);