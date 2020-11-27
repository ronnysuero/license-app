using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using FluentAssertions;
using System.Linq;
using AutoMapper;
using DataProvider.Entities;
using DataProvider.Interfaces;
using DataService.Services;
using Domain.Models;
using LicenseApp.Test.Abstraction;

namespace LicenseApp.Test
{
    [TestFixture]
    public class PermisoServiceTest : ServiceBaseTest<Permiso>
    {
        PermisoService Service { get; set; }

        [Test]
        public void Find_at_least_one_license()
        {
            var licenses = Service.Get();

            var data = licenses.ToList();

            data.Should().NotBeNullOrEmpty();
            data.Count().Should().Be(1);
        }

        [Test]
        public void New_license_is_saved()
        {
            var model = new PermisoModel
            {
                Id = 2,
                NombreEmpleado = "Ramon",
                ApellidosEmpleado = "Perez",
                TipoPermisoId = 1,
                FechaPermiso = DateTime.Now
            };

            var result = Service.Add(model);

            MockSet.Verify(m => m.Add(It.IsAny<Permiso>()), Times.Once());
            MockContext.Object.Permiso.Count().Should().Be(2);
            MockContext.Verify(m => m.SaveChanges(), Times.Once);
            Assert.AreEqual(result.NombreEmpleado, model.NombreEmpleado);
        }

        [Test]
        public void Modified_license_is_saved()
        {
            var model = new PermisoModel
            {
                Id = 1,
                NombreEmpleado = "Ricardo",
                ApellidosEmpleado = "Perez",
                TipoPermisoId = 1,
                FechaPermiso = DateTime.Now
            };

            var result = Service.Update(model);

            MockContext.Verify(m => m.SaveChanges(), Times.Once);
            Assert.AreEqual(result.Id, model.Id);
        }

        [Test]
        public void License_is_deleted()
        {
            var result = Service.Delete(1);

            MockContext.Object.Permiso.Count().Should().Be(1);
            result.Should().Be(true);
            MockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [Test]
        public void Deletion_for_unexisting_license_throw_exception()
        {
            try
            {
                var result = Service.Delete(0);

                result.Should().Be(false);
            }
            catch (Exception e)
            {
                e.Should().BeOfType<ApplicationException>();
            }
        }

        protected override List<Permiso> SeedData()
        {
            return new List<Permiso>
            {
                new Permiso
                {
                    Id = 1,
                    NombreEmpleado = "Juan",
                    ApellidosEmpleado = "Perez",
                    TipoPermisoId = 1,
                    FechaPermiso = new DateTime(2020, 10, 01)
                }
            };
        }

        protected override void Setup(IDbFactory factory, IMapper mapper)
        {
            MockContext.Setup(m => m.Permiso).Returns(MockSet.Object);
            Service = new PermisoService(factory, mapper);
        }
    }
}