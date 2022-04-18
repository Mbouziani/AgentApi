using AgentApi.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<gestionAgentdbContext>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("AgentAppConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


//Scaffold - DbContext "Server=DESKTOP-HG4VL0E\SQLEXPRESS;Database=gestionAgentdb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models