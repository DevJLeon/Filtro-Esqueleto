using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("InventarioTalla");

            builder.HasKey(p=>new{p.IdInventarioFk,p.IdTallaFk});

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("Cantidad");

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.InventarioTallas)
            .HasForeignKey(p => p.IdInventarioFk);

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.InventarioTallas)
            .HasForeignKey(p => p.IdTallaFk);
        }
    }