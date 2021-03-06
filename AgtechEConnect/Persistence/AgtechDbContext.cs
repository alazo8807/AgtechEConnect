﻿using AgtechEConnect.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AgtechEConnect.Persistence
{
	public class AgtechDbContext : IdentityDbContext<ApplicationUser>, IAgtechDbContext
	{
		public AgtechDbContext()
			: base(Constants.AGTECH_CONNECTIONSTRING_NAME, throwIfV1Schema: false)
		{
		}

		public static AgtechDbContext Create()
		{
			return new AgtechDbContext();
		}

		public DbSet<Contract> Contracts { get; set; }
		public DbSet<NameAndAddress> NameAndAddress { get; set; }
		public DbSet<CashBid> CashBids { get; set; }
		public DbSet<CashBidCommodity> CashBidCommodities { get; set; }
		public DbSet<CashBidLocation> CashBidLocations { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<AgtechDbContext>(null);

			base.OnModelCreating(modelBuilder);
		}
	}
}