using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
 
namespace mynetstdlib
{
    public class MyDbContext : DbContext
    {
        public DbSet<kitten> Kittens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("AppSettings.json")
                    
                    .Build();
                var connectionString = configuration.GetConnectionString("MyDatabase");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}