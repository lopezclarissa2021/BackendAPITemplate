
using BackendAPITemplate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackendAPITemplate.Data;

namespace BackendAPITemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BackendAPITemplateContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BackendAPITemplateContext") ?? throw new InvalidOperationException("Connection string 'BackendAPITemplateContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
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

            DynamicContent test = new DynamicContent
            {
                Id = 1,
                Title = "Sample Content title",
                Body = "This is a sample body.",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = "Admin",
                Visibility = VisibilityStatus.Visible
            };

            app.Run();
        }
    }
}
