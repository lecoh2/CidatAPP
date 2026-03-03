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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("IDUSUARIO");
            builder.Property(u => u.Login).HasColumnName("LOGIN");
            builder.Property(u => u.Senha).HasColumnName("SENHA");
            builder.Property(u => u.DataCadastro).HasColumnName("DATACADASTRO");
            builder.Property(u => u.DataAtualizacao).HasColumnName("DATAATUALIZACAO");
            builder.Property(u => u.Status).HasColumnName("STATUS");      

        }
    }
}
