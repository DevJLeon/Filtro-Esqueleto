using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Proveedor");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nit)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("Nit");

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnName("Nombre");

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdTipoPersonaFk);

            builder
            .HasMany(p => p.Insumos)
            .WithMany(p => p.Proveedores)
            .UsingEntity<InsumoProveedor>(
                j => j
                    .HasOne(pt => pt.Insumo)
                    .WithMany(t => t.InsumoProveedores)
                    .HasForeignKey(pt => pt.IdInsumoFk),
                j => j
                    .HasOne(pt => pt.Proveedor)
                    .WithMany(t => t.InsumoProveedores)
                    .HasForeignKey(pt => pt.IdProveedorFk),
                j => 
                {
                    j.HasKey(t => new {t.IdProveedorFk, t.IdInsumoFk});
                });
        }
    }