using HomeFinder.Domain.Services;
using Microsoft.EntityFrameworkCore;
using HomeFinder.Infrastructure.Data;
using HomeFinder.Infrastructure;
using HomeFinder.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextClass>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlDocker")));
builder.Services.AddTransient<ISearchServices, SearchServices>();
builder.Services.AddControllers();
builder.Services.AddRepositories();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.ApplyMigration();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
