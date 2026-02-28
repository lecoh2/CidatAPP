using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        //Método construtor para receber por meio de injeção de dependência 
        //as configurações do banco de dados, como conexão, tipo etc. 
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adiciona todas as classes de mapeamento do Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Definindo as configurações default para os campos das entidades
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach(var property in entity.GetProperties())
                {
                    //Definir o nome dos campos das tabelas em caixa alta
                    property.SetColumnName(property.Name.ToUpper());
                    //Configuração default para campo do tipo string
                    if (property.ClrType==typeof(string))
                    {
                        property.SetIsUnicode(false); //Capo do tipo varchar
                        property.SetMaxLength(250);//Tamanho máximo do campo
                        //property.IsNullable = false;//CampoObrigatório (NotNull
                    }
                    //Configuração default para campo do tipo decimal
                    else if (property.ClrType == typeof(decimal) || property.ClrType == typeof(decimal?))
                    {
                        property.SetColumnType("decimal(10,2)");
                    }
                }
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
