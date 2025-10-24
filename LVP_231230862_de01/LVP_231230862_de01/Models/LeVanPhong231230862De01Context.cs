using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LVP_231230862_de01.Models;

public partial class LeVanPhong231230862De01Context : DbContext
{
    public LeVanPhong231230862De01Context()
    {
    }

    public LeVanPhong231230862De01Context(DbContextOptions<LeVanPhong231230862De01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Lvpcomputer> Lvpcomputers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JG9VJF8\\SQLEXPRESS01;Database=LeVanPhong_231230862_de01;uid=sa;pwd=1234;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lvpcomputer>(entity =>
        {
            entity.HasKey(e => e.LvpcomId).HasName("PK__LVPCompu__9DC3258CD4028F0D");

            entity.ToTable("LVPComputer");

            entity.Property(e => e.LvpcomId)
                .ValueGeneratedNever()
                .HasColumnName("LVPComId");
            entity.Property(e => e.LvpcomImage)
                .HasMaxLength(250)
                .HasColumnName("LVPComImage");
            entity.Property(e => e.LvpcomName)
                .HasMaxLength(100)
                .HasColumnName("LVPComName");
            entity.Property(e => e.LvpcomPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("LVPComPrice");
            entity.Property(e => e.Lvpcomstatus).HasColumnName("LVPComstatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
