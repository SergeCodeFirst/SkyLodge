using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
	public class Image
	{
        [Key]
        public int ImageId { get; set; }
        public string? ImageURL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Suite Id with Navigation proprety
        public int SuiteId { get; set; }
        public Suite? MySuite { get; set; }

        // Room id With Navigation proprety
        public int RoomId { get; set; }
        public Room? MyRoom { get; set; }
    }
}

