using APIMovie.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailGenresController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public DetailGenresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try {
                var listDetailGenres = await _unitOfWork.detailGenresRepository.GetAll();
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
