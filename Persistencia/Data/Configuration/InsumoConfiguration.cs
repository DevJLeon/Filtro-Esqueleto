using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Insumo");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnName("Nombre");

            builder.Property(p => p.ValorUnit)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorUnit");

            builder.Property(p => p.StockMin)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("StockMin");

            builder.Property(p => p.StockMax)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("StockMax");
        }
    }