using Application.Contract.Interface;
using Application.DTO;
using Application.Repository;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;  
        }
        public  Task CreateROle(RoleDto role)
        {
            var model=_mapper.Map<Role>(role);
          return  _roleRepository.AddAsync(model);
        }

        public Task DeleteROle(int id)
        {
            return _roleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Role>> GetAllROle()
        {
            return  await _roleRepository.GetAllAsync();
        }

        public async Task<Role> GetRoleById(int id)
        {
            return await _roleRepository.GetByIdAsync(id);
        }

        public Task<Role> UpdateROle(int roleId, RoleDto roledto)
        {
            var model=_mapper.Map<Role>(roledto);
            return _roleRepository.UpdateAsync(model);
        }
    }
}
