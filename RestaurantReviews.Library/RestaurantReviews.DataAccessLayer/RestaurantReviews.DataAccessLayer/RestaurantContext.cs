﻿using System;
using System.Data.Entity;
using System.Linq;
using RestaurantReviews.Library;


namespace RestaurantReviews.DataAccessLayer
{
    public class RestaurantContext : DbContext
    {
        //public DbSet<RestaurantList> RestaurantLists { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        

        public RestaurantContext () : base("RestaurantDB") { }


        public override int SaveChanges()
        {
            var AddedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Added).ToList();

            AddedEntities.ForEach(E =>
            {
                E.Property("Created").CurrentValue = DateTime.Now;
            });

            var ModifiedEntities = ChangeTracker.Entries().Where(E => E.State == EntityState.Modified).ToList();

            ModifiedEntities.ForEach(E =>
            {
                E.Property("Modified").CurrentValue = DateTime.Now;
            });
            return base.SaveChanges();
        }
    }

    
}
