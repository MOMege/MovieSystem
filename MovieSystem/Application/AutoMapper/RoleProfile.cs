﻿using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class RoleProfile :Profile
    {
        public RoleProfile()
        {
            CreateMap<Role,RoleDto>().ReverseMap();
        }
    }
}
