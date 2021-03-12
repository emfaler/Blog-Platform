using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB5;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add seed data for Category model:
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Cooking"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Culture"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Travel"
                }
                ); 

            // Add seed data for Content model:
            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Italian Cooking 101",
                    Body = "EVOO, Fresh herbs, and carbs.",
                    Author = "Ina Garten",
                    //PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Podcast Mania",
                    Body = "So many new podcasts to listen. Here are our picks.",
                    Author = "Ira Glass",
                    //PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Norway In a Day",
                    Body = "Hop on a train and get moving",
                    Author = "Rick Steves",
                    //PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Venice",
                    Body = "The canals do not smell and are great for long rides on a hot day",
                    Author = "Tanzena Vega",
                    //PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "New Music Friday",
                    Body = "Britney's new single is an offensively crafted BOP for the ages.",
                    Author = "Michelle Pfiefer",
                    //PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "",
                    Body = "Hop on a train and get moving",
                    Author = "Rick Steves",
                    //PublishDate = DateTime.Now
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
