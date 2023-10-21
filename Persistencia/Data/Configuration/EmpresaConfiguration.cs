using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Empresa");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
        
            builder.Property(p => p.Nit)
            .IsRequired()
            .HasColumnType("int")
            .HasColumnName("Nit");

            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasColumnName("RazonSocial");

            builder.Property(p => p.RepresentanteLegal)
            .IsRequired()
            .HasColumnName("RepresentanteLegal");

            builder.Property(p => p.FechaCreacion)
            .IsRequired()
            .HasColumnType("date")
            .HasColumnName("FechaCreacion");

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.IdMunicipio);
            
        }
    }