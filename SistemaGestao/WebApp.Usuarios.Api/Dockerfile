#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 4200
EXPOSE 4201

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WebApp.Usuarios.Api/WebApp.Usuarios.Api.csproj", "WebApp.Usuarios.Api/"]
RUN dotnet restore "./WebApp.Usuarios.Api/WebApp.Usuarios.Api.csproj"
COPY . .
WORKDIR "/src/WebApp.Usuarios.Api"
RUN dotnet build "./WebApp.Usuarios.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WebApp.Usuarios.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.Usuarios.Api.dll"]