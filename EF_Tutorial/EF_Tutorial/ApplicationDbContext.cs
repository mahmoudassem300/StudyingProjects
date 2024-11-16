using EF_Tutorial.Configurations;
using EF_Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            
            modelBuilder.Entity<Blog>()
                .Ignore(b => b.AddedOn);
            modelBuilder.Entity<Book>()

                .HasKey(b => b.BookKey)
                .HasName("PK_BookKey");

            modelBuilder.Entity<Blog>()
                .Property(b => b.Rating)
                .HasDefaultValue(2);

            modelBuilder.Entity<Blog>()
               .Property(b => b.CreateDate)
               .HasDefaultValueSql("getdate()"); //Retrieve the current date of the DB

            modelBuilder.Entity<Author>()
                .Property(b => b.DisplayName)
                .HasComputedColumnSql("[FirstName] + ' ' + [LastName]"); // Computed Column
        } 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories{ get; set; }



    }
}
