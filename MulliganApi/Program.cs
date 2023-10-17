using Microsoft.OpenApi.Models;
using MulliganApi;
using MulliganApi.Controller;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;
using MulliganApi.Service.Converters;

var builder = WebApplication.CreateBuilder(args);
var dependencyCreator = new DependecyCreater(builder);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mulligan Api", Version = "v1" }));
builder.Services.AddDbContext<MulliganDbContext>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        corsPolicyBuilder => corsPolicyBuilder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();
app.UseSwagger();
app.UseCors("AllowAllOrigins");

// Configure the HTTP request pipeline.
app.UseSwaggerUI(c => c.SwaggerEndpoint(
    "/swagger/v1/swagger.json",
    "v1"
    ));
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

