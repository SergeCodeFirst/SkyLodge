using System;
using System.ComponentModel.DataAnnotations;


namespace backend.Models
{
	public class Room
	{
		[Key]
		public int RoomId { get; set; }
		public string? RoomName { get; set; }
		public string? RoomNum { get; set; }
		public int RoomFloor { get; set; }
		public double RoomPrice { get; set; } // decimal is better for price than double (could be use for temperature) 
		public string? RoomDesc { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAT { get; set; } = DateTime.Now;

		// Suite Id with Navigation proprety
		public int SuiteId { get; set; }
		public Suite? MySuite { get; set; }

		// List of booking a room has
		public List<Booking>? MyBookings { get; set; }

        // Num of Image a suite has
        public List<Image>? MyImages { get; set; }

        // Num of Image a suite has
        public List<Bathroom>? Bathrooms { get; set; }
    }
}

