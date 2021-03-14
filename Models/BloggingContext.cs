using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cafesito.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL($"server={Environment.ExpandEnvironmentVariables("%DB_URL%")};database=Cafesito;user={Environment.ExpandEnvironmentVariables("%DB_USER%")};password={Environment.ExpandEnvironmentVariables("%DB_PASS%")}");
    }

}