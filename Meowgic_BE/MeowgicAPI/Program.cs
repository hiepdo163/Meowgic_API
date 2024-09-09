
using Meowgic.Repositories;
using MeowgicAPI.Middlewares;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Serilog;
using MeowgicAPI.Extensions;
using Meowgic.Service.Extension;
using Meowgic.Repositories.Extension;

namespace MeowgicAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var configuration = builder.Configuration;
            builder.Services.AddApiDependencies(configuration)
                            .AddServicesDependencies(configuration)
                            .AddRepositoriesDependencies();

            //Add serilog
            builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseMiddleware<GlobalExceptionMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}
