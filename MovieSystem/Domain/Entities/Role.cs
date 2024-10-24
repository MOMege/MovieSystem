﻿using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       
        public ICollection<RoleUser>? RoleUsers { get; set; }
        public ICollection<RolePermission>? RolePermissions { get; set; }

    }
}
