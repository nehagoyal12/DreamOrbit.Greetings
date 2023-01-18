using DreamOrbit.Greetings.Component.GreetingsComponent;
using DreamOrbit.Greetings.Component.Interface;
using DreamOrbit.Greetings.Data.Context;
using DreamOrbit.Greetings.Data.GreetingsDbRepository;
using DreamOrbit.Greetings.Data.Interface;
using DreamOrbit.Greetings.Data.Models;
using DreamOrbit.Greetings.EmailComponent.EmailComponent;
using DreamOrbit.Greetings.EmailBodyComponent.Interface;
using DreamOrbit.Greetings.ErrorLog;
using DreamOrbit.Greetings.ErrorLog.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGreetingsComponent, GreetingsComponent>();
builder.Services.AddScoped<IGreetingsDbRepository, GreetingsDbRepository>();
builder.Services.AddScoped<IEmailComponent, EmailComponent>();
builder.Services.AddScoped<IErrorLog, ErrorLog>();

// Add Database
builder.Services.AddDbContext<GreetingsContext>
    (option => option.UseSqlServer(builder.Configuration.GetConnectionString("CompanyConnStr")));


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
