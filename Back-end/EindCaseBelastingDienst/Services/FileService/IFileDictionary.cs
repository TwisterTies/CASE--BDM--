using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBelastingDienst.Services
{
    public interface IFileDictionary
    {
        public Task<List<string[]>> SplitEntriesInFile(string fileString);
    }
}
