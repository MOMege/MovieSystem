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

                new User { Id = 3, Name = "ahmed", Email = "aa@gmail.com" ,Password="112233",IsAdmin=false});
        }
    }
}
