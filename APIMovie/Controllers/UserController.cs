using APIMovie.Interface;
using APIMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> getUser()
        {
            return Ok(await _unitOfWork.userRepository.GetAll());
        }
    }
}
