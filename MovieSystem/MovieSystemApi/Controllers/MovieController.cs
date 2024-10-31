using Application.Contract.Interface;
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
    }
}
