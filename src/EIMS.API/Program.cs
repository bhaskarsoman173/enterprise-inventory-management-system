using EIMS.Application.DependencyInjection;
using EIMS.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Register services here.
builder.Services.AddControllers();

builder.Services.AddProblemDetails();

builder.Services.AddApplication();

builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

// Configure HTTP pipeline here.

app.UseExceptionHandler();

app.MapControllers();

app.Run();