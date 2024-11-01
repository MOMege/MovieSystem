using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class MovieProfile :Profile
    {
        public MovieProfile() { 
            CreateMap<Movie,MovieByIdDto>().ReverseMap();
            CreateMap<Movie,MovieDto>().ReverseMap();
            CreateMap<Movie,MovieUpdateDto>().ReverseMap();
        }
    }
}
