using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBelastingDienst.Services
{
    public class FileDictionary : IFileDictionary
    {
        public async Task<List<string[]>> SplitEntriesInFile(string fileString)
        {
            List<string[]> courseList = new List<string[]>();
            string stringToSplit = fileString;
            string[] result = stringToSplit.Split(new string[] { "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var course in result)
            {
                string removedEntersFromCourses = course.Replace("\r\n", string.Empty);
                string[] splitCourses = removedEntersFromCourses.Split(new string[] { "Titel: ", "Cursuscode: ", "Duur: ", "Startdatum: " }, StringSplitOptions.RemoveEmptyEntries);
                courseList.Add(splitCourses);
            }
            return courseList;
        }
    }
}
