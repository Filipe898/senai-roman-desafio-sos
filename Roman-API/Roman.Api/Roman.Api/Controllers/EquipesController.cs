using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.Api.Interfaces;
using Roman.Api.Repositories;

namespace Roman.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EquipesController : ControllerBase
    {
        private IEquipeRepository EquipeRepository { get; set; }
        public EquipesController()
        {
            EquipeRepository = new EquipeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(EquipeRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }
    }
}