using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Cliente");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);
        
            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnName("Nombre");

            builder.Property(p => p.FechaRegistro)
            .IsRequired()
            .HasColumnType("date")
            .HasColumnName("FechaRegistro");

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdTipoPersonaFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }