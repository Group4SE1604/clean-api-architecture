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
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }


        // Add your entity DbSet properties here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Menu>().HasKey(m => m.MenuId);
            modelBuilder.Entity<MenuItem>().HasKey(m => m.ItemId);
            modelBuilder.Entity<MenuItem>().Property(m => m.ItemPrice).HasPrecision(18, 2);
            modelBuilder.Entity<Menu>().HasMany(m => m.MenuItems).WithOne(i => i.Menu).HasForeignKey(i => i.MenuId);


        }
    }
}