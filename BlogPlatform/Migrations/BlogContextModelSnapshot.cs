// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cooking"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Culture"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Travel"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Ina Garten",
                            Body = "There's never been a better time to channel your inner Italian. Be sure to always use fresh herbs and GOOD EVOO.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 586, DateTimeKind.Local).AddTicks(930),
                            Title = "Italian Cooking 101"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Ira Glass",
                            Body = "So many new podcasts to listen. Here are our picks.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(580),
                            Title = "Podcast Mania"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Rick Steves",
                            Body = "Hop on a train and get moving. Tis the season for a picturesque getaway.",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(657),
                            Title = "Norway In a Day"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Tanzina Vega",
                            Body = "The canals of Venice provide a romantic way to travel through the city. Use the canals to visit a number of great restaurants.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(670),
                            Title = "Venice"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Eliza Moore",
                            Body = "Yola's new album provides rich sound and blissful lyrings.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(679),
                            Title = "New Music Friday"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Samantha Gomez",
                            Body = "You can go anywhere with these direct flights to top destinations.",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 9, 10, 11, 1, 53, 590, DateTimeKind.Local).AddTicks(686),
                            Title = "50 Direct Flights"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "Category")
                        .WithMany("Content")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
