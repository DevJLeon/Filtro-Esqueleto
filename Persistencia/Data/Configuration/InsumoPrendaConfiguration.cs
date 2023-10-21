using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("InsumoPrenda");

            builder.HasKey(p=>new{p.IdInsumoFk,p.IdPrendaFk});

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("Cantidad");

            builder.HasOne(p => p.Insumo)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.IdInsumoFk);

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.IdPrendaFk);
        }
    }