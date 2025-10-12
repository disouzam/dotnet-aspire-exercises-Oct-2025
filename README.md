# About this repository

This repository contains tutorial level code created / copied during watching of playlist .NET Aspire for Beginners in dotnet YouTube channel, presented by  [Jeffrey Fritz (aka csharpfritz)](https://www.linkedin.com/in/jeffreytfritz/)

Link to playlist: [.NET Aspire for Beginners](https://youtube.com/playlist?list=PLdo4fOcmZ0oXIKNExrtlVtVxy_G4tgzsc&amp;si=CNt_bnHXQuFYKQN1)

Throughout this playlist, I will try to perform the actions presented in videos using shell commands wherever possible and the commands will be recorded below.

# Developer Workstation Setup - Part 2

Link to video: [Developer Workstation Setup [Pt 2] | .NET Aspire for Beginners](https://youtu.be/cA6Z8ayPXaE?si=g5UOxu2E7hXvn__c)

```shell
mkdir 01-activity
cd 01-activity
dotnet new aspire-starter --name starter-app-aspire
```

Output:
```shell
The template ".NET Aspire Starter App" was created successfully.
This template contains technologies from parties other than Microsoft, see https://aka.ms/dotnet/aspire/8.0-third-party-notices for details.

Processing post-creation actions...
Restoring [...]\01-activity\starter-app-aspire.sln:
Restore succeeded.
Restoring [...]\01-activity\starter-app-aspire.AppHost\starter-app-aspire.AppHost.csproj:
Restore succeeded.
Restoring [...]\01-activity\starter-app-aspire.ServiceDefaults\starter-app-aspire.ServiceDefaults.csproj:
Restore succeeded.
Restoring [...]\01-activity\starter-app-aspire.ApiService\starter-app-aspire.ApiService.csproj:
Restore succeeded.
Restoring [...]\01-activity\starter-app-aspire.Web\starter-app-aspire.Web.csproj:
Restore succeeded.
```