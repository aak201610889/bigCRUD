using bigCRUD.Core;
using bigCRUD.Infrastructure;
using bigCRUD.Infrastructure.DbRepositories;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.UserRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("bigCRUD.EndPoints")));


builder.Services.AddControllers();



builder.Services.AddMediatR(GetCoreAssembly.assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped(typeof(IRepository<>), typeof(SQLDbRepository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductDetailsRepository, ProductDetailsRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAny",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});


builder.Services.AddSwaggerGen();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information().WriteTo.Console().WriteTo.File("logger.txt", rollingInterval: RollingInterval.Day).CreateLogger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAny");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
