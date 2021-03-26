using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EindCaseBelastingDienst.DataAccess;
using EindCaseBelastingDienst.Models;

namespace EindCaseBelastingDienst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursusController : ControllerBase
    {
        private readonly CursusContext _context;

        public CursusController(CursusContext context)
        {
            _context = context;
        }

        // GET: api/Cursus
        [HttpGet]
        public async Task<ActionResult> GetCursussen()
        {
            var query = await _context.Cursussen.Join(
                        _context.CursusInstanties,
                        cursus => cursus.CursusInstantieId,
                        cursusInstantie => cursusInstantie.CursusInstantieId,
                        (cursus, cursusInstantie) => new
                        {
                            CursusCode = cursus.CursusCode,
                            CursusTijd = cursusInstantie.CursusTijd,
                            CursusNaam = cursus.Naam,
                            Duur = cursus.Duur,
                        }
                       ).ToArrayAsync();

            return Ok(query);
        }
    }
}
