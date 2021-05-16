using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RoomBookingEntities;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
namespace RoomBookingDataLayer
    {
    
        public class RoomBookingDBContext : DbContext
            {
            public RoomBookingDBContext()
                {
                }

            
            public RoomBookingDBContext(DbContextOptions<RoomBookingDBContext> options) : base(options)
                {

                }

            public DbSet<Customer> Customers
                {
                get; set;
                }
            public DbSet<Hotel> Hotels
                {
                get; set;
                }
            public DbSet<Room> Rooms
                {
                get; set;
                }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TEJJIDI;Initial Catalog=RoomBookingDB;Integrated Security=True");
            }


        protected override void OnModelCreating(ModelBuilder builder)
                {
                base.OnModelCreating(builder);

                }


            }
        }
