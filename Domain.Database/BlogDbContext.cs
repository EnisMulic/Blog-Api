using Blog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Blog.Database
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; }
        public DbSet<Tag> Tags { get; }
        public DbSet<PostTag> PostTags { get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasIndex(i => i.Slug)
                .IsUnique();

            modelBuilder.Entity<Tag>()
                .HasIndex(i => i.Name)
                .IsUnique();

            modelBuilder.Entity<PostTag>()
                .HasKey(i => new { i.PostId, i.TagId });

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is Entity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((Entity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Entity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
