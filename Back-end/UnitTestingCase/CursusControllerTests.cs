using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EindCaseBelastingDienst.Models;
using Moq;
using EindCaseBelastingDienst.Controllers;
using System.Threading.Tasks;
using EindCaseBelastingDienst.DataAccess;
using EindCaseBelastingDienst.Repositories;

namespace EindCaseBelastingDienst.Test
{
    [TestClass]
    class CursusControllerTests
    {
        CursusController sut;
        Cursus _cursus;
        CursusInstantie _cursusInstantie;
        CursusContext _cursusContext;
        Mock<ICursusRepository> cursusRepository;

        [TestInitialize]
        public void Init()
        {
            _cursus = new Cursus
            {
                Naam = "LINQ Training",
                CursusCode = "LINQ",
                Duur = 5,
                CursusInstantieId = 1,
            };

            _cursusInstantie = new CursusInstantie
            {
                CursusInstantieId = 1,
                CursusTijd = "22/07/2021"
            };

            sut = new CursusController(_cursusContext);
        }

        [TestMethod]
        public async Task ShouldReturnJoinedCourseWithTimeFromCursusInstantie()
        {
            var result = await sut.GetCursussen();
            var name = "LINQ Training";
            var code = "LINQ";
            var date = "22/07/2021";
            var duur = "5";
            var expected = new []
            {
                name,
                code,
                date,
                duur
            };
            Equals(result, expected);
        }
    }
}
