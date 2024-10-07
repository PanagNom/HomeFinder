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

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.ApplyMigration();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();