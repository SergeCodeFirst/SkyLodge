using System;
using Microsoft.EntityFrameworkCore;
using backend.Models;


namespace backend.Data
{
	public class DataContext : DbContext
	{
        // runing the DbContext (Parent) constructor the the options parameter the we
        // just create. type DbContextOptions<DataContext>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
        // Will be used to create Tables when we run migrations 
        public DbSet<Bathroom> Bathrooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guess> Guesses { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Suite> Suites { get; set; }
    }
}