﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-HHOE249\\SQLEXPRESS;initial catalog=HotelApiDb;Integrated Security=True;");

			
		}
		//public DbSet<Booking> Bookings { get; set; }
		public DbSet<Room> Rooms { get; set; }
		//public DbSet<About> Abouts { get; set; }
		public DbSet<Service> Services { get; set; }
		//public DbSet<Guest> Guests { get; set; }
		public DbSet<Staff> Staff { get; set; }
		//public DbSet<Contact> Contacts { get; set; }
		////public DbSet<MessageCategory> MessageCategories { get; set; }
		public DbSet<Subscribe> Subscribes { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		//public DbSet<WorkLocation> WorkLocations { get; set; }
	}
}