using System;
using backend.Services.ResponseService;
using backend.Dtos.Guess;

namespace backend.Services.GuessService
{
	public interface IGuessService
	{
        public ServiceResponse<AddGuessDto> AddGuess();
    }
}

