using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Inventario");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
        
            builder.Property(p => p.CodInv)
            .IsRequired()
            .HasColumnName("CodInv");

            builder.Property(p => p.ValorVtaCop)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorVtaCop");

            builder.Property(p => p.ValorVtaUsd)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorVtaUsd");

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.IdPrendaFk);
        }
    }