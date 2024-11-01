using Application.DTO;
using Domain.Entities;
using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Interface
{
    public interface IRoleService
    {
        Task CreateROle(RoleDto role);
        Task DeleteROle(int id);
        Task<Role> GetRoleById(int id);
        Task<IEnumerable<Role>> GetAllROle();
        Task<Role> UpdateROle(int roleId, RoleDto role);
    }
}
