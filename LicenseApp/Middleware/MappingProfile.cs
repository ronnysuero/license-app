using DataProvider.Entities;
using Domain.Models;

namespace LicenseApp.Middleware
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Permiso, PermisoModel>().ReverseMap();
            CreateMap<TipoPermiso, TipoPermisoModel>().ReverseMap();
        }
    }
}