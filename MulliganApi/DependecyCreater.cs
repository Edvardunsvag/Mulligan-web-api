using Microsoft.EntityFrameworkCore;
using MulliganApi.Authentication;
using MulliganApi.Controller;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;
using MulliganApi.Service.Converters;
using MulliganApi.Util;
using SQLitePCL;

namespace MulliganApi
{
    public class DependecyCreater
    {
        private readonly IWebHostEnvironment _environment;

        public DependecyCreater(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public void Configure(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("TestDb");
            if (_environment.IsDevelopment())
            {
                connectionString = builder.Configuration.GetConnectionString("LocalDb");
            }
            builder.Services.AddDbContext<MulliganDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString(connectionString)));
            
            builder.Services.AddScoped<IMulliganRepository, MulliganRepository>();
            builder.Services.AddScoped<IMulliganService, MulliganService>();
            builder.Services.AddScoped<IConverters, Converters>();
            
            //Models
            builder.Services.AddScoped<RoundController>();
            builder.Services.AddScoped<UserController>();
            builder.Services.AddScoped<MulliganService>();
            builder.Services.AddScoped<MulliganRepository>();
            builder.Services.AddScoped<Converters>();
            
            //Auth - API-key
            builder.Services.AddScoped<ApiKeyAuthFilter>();
            
            //Migration
            builder.Services.AddScoped<MigrationHelper>();
        }

        public void ConfigureApp(WebApplication app)
        {
            MigrationHelper.EnsureMigrationApplied<MulliganDbContext>(app.Services);
        }
    }
}
