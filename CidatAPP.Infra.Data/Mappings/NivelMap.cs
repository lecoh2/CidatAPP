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
    public class NivelMap : IEntityTypeConfiguration<Niveis>
    {
        public void Configure(EntityTypeBuilder<Niveis> builder)
        {
            builder.ToTable("NIVEL");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).HasColumnName("IDNIVEL").IsRequired();
            builder.Property(n => n.NomeNivel).HasColumnName("NOMENIVEL").IsRequired();    
        }
    }
}

