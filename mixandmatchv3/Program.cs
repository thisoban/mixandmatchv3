using Logic.Logic;
using DAL;
using mixandmatchv3;
using System;
using DAL.Interfaces;
using DAL.Database;
using DAL.Dal;
using Logic.Interfaces;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.


/*builder.Services.AddScoped(provider => new MMContext(connectionString1));*/

//builder.Services.AddScoped(provider => new DalContext(connectionString1));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddScoped<IJobLogic, JobLogic>();
builder.Services.AddScoped<IJobDAL, JobDAL>();
builder.Services.AddDbContext<DalContext>();


var app = builder.Build();
app.UseCors(corsPolicyBuilder => corsPolicyBuilder.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpLogging();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();

app.MapControllers();

app.Run();
