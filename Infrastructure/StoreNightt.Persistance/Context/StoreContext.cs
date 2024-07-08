﻿using Microsoft.EntityFrameworkCore;
using StoreNightt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreNightt.Persistance.Context
{
	public class StoreContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-E4NV9FV; initial Catalog=DbStoreNightt;integrated security=true");

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
