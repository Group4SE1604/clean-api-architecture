using BuberDinner.Api;
using BuberDinner.Api.Filter;
using BuberDinner.Application;
using BuberDinner.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddApplication().AddInfrastructure(builder.Configuration);


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "buberdinner v1"));



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
