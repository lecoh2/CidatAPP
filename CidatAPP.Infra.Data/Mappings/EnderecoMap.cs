using CidatAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Infra.Data.Mappings
{
    internal class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            builder.ToTable("ENDERECO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("IDENDERECO")
                .IsRequired();
            builder.Property(e => e.Logradouro).HasColumnName("LOGRADOURO");
            builder.Property(e => e.Numero).HasColumnName("NUMERO");
            builder.Property(e => e.Complemento)
    .HasColumnName("COMPLEMENTO")
    .HasMaxLength(250)
    .IsRequired(false); // <- ESSENCIAL
            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");
            builder.Property(e => e.Cep).HasColumnName("CEP");
            builder.Property(e => e.Localidade).HasColumnName("LOCALIDADE").HasMaxLength(100);
            builder.Property(e => e.Uf).HasColumnName("UF").HasMaxLength(2);
            builder.Property(e => e.IdProcesso).HasColumnName("PROCESSO_ID");

            #region Relacionamentos
            builder.HasOne(e => e.Processo)
                .WithOne(p => p.Endereco)
                .HasForeignKey<Endereco>(e => e.IdProcesso)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }

    }
}

