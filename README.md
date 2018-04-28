# Envoy.Extras.Autofac
Autofac extensions for [Envoy](https://github.com/peterkneale/envoy)

[![Build Status](https://ci.appveyor.com/api/projects/status/github/peterkneale/envoy-extras-autofac?branch=master&svg=true)](https://ci.appveyor.com/project/peterkneale/envoy-extras-autofac)
[![NuGet](https://img.shields.io/nuget/dt/envoy.extras.autofac.svg)](https://www.nuget.org/packages/envoy.extras.autofac) 
[![NuGet](https://img.shields.io/nuget/vpre/envoy.extras.autofac.svg)](https://www.nuget.org/packages/envoy.extras.autofac)

## Installation

via Package Manager

```Install-Package Envoy.Extras.Autofac```

via .NET CLI: 
    
```dotnet add package Envoy.Extras.Autofac```

## Using Envoy

- Read the [QuickStart](https://github.com/PeterKneale/Envoy/doc/QuickStart.md) to understand how to use the Envoy library.

- Execute the [Sample Application](https://github.com/PeterKneale/Envoy/src/Envoy.Sample) to see Envoy in action.

## Using Envoy with Autofac Container Integration

```cs
var builder = new ContainerBuilder();
builder.RegisterEnvoy();
builder.RegisterEnvoyHandlers(typeof(MyHandlers).Assembly);
_container = builder.Build();
```
