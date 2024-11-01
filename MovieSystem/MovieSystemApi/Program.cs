using MovieSystemApi.Configrations;
using Application.Configrations;
using Infrastructure.Presistance.Configrations;
using Application.Repository;
using Infrastructure.Presistance.Data;
using Infrastructure.Presistance.Repository;
using Microsoft.Graph.Models.ExternalConnectors;
using Domain.Entities.Commen;
using Microsoft.EntityFrameworkCore;
using Application.AutoMapper;
using Application.Contract.Interface;
using Application.Contract.Service;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRepository<User>, Repository<User>>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService,MovieService>();

// Add AutoMapper Service 
builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddAutoMapper(typeof(MovieProfile));

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddAPIServices(builder.Configuration);


builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
