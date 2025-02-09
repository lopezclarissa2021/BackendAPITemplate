
using BackendAPITemplate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackendAPITemplate.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using BackendAPITemplate.Areas.Identity.Data;

namespace BackendAPITemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // link up the database
            builder.Services.AddDbContext<BackendAPITemplateContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BackendAPITemplateContext") ?? throw new InvalidOperationException("Connection string 'BackendAPITemplateContext' not found.")));

            // link up the identity and links it to the database
            builder.Services.AddDefaultIdentity<BlogUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BackendAPITemplateContext>();

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
