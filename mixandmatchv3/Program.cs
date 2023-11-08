using mixandmatchv3;
using System;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);
string connectionString1 = Environment.GetEnvironmentVariable("DOCKER_DB_CONNECTION_STRING");
//string connectionString2 = Environment.GetEnvironmentVariable("LOCAL_DB_CONNECTION_STRING");

//if (Environment == "Development")
//{
//    // Use the connection string for IIS Express
//    connectionString1 = Environment.GetEnvironmentVariable("DOCKER_DB_CONNECTION_STRING");
//}
//else
//{
//    // Use the connection string for Docker or other environments
//    connectionString1 = Environment.GetEnvironmentVariable("DOCKER_DB_CONNECTION_STRING");
//}
// Add services to the container.
builder.Services.AddScoped(provider => new MMContext(connectionString1));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
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
