using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Prenda");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
    
            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnName("Nombre");

            builder.Property(p => p.ValorUnitCop)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorUnitCop");

            builder.Property(p => p.ValorUnitUsd)
            .IsRequired()
            .HasColumnType("double")
            .HasColumnName("ValorUnitUsd");

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdEstadoFk);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdTipoProteccionFk);

            builder.HasOne(p => p.Genero)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdGeneroFk);

        }
    }