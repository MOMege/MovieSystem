using Application.Contract.Interface;
using Application.DTO;
using Application.Repository;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<MovieByIdDto> GetMovieById(int id)
        {
            var movie= await _movieRepository.GetByIdAsync(id);
            var movieDto=_mapper.Map<MovieByIdDto>(movie);
            return movieDto;
        }
        public async Task<IEnumerable<MovieDto>> GetALlMovie()
        {
            var movies = await _movieRepository.GetAllAsync();

            var movieDtos = new List<MovieDto>();

            foreach (var movie in movies)
            {
                movieDtos.Add(new MovieDto
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Description = movie.Description,
                    // Map other properties
                });
            } 
            return movieDtos;
        }

        public Task<Movie> UpdateMovie(int id, MovieUpdateDto moviedto)
        {
           var movie=_mapper.Map<Movie>(moviedto);

            return _movieRepository.UpdateAsync(movie);
        }
        public   Task CreateMovie(MovieDto movie)
        {
            var model= _mapper.Map<Movie>(movie);
            
            return  _movieRepository.AddAsync(model)  ;
        }

        public Task DeleteMovie(int id)
        {
            return _movieRepository.DeleteAsync(id);
        }

       
    }
}
