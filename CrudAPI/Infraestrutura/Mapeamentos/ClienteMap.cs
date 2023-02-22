using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.Data.Mapeamentos
{
    public class ClienteMap : BaseMap<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.ToTable("cliente");

            builder.Property(c => c.Nome)
                .HasColumnName("nome")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(c => c.CPF)
                .HasColumnName("cpf")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(c => c.Endereco)
                .HasColumnName("endereco")
                .HasMaxLength(255);
        }
    }
}
