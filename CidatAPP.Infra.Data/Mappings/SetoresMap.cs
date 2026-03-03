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
    public class SetoresMap : IEntityTypeConfiguration<Setor>

    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.ToTable("SETORES");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("IDSETOR");
            builder.Property(s => s.NomeSetor).HasColumnName("NOMESETOR").HasMaxLength(255);

        }
    }
}
