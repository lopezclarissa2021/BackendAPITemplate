using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendAPITemplate.Models;
using BackendAPITemplate.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BackendAPITemplate.Data
{
    public class BackendAPITemplateContext : IdentityDbContext<BlogUser>
    {
        public BackendAPITemplateContext (DbContextOptions<BackendAPITemplateContext> options)
            : base(options)
        {
        }


        public DbSet<BackendAPITemplate.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BackendAPITemplate.Models.Category> Category { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // add seed data

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CatergoryId = 1,
                    CategoryName = "Food",
                    PostedDynamicContent = []
                },
                new Category
                {
                    CatergoryId = 2,
                    CategoryName = "Family",
                    PostedDynamicContent = []
                }
            );


            modelBuilder.Entity<DynamicContent>().HasData(
                new DynamicContent
                {
                    Id = 1,
                    Title = "My first post",
                    Body = "This is my first post",
                    CreatedAt = new DateTime(2025, 02, 03),
                    UpdatedAt = new DateTime(2025, 02, 03),
                    CreatedById = "b53f4921-e2e6-48d1-9e98-d9eec7320041",
                    CategoryId = 1,
                    Visibility = VisibilityStatus.Visible
                },
                new DynamicContent
                {
                    Id = 2,
                    Title = "My second post",
                    Body = "This is my second post",
                    CreatedAt = new DateTime(2025, 02, 03),
                    UpdatedAt = new DateTime(2025, 02, 03),
                    CreatedById = "b53f4921-e2e6-48d1-9e98-d9eec7320041",
                    CategoryId = 2,
                    Visibility = VisibilityStatus.Visible
                }
            );

            modelBuilder.Entity<DynamicContent>().Navigation(c => c.Category).AutoInclude();
            modelBuilder.Entity<Category>().Navigation(c => c.PostedDynamicContent).AutoInclude();
        }
    }
}
