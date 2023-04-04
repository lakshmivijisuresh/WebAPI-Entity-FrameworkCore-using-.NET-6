﻿using DatabaseProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.DatabaseContext
{
	public class SqlServerContext : DbContext
	{

		public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions) : base(dbContextOptions)
		{
		}
		public DbSet<Employee> Employee { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)

		{
			modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
			base.OnModelCreating(modelBuilder);

		}
	}
}