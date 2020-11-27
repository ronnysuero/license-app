using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DataProvider;
using DataProvider.Entities;
using DataProvider.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataService.Services
{
    public class PermisoService : IPermisoService
    {
        private readonly LicenseDbContext _db;
        private readonly IMapper _mapper;

        public PermisoService(IDbFactory factory, IMapper mapper)
        {
            _db = factory.Db;
            _mapper = mapper;
        }

        IQueryable<PermisoModel> Query()
        {
            return _db.Permiso.Include(i => i.TipoPermiso)
                .ProjectTo<PermisoModel>(_mapper.ConfigurationProvider);
        }

        public IEnumerable<PermisoModel> Get()
        {
            return Query().OrderByDescending(o => o.FechaPermiso).ToList();
        }

        public bool Delete(int id)
        {
            var entity = _db.Permiso.FirstOrDefault(f => f.Id == id);

            if (entity == null) throw new ApplicationException("Registro no encontrado");

            _db.MarkAsDeleted(entity);
            //_db.Entry(entity).State = EntityState.Deleted;
            _db.SaveChanges();

            return true;
        }

        public PermisoModel Add(PermisoModel model)
        {
            var entity = _mapper.Map<Permiso>(model);

            _db.Permiso.Add(entity);
            _db.SaveChanges();

            return Query().FirstOrDefault(f => f.Id == entity.Id);
        }

        public PermisoModel Update(PermisoModel model)
        {
            if (model.Id == 0) throw new ApplicationException("Registro no encontrado");

            var entity = _mapper.Map<Permiso>(model);

            _db.MarkAsModified(entity);
            //_db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();

            return Query().FirstOrDefault(f => f.Id == entity.Id);
        }
    }
}