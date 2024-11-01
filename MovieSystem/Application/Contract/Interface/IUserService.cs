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
    public interface IUserService 
    {
        Task<IEnumerable<UserDto>> GetALlUser();
        Task<UserByIdDto> GetUserById(int id);
        Task CreateUser(UserDto User);
        Task<User> UpdateUser(int id, UserUpdateDto user);
        Task DeleteUser(int id);
    }
}
