using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Commen
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; } 
        public string? Password { get; set; }
        public int Age {  get; set; } //public int? Age 
        public bool? IsAdmin { get; set; }
        public ICollection<RoleUser>? RoleUsers { get; set; }
        public ICollection<Role>? Roles { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        public ICollection<Like>? Like { get; set; }
        


    }
}
