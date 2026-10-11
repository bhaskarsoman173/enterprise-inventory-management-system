# Stage 1: Build the database migrator
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Copy project files first for dependency-restore caching
COPY src/EIMS.Domain/EIMS.Domain.csproj src/EIMS.Domain/
COPY src/EIMS.Application/EIMS.Application.csproj src/EIMS.Application/
COPY src/EIMS.Infrastructure/EIMS.Infrastructure.csproj src/EIMS.Infrastructure/
COPY tools/database-migrator/EIMS.DatabaseMigrator.csproj tools/database-migrator/

RUN dotnet restore tools/database-migrator/EIMS.DatabaseMigrator.csproj

# Copy source code
COPY src/ src/
COPY tools/database-migrator/ tools/database-migrator/

RUN dotnet publish tools/database-migrator/EIMS.DatabaseMigrator.csproj \
    --configuration Release \
    --output /app/publish \
    --no-restore

# Stage 2: Run the migrator
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "EIMS.DatabaseMigrator.dll"]
