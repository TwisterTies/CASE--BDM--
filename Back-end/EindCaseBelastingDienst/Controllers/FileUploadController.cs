using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.IO;
using EindCaseBelastingDienst.Models;
using EindCaseBelastingDienst.Repositories;
using EindCaseBelastingDienst.Services;
using System.Globalization;

namespace EindCaseBelastingDienst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IFileDictionary fileDictionary;

        public FileUploadController(IFileDictionary fileDictionary)
        {
            this.fileDictionary = fileDictionary;
        }

        [HttpPost]
        public async Task<string> ReadFileData(string fileInput)
        {
            if (Request.Body.CanSeek)
            {
                Request.Body.Position = 0;
            }

            fileInput = await new StreamReader(Request.Body).ReadToEndAsync();
            List<string[]> result = await fileDictionary.SplitEntriesInFile(fileInput);
            return fileInput;
        }

    }
}
