#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Winter_sport_league_UI/Winter_sport_league_UI.csproj", "Winter_sport_league_UI/"]
RUN dotnet restore "Winter_sport_league_UI/Winter_sport_league_UI.csproj"
COPY . .
WORKDIR "/src/Winter_sport_league_UI"
RUN dotnet build "Winter_sport_league_UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Winter_sport_league_UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Winter_sport_league_UI.dll"]