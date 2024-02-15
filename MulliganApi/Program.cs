using Microsoft.OpenApi.Models;
using MulliganApi;
using MulliganApi.Authentication;
using MulliganApi.Controller;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;
using MulliganApi.Service.Converters;
using MulliganApi.Util;

var builder = WebApplication.CreateBuilder(args);
var dependencyCreator = new DependecyCreater(builder);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mulligan Api", Version = "v1" });

    // Define a security scheme
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "API Key authentication",
        Name = "ApiKey",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "ApiKeyScheme"
    });
    var scheme = new OpenApiSecurityScheme()
    {
        Reference = new OpenApiReference()
        {
            Type = ReferenceType.SecurityScheme,
            Id = "ApiKey"
        },
        In = ParameterLocation.Header
    };
    var requirement = new OpenApiSecurityRequirement()
    {
        { scheme, new List<string>() }
    };
    c.AddSecurityRequirement(requirement);
});



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
MigrationHelper.EnsureMigrationApplied<MulliganDbContext>(app.Services);

app.UseSwagger();
app.UseCors("AllowAllOrigins");
app.UseRouting();

// Configure the HTTP request pipeline.
app.UseSwaggerUI(c => c.SwaggerEndpoint(
    "/swagger/v1/swagger.json",
    "v1"
    ));
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

