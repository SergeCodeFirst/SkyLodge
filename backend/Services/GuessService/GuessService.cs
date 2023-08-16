using System;
using backend.Services.ResponseService;
using backend.Dtos.Guess;
using backend.Models;
using AutoMapper;

namespace backend.Services.GuessService
{
	public class GuessService : IGuessService
	{
        public IMapper _mapper;

        public GuessService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ServiceResponse<AddGuessDto> AddUser()
        {
            var NewServiceResponse = new ServiceResponse<AddGuessDto>();

            var newGuess = new Guess();

            var userToAdd = _mapper.Map<AddGuessDto>(newGuess);

            NewServiceResponse.Data = userToAdd;
            NewServiceResponse.Success = true;
            NewServiceResponse.Message = "User Added Successfully!";

            return NewServiceResponse;

        }

    }
}

