# Stage 1: Build and publish EIMS.API
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Copy project files first to optimize dependency-restore caching
COPY src/EIMS.API/EIMS.API.csproj src/EIMS.API/
COPY src/EIMS.Application/EIMS.Application.csproj src/EIMS.Application/
COPY src/EIMS.Domain/EIMS.Domain.csproj src/EIMS.Domain/
COPY src/EIMS.Infrastructure/EIMS.Infrastructure.csproj src/EIMS.Infrastructure/

# Restore NuGet dependencies
RUN dotnet restore src/EIMS.API/EIMS.API.csproj

# Copy application source code
COPY src/ src/

# Compile and publish the API
RUN dotnet publish src/EIMS.API/EIMS.API.csproj \
    --configuration Release \
    --output /app/publish \
    --no-restore


# Stage 2: Run the published API
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

# Copy published output from the build stage
COPY --from=build /app/publish .

# ASP.NET Core listens on port 8080 by default in modern container images
EXPOSE 8080

ENTRYPOINT ["dotnet", "EIMS.API.dll"]
