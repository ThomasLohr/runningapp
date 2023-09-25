using Microsoft.EntityFrameworkCore;
using RunningApp.Models;
using RunningApp.Repository;
using RunningApp.Repositorys;
using RunningApp.Services;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RunningDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"), sqlServerOptions =>
    {

    });
});
builder.Services.AddTransient<ITimeRepository, TimeRepository>();
builder.Services.AddTransient<UserRepository, UserRepository>();
builder.Services.AddTransient<TimeService, TimeService>();
builder.Services.AddTransient<UserService, UserService>();
builder.Services.AddTransient<ActivityService, ActivityService>();
builder.Services.AddTransient<IActivityRepository, ActivityRepository>();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                                              
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
