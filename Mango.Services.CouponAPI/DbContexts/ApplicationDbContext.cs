﻿using Assos.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Assos.Services.CouponAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }
    
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId=1,
                CouponCode="100f",
                DiscountAmount = 10
            
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "200ff",
                DiscountAmount = 20
            });

        }
    
    
    }
}
