# Dotnet-VCMP runtime client

> **Introduction to Dotnet-VCMP**
> 
> Dotnet-VCMP is a collection of interlinked software libraries that allow efficient and safe scripting of VCMP servers on the .NET Core platform.

## Abstract

This project is a .NET Core library whose task is to implement the VCMP SDK in managed .NET code, as well as to be bootstrapped by the Dotnet-VCMP runtime host and bootstrap a suitably annotated method in the current assembly load context.

## Usage

To use this project in a .NET Core application, add a reference to it and annotate the entry point with the attribute `EliteKillerz.DotnetVcmp.RuntimeClient.UserEntryPointAttribute`. The entry point must be castable to `EliteKillerz.DotnetVcmp.RuntimeClient.UserEntryPointDelegate`:

```csharp
public delegate void UserEntryPointDelegate(PluginFunctions pluginFunctions, ref PluginEvents pluginEvents);
```

# 
