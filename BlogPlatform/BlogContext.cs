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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB6;Trusted_Connection=True;";

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
                    Body = "There's never been a better time to channel your inner Italian. Be sure to always use fresh herbs and GOOD EVOO.",
                    Author = "Ina Garten",
                    PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Podcast Mania",
                    Body = "So many new podcasts to listen. Here are our picks.",
                    Author = "Ira Glass",
                    PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Norway In a Day",
                    Body = "Hop on a train and get moving. Tis the season for a picturesque getaway.",
                    Author = "Rick Steves",
                    PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 4,
                    CategoryId =1,
                    Title = "Venice",
                    Body = "The canals of Venice provide a romantic way to travel through the city. Use the canals to visit a number of great restaurants.",
                    Author = "Tanzina Vega",
                    PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "New Music Friday",
                    Body = "Yola's new album provides rich sound and blissful lyrings.",
                    Author = "Eliza Moore",
                    PublishDate = DateTime.Now
                },
                new Content()
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "50 Direct Flights",
                    Body = "You can go anywhere with these direct flights to top destinations.",
                    Author = "Samantha Gomez",
                    PublishDate = DateTime.Now
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
