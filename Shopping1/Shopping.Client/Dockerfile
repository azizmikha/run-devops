# �tape de base pour l'ex�cution (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# �tape de build du projet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Shopping1/Shopping.Client/Shopping.Client.csproj", "Shopping1/Shopping.Client/"]
RUN dotnet restore "Shopping1/Shopping.Client/Shopping.Client.csproj"
COPY . .
WORKDIR "/src/Shopping1/Shopping.Client"
RUN dotnet build "Shopping.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

# �tape de publication
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Shopping.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# �tape finale (image de production)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Client.dll"]
