using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }


        // Add your entity DbSet properties here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
        }
    }
}