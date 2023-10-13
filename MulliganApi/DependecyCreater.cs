using Microsoft.EntityFrameworkCore;
using MulliganApi.Controller;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;
using MulliganApi.Service.Converters;

namespace MulliganApi
{
    public class DependecyCreater
    {
        public DependecyCreater() { }

        public void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IMulliganRepository, MulliganRepository>();
            builder.Services.AddScoped<IMulliganService, MulliganService>();
            builder.Services.AddScoped<IConverters, Converters>();



            builder.Services.AddScoped<RoundController>();
            builder.Services.AddScoped<UserController>();
            builder.Services.AddScoped<MulliganService>();
            builder.Services.AddScoped<MulliganRepository>();
            builder.Services.AddScoped<Converters>();
        }
    }
}
