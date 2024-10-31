using Domain.Entities;
using Domain.Entities.Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Interface
{
    public interface IMovieService
    {
        Task<Movie> GetMovieById(int id);
    }
}
