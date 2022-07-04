using System.Threading.Tasks;
using System.Collections.Generic;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private DataContext DATA_CONTEXT;

        public UsersController(DataContext context)
        {
            this.DATA_CONTEXT = context;
        }

        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dados = await DATA_CONTEXT.users.ToListAsync();
            return Ok(dados);
        }
    }
}
