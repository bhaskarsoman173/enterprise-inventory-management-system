using EIMS.Application.Abstractions.Persistence;
using EIMS.Application.Products.Commands.CreateProduct;
using EIMS.Application.Products.Repositories;
using EIMS.Infrastructure.Persistence;
using EIMS.Infrastructure.Persistence.Repositories;
using EIMS.Infrastructure.Persistence.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Register services here.
builder.Services.AddControllers();

builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<ApplicationDbContext>();

var app = builder.Build();

// Configure HTTP pipeline here.

app.MapControllers();



app.Run();