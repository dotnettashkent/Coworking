﻿using Coworking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Coworkingg> Coworkings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection", b => b.MigrationsAssembly("Coworking.Api"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coworkingg>()
                .HasOne(u => u.User)
                .WithOne(u => u.Coworking)
                .HasForeignKey<User>(u => u.CoworkingId);
        }

    }
}
