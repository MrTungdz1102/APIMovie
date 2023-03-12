using APIMovie.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MovieController> _logger;
        public MovieController(IUnitOfWork unitOfWork, ILogger<MovieController> logger)
        {
            _unitOfWork = unitOfWork;   
            _logger= logger;
        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var movies = _unitOfWork.movieRepository.GetAll();
            return Ok(await  movies);
        }
    }
}
