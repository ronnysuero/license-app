using System;
using DataProvider.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataProvider
{
    public class LicenseDbContext : DbContext
    {
        public LicenseDbContext(DbContextOptions options) : base(options)
        {
        }

        public LicenseDbContext()
        {
        }

        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<TipoPermiso> TipoPermiso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.NombreEmpleado).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ApellidosEmpleado).IsRequired().HasMaxLength(100);

                //entity
                //    .HasOne(s => s.TipoPermiso)
                //    .WithOne()
                //    .HasForeignKey<Permiso>(f => f.TipoPermisoId)
                //    .OnDelete(DeleteBehavior.NoAction);
            });


            modelBuilder.Entity<TipoPermiso>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion).IsRequired().HasMaxLength(100);

                entity.HasData(
                    new TipoPermiso {Id = 1, Descripcion = "Enfermedad"},
                    new TipoPermiso {Id = 2, Descripcion = "Diligencias"}
                );
            });
        }

        public virtual void MarkAsModified<TEntity>(TEntity entity) where TEntity : class
        {
            MarkAs(entity, EntityState.Modified);
        }

        public virtual void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            MarkAs(entity, EntityState.Deleted);
        }

        void MarkAs<TEntity>(TEntity entity, EntityState state) where TEntity : class
        {
            Entry(entity).State = state;
        }

        [Obsolete("Use overload for unit tests. Use MarkAs methods instead.")]
        public new virtual EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return base.Entry(entity);
        }
    }
}