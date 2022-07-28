# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY bin/Release/net6.0/publish .
ENTRYPOINT ["dotnet", "StackOperation.dll"]