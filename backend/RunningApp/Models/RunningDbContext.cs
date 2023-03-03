using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RunningApp.Models;

public partial class RunningDbContext : DbContext
{
    public RunningDbContext()
    {
    }

    public RunningDbContext(DbContextOptions<RunningDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Time> Times { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=wozzE\\SQLEXPRESS;Database=RunningDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Time>(entity =>
        {
            entity
                .ToTable("Time");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalTime)
                .HasMaxLength(50)
                .IsUnicode(false);

           
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
