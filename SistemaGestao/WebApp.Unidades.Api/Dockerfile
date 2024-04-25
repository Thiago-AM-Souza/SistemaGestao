#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 4100
EXPOSE 4101

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WebApp.Unidades.Api/WebApp.Unidades.Api.csproj", "WebApp.Unidades.Api/"]
RUN dotnet restore "./WebApp.Unidades.Api/WebApp.Unidades.Api.csproj"
COPY . .
WORKDIR "/src/WebApp.Unidades.Api"
RUN dotnet build "./WebApp.Unidades.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApp.Unidades.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.Unidades.Api.dll"]