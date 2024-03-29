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

builder.Services.AddTransient<IResidentRepository,ResidentRepository>();
builder.Services.AddTransient<IApartmentRepository,ApartmentRepository>();
builder.Services.AddTransient<IBlockRepository,BlockRepository>();
builder.Services.AddTransient<ICondominiumRepository,CondominiumRepository>();

builder.Services.AddTransient<IResidentService,ResidentService>();
builder.Services.AddTransient<IApartmentService,ApartmentService>();
builder.Services.AddTransient<IBlockService,BlockService>();
builder.Services.AddTransient<ICondominiumService,CondominiumService>();


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
