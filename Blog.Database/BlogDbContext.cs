﻿using Blog.Core.Helpers;
using Blog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Database
{
    public partial class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
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

            modelBuilder.Entity<PostTag>()
                .HasOne(i => i.Post)
                .WithMany(i => i.PostTags)
                .HasForeignKey(i => i.PostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(i => i.Tag)
                .WithMany(i => i.PostTags)
                .HasForeignKey(i => i.TagId);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override int SaveChanges()
        {
            AuditChanges();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AuditChanges();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AuditChanges()
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

                if (entityEntry.Entity is Post post)
                {
                    post.Slug = SlugHelper.GenerateSlug(post.Title);
                }
            }
        }
    }
}
