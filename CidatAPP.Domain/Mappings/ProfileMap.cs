using AutoMapper;
using CidatAPP.Domain.Dtos.Usuario.Request;
using CidatAPP.Domain.Dtos.Usuario.Response;
using CidatAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Mappings
{
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            #region Usuario
            CreateMap<UsuarrioRequest, Usuario>();
            CreateMap<Usuario, UsuarioResponse>();
            #endregion
        }
    }
}
