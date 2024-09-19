﻿using bloggerMewl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace bloggerMewl.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            // builder.Property(a => a.CommentCount).IsRequired(); // Artık atama yapılmayacak
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 and .NET 5 changes",
                    Content = "There's a lady who's sure all that glitters is gold\r\n" +
                    "And she's buying a stairway to Heaven\r\n",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C# 9.0 and .NET changes",
                    SeoTags = "C#, C# 9, .NET 5, .NET Framework, .NET Core",
                    SeoAuthor = "Mewl",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 and .NET changes",
                    UserId = 1,
                    ViewCount = 100,
                    // CommentCount ataması kaldırıldı
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11 and 19 changes",
                    Content = "There's a lady who's sure all that glitters is gold\r\n" +
                    "And she's buying a stairway to Heaven\r\n",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C++ 11 and 19 changes",
                    SeoTags = "C++ 11 and 19 changes",
                    SeoAuthor = "Mewl",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ 11 and 19 changes",
                    UserId = 1,
                    ViewCount = 295,
                    // CommentCount ataması kaldırıldı
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "JavaScript ES2019 and ES2020 changes",
                    Content = "There's a lady who's sure all that glitters is gold\r\n" +
                    "And she's buying a stairway to Heaven\r\n",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "JavaScript ES2019 and ES2020 changes",
                    SeoTags = "JavaScript ES2019 and ES2020 changes",
                    SeoAuthor = "Mewl",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JavaScript ES2019 and ES2020 changes",
                    UserId = 1,
                    ViewCount = 12,
                }
            );
        }
    }
}
