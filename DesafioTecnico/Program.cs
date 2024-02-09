using DesafioTecnico.Context;
using DesafioTecnico.Model.Entities;
using DesafioTecnico.Repository;
using DesafioTecnico.Repository.Interfaces;
using DesafioTecnico.Service;
using DesafioTecnico.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Connect Database
builder.Services.AddDbContext<DesafioTecnicoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("App")));
//Mapper
builder.Services.AddAutoMapper(typeof(Resident),typeof(Apartment),typeof(Condominium),typeof(Block));
// Dependency Injection
builder.Services.AddScoped<IBaseRepository,BaseRepository>();

builder.Services.AddScoped<IResidentRepository,ResidentRepository>();
builder.Services.AddScoped<IApartmentRepository,ApartmentRepository>();

builder.Services.AddScoped<IResidentService,ResidentService>();
builder.Services.AddScoped<IApartmentService,ApartmentService>();


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
