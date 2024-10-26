using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace desafio_03.Models
{
    public partial class TurnoverContext : DbContext
    {
        public TurnoverContext()
        {
        }

        public TurnoverContext(DbContextOptions<TurnoverContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Concierto> Conciertos { get; set; } = null!;
        public virtual DbSet<Entrada> Entradas { get; set; } = null!;
        public virtual DbSet<HistorialCompra> HistorialCompras { get; set; } = null!;
        public virtual DbSet<Seccione> Secciones { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               //optionsBuilder.UseSqlServer("server=ROLANFT\\SQLEXPRESS; database=Turnover; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concierto>(entity =>
            {
                entity.Property(e => e.ConciertoId).HasColumnName("ConciertoID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Lugar).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(150);
            });

            modelBuilder.Entity<Entrada>(entity =>
            {
                entity.Property(e => e.EntradaId).HasColumnName("EntradaID");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Seccion)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.SeccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seccion_Entradas");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Entrada)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Entradas");
            });

            modelBuilder.Entity<HistorialCompra>(entity =>
            {
                entity.HasKey(e => e.HistorialId)
                    .HasName("PK__Historia__975206EF0EB9ED47");

                entity.Property(e => e.HistorialId).HasColumnName("HistorialID");

                entity.Property(e => e.EntradaId).HasColumnName("EntradaID");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.HasOne(d => d.Entrada)
                    .WithMany(p => p.HistorialCompras)
                    .HasForeignKey(d => d.EntradaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entrada_Historial");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.HistorialCompras)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Historial");
            });

            modelBuilder.Entity<Seccione>(entity =>
            {
                entity.HasKey(e => e.SeccionId)
                    .HasName("PK__Seccione__18B61621A0B9F74A");

                entity.Property(e => e.SeccionId).HasColumnName("SeccionID");

                entity.Property(e => e.ConciertoId).HasColumnName("ConciertoID");

                entity.Property(e => e.NombreSeccion).HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Concierto)
                    .WithMany(p => p.Secciones)
                    .HasForeignKey(d => d.ConciertoId)
                    .HasConstraintName("FK_Concierto_Secciones");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

                entity.Property(e => e.Contraseña).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
