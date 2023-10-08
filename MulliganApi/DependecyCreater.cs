using Microsoft.EntityFrameworkCore;
using MulliganApi.Controller;
using MulliganApi.Database;
using MulliganApi.Database.Repository;
using MulliganApi.Service;

namespace MulliganApi
{
    public class DependecyCreater
    {
        public DependecyCreater() { }

        public void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IMulliganRepository, MulliganRepository>();
            builder.Services.AddScoped<IMulliganService, MulliganService>();
            builder.Services.AddScoped<CourseController>();
            builder.Services.AddScoped<MulliganService>();
            builder.Services.AddScoped<MulliganRepository>();
        }
    }
}
