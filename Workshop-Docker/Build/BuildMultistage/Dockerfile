FROM microsoft/dotnet:2.0-sdk-jessie AS builder



ENV ASPNETCORE_URLS http://0.0.0.0:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "BuildMultistage.dll" ]
