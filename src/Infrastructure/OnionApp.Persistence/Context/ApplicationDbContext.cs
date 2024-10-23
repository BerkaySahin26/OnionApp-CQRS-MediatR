using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = Guid.NewGuid(), Name = "Bmw", Quentity = 100,Value= 10},
                new Car() { Id = Guid.NewGuid(), Name = "Mercedes", Quentity = 100, Value = 1 },
                new Car() { Id = Guid.NewGuid(), Name = "Audi", Quentity = 500, Value = 25 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
