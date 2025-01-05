using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Resident_Control.Business.Automakers;
using Resident_Control.Business.Residenties;
using Resident_Control.Business.Users;
using Resident_Control.Business.vehicles;
using Resident_Control.Data.Context;
using Resident_Control.Repository.Automakers;
using Resident_Control.Repository.Residenties;
using Resident_Control.Repository.Users;
using Resident_Control.Repository.Vehicles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersBusiness, UsersBusiness>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

builder.Services.AddScoped<IResidentiesBusiness, ResidentiesBusiness>();
builder.Services.AddScoped<IResidentiesRepository, ResidentiesRepository>();
builder.Services.AddScoped<IVehiclesRepository, VehiclesReporitory>();
builder.Services.AddScoped<IVehiclesBusiness, VehiclesBusiness>();

builder.Services.AddScoped<IAutomarkers, Automarks>();
builder.Services.AddScoped<IAutomarksBusiness, AutomarksBusiness>();


var conection = builder.Configuration.GetConnectionString("MSSQLServerSQLConnection:MSSQLServerSQLConnectionString");

builder.Services.AddDbContext<MSSQLContext>(options => options.UseSqlServer("Data Source=DESKTOP-03NTETJ;Initial Catalog=Loja1;Integrated Security=true;Encrypt=false")) ;
builder.Services.AddCors(options => options.AddPolicy("corsapp", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();

app.Run();
