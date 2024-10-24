using Domain.Entities;
using Domain.Entities.Commen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistance.Sedding
{
    public static class DataSeeding
    {
        public static void UserDataSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(

                new User { Id = 3, Name = "ahmed", Email = "aa@gmail.com", Password = "112233", IsAdmin = false });
        }
        public static void RoleDataSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Create" }
                , new Role { Id = 2, Name = "Update" }
                , new Role { Id = 3, Name = "Delete" }
                );
        }
        public static void PermissionSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Name = "perm1" }
                , new Permission { Id = 2, Name = "perm2" }
                , new Permission { Id = 3, Name = "perm3" }
                , new Permission { Id = 4, Name = "perm4" }
                , new Permission { Id = 5, Name = "perm5" }

                );
        }

        //        The INSERT statement conflicted with the FOREIGN KEY SAME TABLE constraint "FK_Categories_Categories_ParentID". The conflict occurred in database "MovieDB", table "dbo.Categories", column 'ID'.
        //The statement has been terminated.

        public static void CategorySeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, CategoryName = "Drama", }
                , new Category { ID = 2, CategoryName = "Action" }
                , new Category { ID = 3, CategoryName = "fighting", ParentID = 2 }
                , new Category { ID = 4, CategoryName = "Family", ParentID = 1 }
                , new Category { ID = 5, CategoryName = "Kids", ParentID = 4 }
                , new Category { ID = 6, CategoryName = "Cartoon", ParentID = 4 }
                , new Category { ID = 7, CategoryName = "History", ParentID = 1 }

                );
        }
    }
}
