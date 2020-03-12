using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace mynetstdlib
{
    public class MyDbContext : DbContext
    {
        public DbSet<kitten> Kittens { get; set; }
    }
}