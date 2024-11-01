using Application.Contract.Interface;
using Application.DTO;
using Application.Repository;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Service
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService  (IUserRepository userRepository,IMapper mapper)
        {  _userRepository = userRepository;
           _mapper = mapper;
        }
        public async Task<IEnumerable<UserDto>> GetALlUser()
        {
            var users = _userRepository.GetAllAsync().Result;
            return users.Select(p => new UserDto
            {
                Name = p.Name,
                Email = p.Email,
                Age = p.Age

            }).ToList();
        }

        public  async Task<UserByIdDto> GetUserById(int id)
        {

            var user = await _userRepository.GetByIdAsync(id);
            var map = _mapper.Map<UserByIdDto>(user);
            return map;
        }

        public Task CreateUser(UserDto User)
        {
            var model= _mapper.Map<User>(User);
            return _userRepository.AddAsync(model);
        }
        public Task<User> UpdateUser(int id, UserUpdateDto user)
        {
            var model=_mapper.Map<User>(user);
            return _userRepository.UpdateAsync(model);
        }
        public Task DeleteUser(int id)
        {
            return _userRepository.DeleteAsync(id);
        }
    }
}
