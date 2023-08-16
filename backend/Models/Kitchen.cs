using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
	public class Kitchen
	{
        [Key]
        public int KitchenId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Suite Id with Navigation proprety
        public int SuiteId { get; set; }
        public Suite? MySuite { get; set; }
    }
}

