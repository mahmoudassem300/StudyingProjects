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
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
