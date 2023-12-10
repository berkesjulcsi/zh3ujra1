using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh3ujra1.Models;

public partial class TelefonContext : DbContext
{
    public TelefonContext()
    {
    }

    public TelefonContext(DbContextOptions<TelefonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Csomagok> Csomagoks { get; set; }

    public virtual DbSet<Dolgozók> Dolgozóks { get; set; }

    public virtual DbSet<Ügyfelek> Ügyfeleks { get; set; }

    public virtual DbSet<Ügyintézések> Ügyintézéseks { get; set; }

    public virtual DbSet<Üzletek> Üzleteks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softech2.database.windows.net;Initial Catalog=telefonszolg;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Csomagok>(entity =>
        {
            entity.HasKey(e => e.CsomagId).HasName("PK__Csomagok__EA458935332DEC40");

            entity.ToTable("Csomagok");

            entity.Property(e => e.CsomagId)
                .ValueGeneratedNever()
                .HasColumnName("CsomagID");
            entity.Property(e => e.CsomagNév)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FizÜtemezés)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ÉvesKedvezmény).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<Dolgozók>(entity =>
        {
            entity.HasKey(e => e.DolgozóId).HasName("PK__Dolgozók__4C4A0843128FDE08");

            entity.ToTable("Dolgozók");

            entity.Property(e => e.DolgozóId)
                .ValueGeneratedNever()
                .HasColumnName("DolgozóID");
            entity.Property(e => e.DolgozóNév)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Munkaidő)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ÜzletId).HasColumnName("ÜzletID");

            entity.HasOne(d => d.Üzlet).WithMany(p => p.Dolgozóks)
                .HasForeignKey(d => d.ÜzletId)
                .HasConstraintName("FK_Dolgozók_ÜzletID");
        });

        modelBuilder.Entity<Ügyfelek>(entity =>
        {
            entity.HasKey(e => e.ÜgyfélId).HasName("PK__Ügyfelek__F96A0D479B46BCA4");

            entity.ToTable("Ügyfelek");

            entity.Property(e => e.ÜgyfélId)
                .ValueGeneratedNever()
                .HasColumnName("ÜgyfélID");
            entity.Property(e => e.CsomagId).HasColumnName("CsomagID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Név)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SzülIdő).HasColumnType("date");
            entity.Property(e => e.TelSzám)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Csomag).WithMany(p => p.Ügyfeleks)
                .HasForeignKey(d => d.CsomagId)
                .HasConstraintName("FK_Ügyfelek_CsomagID");
        });

        modelBuilder.Entity<Ügyintézések>(entity =>
        {
            entity.HasKey(e => e.ÜgyintézésId).HasName("PK__Ügyintéz__25D48A477D72042D");

            entity.ToTable("Ügyintézések");

            entity.Property(e => e.ÜgyintézésId)
                .ValueGeneratedNever()
                .HasColumnName("ÜgyintézésID");
            entity.Property(e => e.DolgozóId).HasColumnName("DolgozóID");
            entity.Property(e => e.Kezdet).HasColumnType("date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vég).HasColumnType("date");
            entity.Property(e => e.ÜgyfélId).HasColumnName("ÜgyfélID");

            entity.HasOne(d => d.Dolgozó).WithMany(p => p.Ügyintézéseks)
                .HasForeignKey(d => d.DolgozóId)
                .HasConstraintName("FK_Ügyintézések_DolgozóID");

            entity.HasOne(d => d.Ügyfél).WithMany(p => p.Ügyintézéseks)
                .HasForeignKey(d => d.ÜgyfélId)
                .HasConstraintName("FK_Ügyintézések_ÜgyfélID");
        });

        modelBuilder.Entity<Üzletek>(entity =>
        {
            entity.HasKey(e => e.ÜzletId).HasName("PK__Üzletek__0BC13BF6034B662B");

            entity.ToTable("Üzletek");

            entity.Property(e => e.ÜzletId)
                .ValueGeneratedNever()
                .HasColumnName("ÜzletID");
            entity.Property(e => e.Helyszín)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Méret)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ÜzletNév)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
