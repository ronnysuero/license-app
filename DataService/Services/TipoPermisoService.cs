using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataProvider;
using DataProvider.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace DataService.Services
{
    public class TipoPermisoService : ITipoPermisoService
    {
        private readonly LicenseDbContext _db;
        private readonly IMapper _mapper;

        public TipoPermisoService(IDbFactory factory, IMapper mapper)
        {
            _db = factory.Db;
            _mapper = mapper;
        }

        public IEnumerable<TipoPermisoModel> Get()
        {
            return _db.TipoPermiso
                .ProjectTo<TipoPermisoModel>(_mapper.ConfigurationProvider)
                .ToList();
        }
    }
}