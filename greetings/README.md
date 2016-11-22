# Fabric Greetings Application

## What is this?
1. GreetingService: An example ASP.NET Core / .NET "Hello World" application.
2. GreetingService.Fabric: Scaffolding for deploying this GreetingService to Service Fabric (in the package folder)

## How was this generated?
"file new .net console exe". 
Added the asp.net dependency and startup code.
csproj + project json provide build and dependency info
the project.json doesn't have the closure, just the immediate references

## How do I use this repo?
This repo serves as a reference guide for spinning up new services to a Fabric cluster.

## How should I create a new service?
Clone this repo, re-point the remote, and push it up. Then start working.
For Fabric services, we recommend prepending the repo name with "Fabric-"