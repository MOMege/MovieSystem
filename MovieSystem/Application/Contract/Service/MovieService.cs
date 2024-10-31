using Application.Contract.Interface;
using Application.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public  async Task<Movie> GetMovieById(int id)
        {
            return  await _movieRepository.GetByIdAsync(id);
        }
    }
}
