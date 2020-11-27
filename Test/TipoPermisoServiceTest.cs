using System.Collections.Generic;
using NUnit.Framework;
using FluentAssertions;
using System.Linq;
using AutoMapper;
using DataProvider.Entities;
using DataProvider.Interfaces;
using DataService.Services;
using LicenseApp.Test.Abstraction;

namespace LicenseApp.Test
{
    [TestFixture]
    public class TipoPermisoServiceTest : ServiceBaseTest<TipoPermiso>
    {
        TipoPermisoService Service { get; set; }

        [Test]
        public void Find_at_least_one_license()
        {
            var licenses = Service.Get();

            var data = licenses.ToList();

            data.Should().NotBeNullOrEmpty();
            data.Count().Should().Be(2);
        }

        protected override List<TipoPermiso> SeedData()
        {
            return new List<TipoPermiso>
            {
                new TipoPermiso
                {
                    Id = 1,
                    Descripcion = "Enfermedad"
                },
                new TipoPermiso
                {
                    Id = 2,
                    Descripcion = "Ocio"
                }
            };
        }

        protected override void Setup(IDbFactory factory, IMapper mapper)
        {
            MockContext.Setup(m => m.TipoPermiso).Returns(MockSet.Object);
            Service = new TipoPermisoService(factory, mapper);
        }
    }
}