# FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
# WORKDIR /app
# EXPOSE 80
#
# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# WORKDIR /src
# COPY ["chrsolr-api.csproj", "."]
# RUN dotnet restore "./chrsolr-api.csproj"
# COPY . .
# WORKDIR "/src/."
# RUN dotnet build "chrsolr-api.csproj" -c Release -o /app/build
#
# FROM build AS publish
# RUN dotnet publish "chrsolr-api.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "chrsolr-api.dll"]



# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY *.sln .
COPY *.csproj .
RUN dotnet restore

# copy everything else and build app
COPY . .
WORKDIR /src
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "chrsolr-api.dll"]
