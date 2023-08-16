using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
	public class Guess
	{
		[Key]
		public int GuessId { get; set; }
		public string? GuessFirstName { get; set; }
		public string? GuessLastName { get; set; }
		public string? GuessEmail { get; set; }
		public string? GuessPhoneNum { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;

		// Booking Navigation proprety
		public List<Booking>? Bookings { get; set; }
	}
}

