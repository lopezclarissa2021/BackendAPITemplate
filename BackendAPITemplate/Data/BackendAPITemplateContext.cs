using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendAPITemplate.Models;

namespace BackendAPITemplate.Data
{
    public class BackendAPITemplateContext : DbContext
    {
        public BackendAPITemplateContext (DbContextOptions<BackendAPITemplateContext> options)
            : base(options)
        {
        }

        public DbSet<BackendAPITemplate.Models.DynamicContent> DynamicContent { get; set; } = default!;
    }
}
