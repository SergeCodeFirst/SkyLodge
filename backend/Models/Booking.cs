using System;
using System.ComponentModel.DataAnnotations;


namespace backend.Models
{
	public class Booking
	{
		[Key]
		public int BookingId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;

		// Guess id With Navigation proprety
		public int GuessId { get; set; }
		public Guess? MyGuess { get; set; }

        // Suite id With Navigation proprety
        public int SuiteId { get; set; }
		public Suite? MySuite { get; set; }

        // Room id With Navigation proprety
        public int RoomId { get; set; }
        public Room? MyRoom { get; set; }
    }
}

