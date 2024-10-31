using Application.Repository;
using Domain.Entities.Commen;
using Infrastructure.Presistance.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistance.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
       
        public UserRepository(DbcontextApplication context) : base(context)
        {
        }
        
        
    }

}
