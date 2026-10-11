using EIMS.Infrastructure.DependencyInjection;
using EIMS.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

var connectionString =
    builder.Configuration.GetConnectionString("EimsDatabase")
    ?? throw new InvalidOperationException(
        "Connection string 'EimsDatabase' is not configured.");

var masterConnectionString = new SqlConnectionStringBuilder(connectionString)
{
    InitialCatalog = "master"
}.ConnectionString;

await using (var connection = new SqlConnection(masterConnectionString))
{
    await connection.OpenAsync();

    await using var command = connection.CreateCommand();
    command.CommandText = """
        IF DB_ID(N'EIMS') IS NULL
        BEGIN
            CREATE DATABASE [EIMS];
        END
        """;

    await command.ExecuteNonQueryAsync();
}

using var host = builder.Build();

await using var scope = host.Services.CreateAsyncScope();

var dbContext = scope.ServiceProvider
    .GetRequiredService<ApplicationDbContext>();

await dbContext.Database.MigrateAsync();

Console.WriteLine("EIMS database initialization and migrations completed.");
