using Microsoft.EntityFrameworkCore;
using System;

namespace PhotoGalleryCore.Models
{
    public class PhotoGalleryDbContext : DbContext
    {
        public PhotoGalleryDbContext(DbContextOptions<PhotoGalleryDbContext> options) : base(options) { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Photo>().HasData(new Photo()
            {
                Date = DateTime.Now,
                PhotoId = 1,
                Description = "أبنية",
                Caption = "صورة 1",
                Rating = 5,
                Path = "gallery/1.png"

            });

            modelBuilder.Entity<Photo>().HasData(new Photo()
            {
                Date = new DateTime(2020, 5, 1),
                PhotoId = 2,
                Description = "مصورة تحمل الكاميرة",
                Caption = "صورة 2",
                Rating = 5,
                Path = "gallery/2.png"
            });

            modelBuilder.Entity<Photo>().HasData(new Photo()
            {
                Date = new DateTime(2020, 4, 1),
                PhotoId = 3,
                Description = "صورة 3",
                Caption = "مدينة",
                Rating = 5,
                Path = "gallery/3.png"
            });

            modelBuilder.Entity<Photo>().HasData(new Photo()
            {
                Date = new DateTime(2020, 4, 1),
                PhotoId = 4,
                Description = "صورة 4",
                Rating = 5,
                Caption = "شقة",
                Path = "gallery/4.png"
            });
        }

    };

}