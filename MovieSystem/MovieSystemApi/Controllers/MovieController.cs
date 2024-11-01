using Application.Contract.Interface;
using Application.DTO;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetMovieById(int id)
        {
            var movie =  await _movieService.GetMovieById(id);
            return Ok(movie);
        }
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _movieService.GetALlMovie();
            return Ok(movies);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletMovie(int id)
        {
            await _movieService.DeleteMovie(id);
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMovie(MovieDto movie)
        {
            await _movieService.CreateMovie(movie);
            return Ok();
        }
        [HttpPut("{id}")]
        public async  Task<IActionResult> UpdateMovie(int id,MovieUpdateDto movieDto)
        {
            if (id != movieDto.Id)
                return BadRequest();
           var movie = await _movieService.UpdateMovie(id, movieDto);
            return Ok();
        }
    }
}
