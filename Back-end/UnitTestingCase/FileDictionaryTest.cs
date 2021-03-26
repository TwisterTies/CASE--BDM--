using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EindCaseBelastingDienst.Models;
using EindCaseBelastingDienst.Services;
using System.Threading.Tasks;

namespace UnitTestingCase
{
    [TestClass]
    public class FileDictionaryTest
    {

        FileDictionary sut;

        [TestInitialize]
        public void Init()
        {
            sut = new FileDictionary();
        }

        [TestMethod]
        public async Task ShouldCreateStringArraysOfDifferentCourseEntries()
        {
            string stringToSplit = "Titel: Object Oriented Programming in C# By Example\r\nCursuscode: OOCS\r\nDuur: 5 dagen\r\nStartdatum: 22/03/2021\r\n\r\nTitel: LINQ: .NET Language-Integrated Query\r\nCursuscode: LINQ\r\nDuur: 2 dagen\r\nStartdatum: 22/03/2021";
            var courseList = await sut.SplitEntriesInFile(stringToSplit);
            List<string[]> expectedCourseList = new List<string[]>()
            {
                new string[4] {"Object Oriented Programming in C# By Example","OOCS","5 dagen","22/03/2021"},
                new string[4] {"LINQ: .NET Language-Integrated Query", "LINQ", "2 dagen", "22/03/2021"}
            };
            Equals(courseList, expectedCourseList);
        }
    }
}
