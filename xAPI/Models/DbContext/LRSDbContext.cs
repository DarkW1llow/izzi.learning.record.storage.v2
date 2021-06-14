using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace xAPI.Models.LRSDbContext
{
    public class LRSDbContext : DbContext
    {
        public LRSDbContext()
        {

        }

        public LRSDbContext(DbContextOptions<LRSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("attendance", "foodlink");

                entity.HasIndex(e => new { e.Id, e.MerchantId })
                    .HasName("id_merchantid");

                entity.Property(e => e.Id)
                    .HasColumnType("char(36)")
                    .ValueGeneratedNever();
                entity.Property(e => e.TargetId)
                    .HasColumnType("char(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RelationId)
                    .HasColumnType("char(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceId)
                      .HasColumnType("char(36)")
                      .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("char(36)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("char(36)");

                entity.Property(e => e.MerchantId)
                   .IsRequired()
                   .HasColumnType("char(36)");

                entity.Property(e => e.Deleted).HasColumnType("tinyint(1)");

            });

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actor", "foodlink_lrs");

                entity.HasIndex(e => e.UniqueId);

                entity.Property(e => e.UniqueId)
                      .HasColumnType("char(36)")
                      .ValueGeneratedNever();
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.ToTable("object", "foodlink_lrs");

                entity.HasIndex(e => e.UniqueId);

                entity.Property(e => e.UniqueId)
                      .HasColumnType("char(36)")
                      .ValueGeneratedNever();
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.ToTable("statement", "foodlink_lrs");

                entity.HasIndex(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnType("char(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .ValueGeneratedNever();
            });
        }
    }
}
