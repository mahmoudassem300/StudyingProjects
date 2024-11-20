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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCoreNew;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            modelBuilder.Entity<Post>()
                .HasMany(b => b.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity<PostTags>(
                    j => j
                    .HasOne(pt => pt.Tag)
                    .WithMany(pt => pt.PostTags)
                    .HasForeignKey(pt => pt.TagId),

                    j => j
                    .HasOne(pt => pt.Post)
                    .WithMany(pt => pt.PostTags)
                    .HasForeignKey(pt => pt.PostId),

                    j =>
                    {
                        j.HasKey(pt => new { pt.PostId, pt.TagId });
                    }
                );
        }   
            
        //public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
