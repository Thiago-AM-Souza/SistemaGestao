#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 4000
EXPOSE 4001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WebApp.Gestao.Api/WebApp.Gestao.Api.csproj", "WebApp.Gestao.Api/"]
RUN dotnet restore "./WebApp.Gestao.Api/WebApp.Gestao.Api.csproj"
COPY . .
WORKDIR "/src/WebApp.Gestao.Api"
RUN dotnet build "./WebApp.Gestao.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApp.Gestao.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.Gestao.Api.dll"]