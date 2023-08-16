using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
	public class Bathroom
	{
		[Key]
		public int BathRoomId { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Suite Id with Navigation proprety
        public int SuiteId { get; set; }
		public Suite? MySuite { get; set; }

        // Suite Id with Navigation proprety
        public int RoomId { get; set; }
        public Room? MyRoom { get; set; }
    }
}

