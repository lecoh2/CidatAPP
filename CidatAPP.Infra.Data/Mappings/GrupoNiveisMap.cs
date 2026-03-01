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
    public class GrupoNiveisMap : IEntityTypeConfiguration<GrupoNiveis>
    {
        public void Configure(EntityTypeBuilder<GrupoNiveis> builder)
        {
            builder.ToTable("GRUPONIVEL");

            builder.HasKey(g => new { g.IdUsuario, g.Id });

            builder.HasOne(g => g.Usuario)
                   .WithMany(u => u.GrupoNiveis)
                   .HasForeignKey(g => g.IdUsuario)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.Niveis)
                   .WithMany(s => s.GrupoNiveis)
                   .HasForeignKey(g => g.Id)
                   .OnDelete(DeleteBehavior.Restrict);

       
        }
    }


}

