﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }
        public int CategoryId { get; set; }
    }


}
