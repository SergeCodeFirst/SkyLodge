using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
	public class Suite
	{
		[Key]
		public int SuiteId { get; set; }
		public string? SuitName { get; set; }
		public string? SuitDesc { get; set; }
		public int SuitFloor { get; set; }
		public decimal SuitPrice { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime Updated { get; set; } = DateTime.Now;

        // List of Booking a suit had
        public List<Booking>? MyBookings { get; set; }

        // Room Navigation proprety
        public List<Room>? MyRooms { get; set; }

		// Num of BathRoom a suite has
		public List<Bathroom>? MyBathrooms { get; set; }

        // Num of Kitchen a suite has
        public List<Kitchen>? MyKitchens { get; set; }

        // Num of Image a suite has
        public List<Image>? MyImages { get; set; }
    }
}

