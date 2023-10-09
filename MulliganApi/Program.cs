using MulliganApi;
using MulliganApi.Controller;
using MulliganApi.Data;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;

var builder = WebApplication.CreateBuilder(args);
var dependencyCreator = new DependecyCreater();


// Add services to the container.
builder.Services.AddScoped<IMulliganRepository, MulliganRepository>();
builder.Services.AddScoped<IMulliganService, MulliganService>();
builder.Services.AddScoped<CourseController>();
builder.Services.AddScoped<RoundController>();
builder.Services.AddScoped<UserController>();
builder.Services.AddScoped<MulliganService>();
builder.Services.AddScoped<MulliganRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MulliganDbContext>();

var app = builder.Build();
app.UseSwagger();

// Configure the HTTP request pipeline.

app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

