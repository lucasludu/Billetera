using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Billetera.Models;

namespace Billetera.Data
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; } = null!;
        public virtual DbSet<Gasto> Gastos { get; set; } = null!;
        public virtual DbSet<Ingreso> Ingresos { get; set; } = null!;
        public virtual DbSet<Movimiento> Movimientos { get; set; } = null!;
        public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasIndex(e => e.Descripcion, "uk_Categoria")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany(p => p.Categoria)
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Categoria_TipoMovimiento");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.ToTable("Gasto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Gasto_Categoria");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Gasto_Usuario");
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.ToTable("Ingreso");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Ingresos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Ingreso_Categoria");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Ingresos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Ingreso_Usuario");
            });

            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.ToTable("Movimiento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Movimiento_Categoria");

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Movimiento_TipoMovimiento");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Movimientos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Movimiento_Usuario");
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.ToTable("TipoMovimiento");

                entity.HasIndex(e => e.Tipo, "uk_TipoMovimiento")
                    .IsUnique();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Email, "uk_Usuario")
                    .IsUnique();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
