FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY *.csproj ./
COPY NuGet.Config ./
RUN nuget.exe restore MessageProcessor.csproj -SolutionDirectory ../ -Verbosity normal
RUN MSBuild.exe MessageProcessor.csproj /t:build /p:Configuration=Release /p:OutputPath=./out

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .

COPY config.txt ./
ENTRYPOINT ["dotnet", "GRBot.dll"]