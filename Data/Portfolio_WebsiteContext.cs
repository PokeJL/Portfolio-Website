using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio_Website.Models;

namespace Portfolio_Website.Data
{
    public class Portfolio_WebsiteContext : DbContext
    {
        public Portfolio_WebsiteContext (DbContextOptions<Portfolio_WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Portfolio_Website.Models.LinkModel> LinkModel { get; set; } = default!;

        public DbSet<Portfolio_Website.Models.ProjectModel> ProjectModel { get; set; } = default!;

        public DbSet<Portfolio_Website.Models.TimelineModel> TimelineModel { get; set; } = default!;

        public DbSet<Portfolio_Website.Models.SchoolModel> SchoolModel { get; set; } = default!;

        public DbSet<Portfolio_Website.Models.WorkModel> WorkModel { get; set; } = default!;
    }
}
