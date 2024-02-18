using Microsoft.OpenApi.Models;
using MulliganApi;
using MulliganApi.Database;
using MulliganApi.Util;

var builder = WebApplication.CreateBuilder(args);
var dependecyCreater = new DependecyCreater(builder);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mulligan Api", Version = "v1" });

    // Define a security scheme

    if (builder.Environment.IsDevelopment()) return;
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "API Key authentication",
        Name = "X-Api-Key",
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

//Applies latest migration if it is not applied yet
MigrationHelper.EnsureMigrationApplied<MulliganDbContext>(app.Services);

app.UseSwagger();

// Configure the HTTP request pipeline.
app.UseSwaggerUI(c => c.SwaggerEndpoint(
    "/swagger/v1/swagger.json",
    "v1"
    ));
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

if (app.Environment.IsDevelopment())
     app.UseDeveloperExceptionPage();

app.Run();

