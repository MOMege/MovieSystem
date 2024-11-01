using Application.DTO;
using AutoMapper;
using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class UserProfile :Profile
    {
        public UserProfile() { 
            CreateMap<User,UserByIdDto>().ReverseMap();
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<User,UserUpdateDto>().ReverseMap();
        
        }    
    }
}
