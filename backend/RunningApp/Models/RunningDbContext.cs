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

    public virtual DbSet<Activity> Activities { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RunningDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Time>()
                .Property(t => t.Rundistance)
                .HasColumnType("decimal(8,4)");

        modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

        modelBuilder.Entity<Activity>()
                .HasKey(a => a.Id);

        modelBuilder.Entity<User>()
                .HasMany(t => t.Times)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .IsRequired();
                                    
        
                

        modelBuilder.Entity<Activity>()
                .HasKey(a => a.Id);

        modelBuilder.Entity<Activity>()
                .HasData(new Activity { Id = 1, Name = "Running" },
                         new Activity { Id = 2, Name = "Cycling" });



        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
