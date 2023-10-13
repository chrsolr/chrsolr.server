FROM mcr.microsoft.com/dotnet/sdk:7.0.11-alpine as build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -o /app/published-app --configuration Release

# The runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0.11-alpine as runtime
WORKDIR /app
COPY --from=build /app/published-app /app

# The value production is used in Program.cs to set the URL for Google Cloud Run
ENV ASPNETCORE_ENVIRONMENT=production
ENV IS_GOOGLE_CLOUD=true

ENTRYPOINT [ "dotnet", "/app/chrsolr-api.dll" ]