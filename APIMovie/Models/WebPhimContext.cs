using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIMovie.Models;

public partial class WebPhimContext : DbContext
{
    public WebPhimContext()
    {
    }

    public WebPhimContext(DbContextOptions<WebPhimContext> options) : base(options)
    {

    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Genres> Genres { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<ReView> ReViews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-JGS0UPQ\\SQLEXPRESS;Initial Catalog=WebPhim;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetailActor>(entity =>
        {
            entity.HasKey(da => new { da.MovieID, da.ActorID });

            entity.ToTable("DetailActor");

            entity.HasOne(a => a.actor)
                .WithMany(da => da.DetailActors)
                .HasForeignKey(a => a.ActorID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailActor_Actor");

            entity.HasOne(m => m.movie)
                .WithMany(da => da.DetailActors)
                .HasForeignKey(m => m.MovieID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailActor_Movie");
        });
        modelBuilder.Entity<DetailGenres>(entity =>
        {
            entity.HasKey(dg => new { dg.MovieID, dg.GenresID });

            entity.ToTable("DetailGenres");

            entity.HasOne(g => g.genres)
                .WithMany(dg => dg.DetailGenres)
                .HasForeignKey(g => g.GenresID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailGenres_Genres");

            entity.HasOne(m => m.movie)
                .WithMany(dg => dg.DetailGenres)
                .HasForeignKey(m => m.MovieID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailGenres_Movie");
        });
        modelBuilder.Entity<DetailReview>(entity =>
        {
            entity.HasKey(dr => new { dr.MovieID, dr.ReviewID });

            entity.ToTable("DetailReview");

            entity.HasOne(r => r.reView)
                .WithMany(dr => dr.DetailReviews)
                .HasForeignKey(r => r.ReviewID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailReview_Review");

            entity.HasOne(m => m.movie)
                .WithMany(dr => dr.DetailReviews)
                .HasForeignKey(m => m.MovieID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailReview_Movie");
        });
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(a => a.ActorId);
            entity.ToTable("Actor");

            entity.Property(e => e.ActorId)
                .HasMaxLength(25)
                .HasColumnName("ActorID");
            entity.Property(e => e.ActorName).HasMaxLength(25);
            entity.Property(e => e.Story).HasMaxLength(25);
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(d => d.DirectorId);
            entity.ToTable("Director");

            entity.Property(e => e.DirectorId)
                .HasMaxLength(25)
                .HasColumnName("DirectorID");
            entity.Property(e => e.DirectorName).HasMaxLength(25);
            entity.Property(e => e.Story).HasMaxLength(100);
        });

        modelBuilder.Entity<Genres>(entity =>
        {
            entity.HasKey(e => e.GenresId);

            entity.Property(e => e.GenresId)
                .HasMaxLength(25)
                .HasColumnName("GenresID");
            entity.Property(e => e.GenresName).HasMaxLength(100);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(m => m.MovieId);
            entity.ToTable("Movie");
            entity.Property(e => e.MovieId)
                .HasMaxLength(25)
                .HasColumnName("MovieID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.DirectorId)
                .HasMaxLength(25)
                .HasColumnName("DirectorID");
            entity.Property(e => e.MovieName).HasMaxLength(150);
            entity.Property(e => e.OverView).HasMaxLength(200);
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

            entity.HasOne(d => d.Director).WithMany(p => p.Movies)
                .HasForeignKey(d => d.DirectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movie_Director");
        });

        modelBuilder.Entity<ReView>(entity =>
        {
            entity.HasKey(r => r.ReviewId);
            entity.ToTable("ReView");

            entity.Property(e => e.ReviewId)
                .HasMaxLength(25)
                .HasColumnName("ReviewID");
            entity.Property(e => e.Content).HasMaxLength(500);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(25)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.ReViews)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Review_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.UserId);
            entity.ToTable("User");

            entity.Property(e => e.UserId)
                .HasMaxLength(25)
                .HasColumnName("UserID");
            entity.Property(e => e.PassWord).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
