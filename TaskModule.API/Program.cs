using InfrastructureLayer.Repository;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using TaskModule.ApplicationLayer.Interface;
using TaskModule.ApplicationLayer.IRepository;
using TaskModule.ApplicationLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDbConnection>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    string connectionString = configuration.GetConnectionString("TaskModuleConnString");
    return new SqlConnection(connectionString);
});

builder.Services.AddTransient<ITaskUserRepository, TaskUserRepository>();
builder.Services.AddTransient<ITaskRepository, TaskRepository>();
builder.Services.AddTransient<ITaskService, TaskService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();

var app = builder.Build();

app.UseCors(x => x
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());


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
