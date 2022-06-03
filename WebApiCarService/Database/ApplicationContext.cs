using Microsoft.EntityFrameworkCore;
using WebApiCarService.Models;
using System;

namespace WebApiCarService.Database
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Worker> Workers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
