using Domain.Entities;
using Domain.Entities.Commen;
using Infrastructure.Presistance.Sedding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Presistance.Data
{
    public class DbcontextApplication : DbContext 
    {
        public DbcontextApplication(DbContextOptions<DbcontextApplication> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        DbSet<RoleUser> RoleUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Role>().HasKey(x => x.Id);
            modelBuilder.Entity<RoleUser>()
                .HasKey(x => new {x.RoleID,x.UserID});

            modelBuilder.Entity<User>()
                .HasMany(us=> us.RoleUsers)
                .WithOne(ro=> ro.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>()
                .HasMany(ro => ro.RoleUsers)
                .WithOne(u => u.Role)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RolePermission>()
                .HasKey(x => new { x.RoleId, x.PermissionId });

            modelBuilder.Entity<Role>()
                .HasMany(ro => ro.RolePermissions)
                .WithOne(pe=> pe.Role)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Permission>()
                .HasMany(pe=>pe.RolePermissions)
                .WithOne(pe=> pe.Permission)
                .OnDelete(DeleteBehavior.NoAction);

           modelBuilder.Entity<Like>()
                .Property(x=>x.IsLike)
                .HasConversion(typeof(bool));

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Subcategories)
                .WithOne(x => x.ParentCategory)
                .HasForeignKey(x=> x.ParentID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
          .HasMany(us => us.Like)
          .WithOne(li => li.User)
          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.UserDataSeed();
            modelBuilder.CategorySeedData();
            modelBuilder.PermissionSeedData();
            modelBuilder.RoleDataSeed();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
