﻿using ServerCheckAgent.Helper.Interfaces;
using ServerCheckAgent.Helper;
using ServerCheckAgent.Services.Interfaces;
using ServerCheckAgent.Services;

namespace ServerCheckAgent.Configurations
{
    public static class Startup
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IServicesWindowsHelper, ServicesWindowsHelper>();
            builder.Services.AddScoped<IServicesWindowsService, ServicesWindowsService>();
        }
        public static void ConfigureMiddleware(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
