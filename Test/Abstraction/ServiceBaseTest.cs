using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataProvider;
using DataProvider.Entities;
using DataProvider.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace LicenseApp.Test.Abstraction
{
    public abstract class ServiceBaseTest<TEntity> where TEntity : class
    {
        protected Mock<LicenseDbContext> MockContext;
        protected Mock<DbSet<TEntity>> MockSet;

        protected abstract List<TEntity> SeedData();

        protected abstract void Setup(IDbFactory factory, IMapper mapper);

        [SetUp]
        public void Setup()
        {
            var records = SeedData();
            var queryable = records.AsQueryable();

            MockSet = new Mock<DbSet<TEntity>>();

            MockSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(queryable.Provider);
            MockSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(queryable.Expression);
            MockSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            MockSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            MockSet.Setup(m => m.Add(It.IsAny<TEntity>())).Callback((TEntity entity) => records.Add(entity));
            MockSet.Setup(m => m.Remove(It.IsAny<TEntity>())).Callback((TEntity entity) => records.Remove(entity));

            MockContext = new Mock<LicenseDbContext>();

            MockContext.Setup(m => m.MarkAsModified(It.IsAny<object>()));
            MockContext.Setup(m => m.MarkAsDeleted(It.IsAny<object>()));

            var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Permiso, PermisoModel>().ReverseMap();
                    cfg.CreateMap<TipoPermiso, TipoPermisoModel>().ReverseMap();
                }
            );

            var mapper = configuration.CreateMapper();

            var factory = new Mock<IDbFactory>();
            factory.Setup(s => s.Db).Returns(MockContext.Object);

            Setup(factory.Object, mapper);
            //Service = new PermisoService(factory.Object, Mapper);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
        }
    }
}