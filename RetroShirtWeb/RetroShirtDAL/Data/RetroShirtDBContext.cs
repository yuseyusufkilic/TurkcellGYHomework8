using Microsoft.EntityFrameworkCore;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDAL.Data
{
    public class RetroShirtDBContext:DbContext
    {
        public RetroShirtDBContext(DbContextOptions<RetroShirtDBContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<CategoryTeam> CategoryTeams { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                           .WithMany(c => c.Products)
                                           .HasForeignKey(x => x.CategoryId)
                                           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>().HasOne(p => p.Team)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(x => x.TeamId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CategoryTeam>().HasKey(k => new{k.CategoryId, k.TeamId });

            modelBuilder.Entity<CategoryTeam>().HasOne(ct => ct.Category)
                                               .WithMany(ct => ct.CategoryTeams)
                                               .HasForeignKey(bc => bc.CategoryId);

            modelBuilder.Entity<CategoryTeam>().HasOne(bc => bc.Team)
                                               .WithMany(c => c.CategoryTeams)
                                               .HasForeignKey(bc => bc.TeamId);

            //modelBuilder.Entity<User>().HasOne(p => p.UserRole)
            //                           .WithMany(c => c.Users)
            //                           .HasForeignKey(x => x.RoleId)
            //                           .OnDelete(DeleteBehavior.NoAction); 
                

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Top" },
                new Category { CategoryId = 2, Name = "Short" },
                new Category { CategoryId = 3, Name = "Socks" },
                new Category { CategoryId = 4, Name = "Boots" }
           );

            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = 1, Name = "Fenerbahce" },
                new Team { TeamId = 2, Name = "Barcelona" },
                new Team { TeamId = 3, Name = "Arsenal" },
                new Team { TeamId = 4, Name = "Real Madrid" },
                new Team { TeamId = 5, Name = "Bayern Munchen" }
           );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "FenerbahceTop", CategoryId = 1, Description = "Fenerbahce top jersey.",TeamId=1,Price=450,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 2, Name = "BarcelonaShort", CategoryId = 2, Description = "Barcelona short.",TeamId=2, Price = 350,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 3, Name = "ArsenalSocks", CategoryId = 3, Description = "Arsenal socks." , TeamId = 3, Price = 150,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 4, Name = "FenerbahceShort", CategoryId = 2, Description = "Fenerbahce short." , TeamId = 1, Price = 100,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 5, Name = "RMAShort", CategoryId = 2, Description = "Real Madrid short." , TeamId = 4, Price = 250,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 6, Name = "BarcelonaTop", CategoryId = 1, Description = "Barcelona top jersey." , TeamId = 2, Price = 750,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 7, Name = "ArsenalShort", CategoryId = 2, Description = "Arsenal short." , TeamId = 3, Price = 150,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" },
                new Product { Id = 9, Name = "BayernMBoots", CategoryId = 4, Description = "BayernMBoots" , TeamId = 5, Price = 450,ImageUrl= "https://www.thedome.org/wp-content/uploads/2019/06/300x300-Placeholder-Image.jpg" }
                );

            modelBuilder.Entity<CategoryTeam>().HasData(
                new CategoryTeam
                {
                    TeamId = 1,
                    CategoryId = 1,
                }, new CategoryTeam
                {
                    TeamId = 1,
                    CategoryId = 2,
                });

          


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Fullname = "YuşeKılıç",
                    Role = "Admin",
                    Email = "abc1@gmail.com",
                    Password = "abc1",
                    Username = "abc1"
                },
                new User
                {
                    Id = 2,
                    Fullname = "EgeErsoy",
                    Role = "Editor",
                    Email = "abc2@gmail.com",
                    Password = "abc2",
                    Username = "abc2"
                },
                new User
                {
                    Id = 3,
                    Fullname = "TürkayÜrkmez",
                    Role = "Customer",
                    Email = "abc3@gmail.com",
                    Password = "abc3",
                    Username = "abc3"
                }
                );
        }

    }
}
