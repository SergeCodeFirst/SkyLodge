using System;
using AutoMapper;
using backend.Models;
using backend.Dtos.Guess;

namespace backend
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
            // CreateMap<User, AddUserDto>();
             CreateMap<AddGuessDto, Guess>();
        }
	}
}

