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
    public interface IMovieService
    {
        Task<MovieByIdDto> GetMovieById(int id);
        Task<IEnumerable<MovieDto>> GetALlMovie();
        Task CreateMovie(MovieDto movie);
        Task<Movie> UpdateMovie(int id, MovieUpdateDto movie);
        Task DeleteMovie(int id);
    }
}
