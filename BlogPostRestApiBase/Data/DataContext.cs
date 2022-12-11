﻿global using Microsoft.EntityFrameworkCore;

namespace BlogPostRestApiBase.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =DESKTOP-K6CQG1C\\SQLEXPRESS;Database = blogpostdb;Trusted_Connection=true;TrustServerCertificate=true;");

        }
        public DbSet<Comments> Comments { get; set; }
    }
}
