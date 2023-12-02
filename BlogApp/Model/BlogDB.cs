using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    public class BlogDB : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        public string DbName = "blog.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Application.StartupPath, DbName);
            optionsBuilder.UseSqlite($"Data source={path}");

           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Category cat1 = new Category { 
                Id = 1,
                Name = "Thông báo",
                DateCreated = DateTime.Now,
            };
           

            Category cat2 = new Category
            {
                Id = 2,
                Name = "Thông báo 2",
                DateCreated = DateTime.Now,
            };
           

            Category cat3 = new Category
            {
                Id = 3,
                Name = "Thông báo 3",
                DateCreated = DateTime.Now,
            };


            Category cat4 = new Category
            {
                Id = 4,
                Name = "Thông báo 4",
                DateCreated = DateTime.Now,
            };
            modelBuilder.Entity<Category>().HasData(cat1, cat2, cat3, cat4);


            Article article = new Article
            {
                Id = 1,
                Title = "Thông báo nghỉ lụt",
                Content = "Nghỉ học nhé jeje",
                DateCreated = DateTime.Now,
                IdCategory = 1
            };

           

            modelBuilder.Entity<Article>().HasData(
            article
          );
        }



    }
}
