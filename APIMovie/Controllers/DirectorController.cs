﻿using APIMovie.Interface;
using Microsoft.AspNetCore.Mvc;

namespace APIMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DirectorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet ("id")]

        public async Task<IActionResult> GetByID(string id)
        {
            var director = _unitOfWork.directorRepository.GetById(id);
            return Ok(await director);
        }
    }
}
