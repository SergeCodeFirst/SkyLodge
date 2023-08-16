using System;
using Microsoft.AspNetCore.Mvc;
using backend.Services.GuessService;
using backend.Services.ResponseService;
using backend.Dtos.Guess;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessController : Controller
    {
        public readonly IGuessService _guessService;
        public GuessController(IGuessService guessService)
		{
            _guessService = guessService;
        }

        // ADD USER
        [HttpPost("add")]
        public ActionResult<ServiceResponse<AddGuessDto>> AddNewGuess()
        {
            return Ok(_guessService.AddGuess());
        }
    }
}

