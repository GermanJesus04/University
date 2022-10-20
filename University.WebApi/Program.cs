using Microsoft.EntityFrameworkCore;
using University.Infraestructura.Repositorio.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

const string nombreConexion = "UniversityBD";
var conexion = builder.Configuration.GetConnectionString(nombreConexion);

builder.Services.AddDbContext<UniversityContext>(opcion => opcion.UseSqlServer(conexion));

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
