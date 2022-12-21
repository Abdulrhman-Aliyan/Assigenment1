using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using api.Entites;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
          private readonly DataContext _context;
        public GamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppGames>>> GetGames()
        {
            var result = await _context.appGames.ToListAsync();

            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppGames>> GetUser(int id)
        {
            var result = await _context.appGames.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (result == null)
                return NotFound();

            return result;
        }
    }
}