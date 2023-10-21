using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("DetalleVenta");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
        
            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("Cantidad");

            builder.Property(p => p.ValorUnit)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorUnit");

            builder.HasOne(p => p.Venta)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdVentaFk);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdProductoFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }