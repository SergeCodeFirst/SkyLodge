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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bathroom>()
                .HasOne(b => b.MySuite)
                .WithMany(s => s.MyBathrooms)
                .HasForeignKey(b => b.SuiteId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.MySuite)
                .WithMany(s => s.MyBookings)
                .HasForeignKey(b => b.SuiteId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.MySuite)
                .WithMany(s => s.MyImages)
                .HasForeignKey(i => i.SuiteId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }


}