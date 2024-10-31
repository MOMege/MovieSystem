using Application.Repository;
using Domain.Entities;
using Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Presistance.Repository
{
    public class MovieRepository : Repository<Movie> ,IMovieRepository
    {
        public MovieRepository(DbcontextApplication context) : base(context)
        {
        }
    }
}
