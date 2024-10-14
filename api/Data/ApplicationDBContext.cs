using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Component> Components { get; set; }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            builder.Entity<Order>()
                .HasOne(o => o.SalesStaff)
                .WithMany(u => u.OrdersSalesStaff) 
                .HasForeignKey(o => o.SalesStaffID)
                .OnDelete(DeleteBehavior.Restrict);

            
            builder.Entity<Order>()
                .HasOne(o => o.Technician)
                .WithMany(u => u.OrdersTechnician) 
                .HasForeignKey(o => o.TechnicianID)
                .OnDelete(DeleteBehavior.Restrict);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Name = "SalesStaff",
                    NormalizedName = "SALESSTAFF"
                },
                new IdentityRole
                {
                    Name = "Technician",
                    NormalizedName = "TECHNICIAN"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}