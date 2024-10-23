using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RoleUser
    {
        
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int IsActive { get; set; }
        public User? User { get; set; }
         
        public Role? Role { get; set; }
        
        
    }
}
