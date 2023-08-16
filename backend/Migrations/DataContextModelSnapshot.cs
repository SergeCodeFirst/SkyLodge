﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Bathroom", b =>
                {
                    b.Property<int>("BathRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BathRoomId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("SuiteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BathRoomId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SuiteId");

                    b.ToTable("Bathrooms");
                });

            modelBuilder.Entity("backend.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuessId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuiteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId");

                    b.HasIndex("GuessId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SuiteId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("backend.Models.Guess", b =>
                {
                    b.Property<int>("GuessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuessId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuessEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuessFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuessLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuessPhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("GuessId");

                    b.ToTable("Guesses");
                });

            modelBuilder.Entity("backend.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("SuiteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ImageId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SuiteId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("backend.Models.Kitchen", b =>
                {
                    b.Property<int>("KitchenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitchenId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuiteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("KitchenId");

                    b.HasIndex("SuiteId");

                    b.ToTable("Kitchens");
                });

            modelBuilder.Entity("backend.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomFloor")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RoomPrice")
                        .HasColumnType("float");

                    b.Property<int>("SuiteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomId");

                    b.HasIndex("SuiteId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("backend.Models.Suite", b =>
                {
                    b.Property<int>("SuiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuiteId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("SuitDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuitFloor")
                        .HasColumnType("int");

                    b.Property<string>("SuitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SuitPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("SuiteId");

                    b.ToTable("Suites");
                });

            modelBuilder.Entity("backend.Models.Bathroom", b =>
                {
                    b.HasOne("backend.Models.Room", "MyRoom")
                        .WithMany("Bathrooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Suite", "MySuite")
                        .WithMany("MyBathrooms")
                        .HasForeignKey("SuiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyRoom");

                    b.Navigation("MySuite");
                });

            modelBuilder.Entity("backend.Models.Booking", b =>
                {
                    b.HasOne("backend.Models.Guess", "MyGuess")
                        .WithMany("Bookings")
                        .HasForeignKey("GuessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Room", "MyRoom")
                        .WithMany("MyBookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Suite", "MySuite")
                        .WithMany("MyBookings")
                        .HasForeignKey("SuiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyGuess");

                    b.Navigation("MyRoom");

                    b.Navigation("MySuite");
                });

            modelBuilder.Entity("backend.Models.Image", b =>
                {
                    b.HasOne("backend.Models.Room", "MyRoom")
                        .WithMany("MyImages")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Suite", "MySuite")
                        .WithMany("MyImages")
                        .HasForeignKey("SuiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyRoom");

                    b.Navigation("MySuite");
                });

            modelBuilder.Entity("backend.Models.Kitchen", b =>
                {
                    b.HasOne("backend.Models.Suite", "MySuite")
                        .WithMany("MyKitchens")
                        .HasForeignKey("SuiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MySuite");
                });

            modelBuilder.Entity("backend.Models.Room", b =>
                {
                    b.HasOne("backend.Models.Suite", "MySuite")
                        .WithMany("MyRooms")
                        .HasForeignKey("SuiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MySuite");
                });

            modelBuilder.Entity("backend.Models.Guess", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("backend.Models.Room", b =>
                {
                    b.Navigation("Bathrooms");

                    b.Navigation("MyBookings");

                    b.Navigation("MyImages");
                });

            modelBuilder.Entity("backend.Models.Suite", b =>
                {
                    b.Navigation("MyBathrooms");

                    b.Navigation("MyBookings");

                    b.Navigation("MyImages");

                    b.Navigation("MyKitchens");

                    b.Navigation("MyRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
