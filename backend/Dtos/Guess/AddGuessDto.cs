using System;
namespace backend.Dtos.Guess
{
	public class AddGuessDto
	{
        public string? GuessFirstName { get; set; }
        public string? GuessLastName { get; set; }
        public string? GuessEmail { get; set; }
        public string? GuessPhoneNum { get; set; }
    }
}

