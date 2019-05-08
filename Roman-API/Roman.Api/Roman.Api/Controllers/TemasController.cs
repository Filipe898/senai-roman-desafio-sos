using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.Api.Domains;
using Roman.Api.Interfaces;
using Roman.Api.Repositories;

namespace Roman.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TemasController : ControllerBase
    {
        private ITemaRepository TemaRepository { get; set; }
        public TemasController()
        {
            TemaRepository = new TemaRepository();
        }

        [HttpGet]
        public IActionResult ListarTemas()
        {
            try
            {
                return Ok(TemaRepository.ListarTemas());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Tema tema)
        {
            try
            {
                TemaRepository.Cadastrar(tema);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Tema tema)
        {
            try
            {
                Tema temaASerAtualizado = TemaRepository.BuscarPorId(tema.IdTema);

                if (temaASerAtualizado == null)
                {
                    return BadRequest(new
                    {
                        mensagem = "Tema não encontrado."
                    });
                }

                if (tema.DsTema != null)
                {
                    temaASerAtualizado.DsTema = tema.DsTema;
                }

                TemaRepository.Atualizar(temaASerAtualizado);
                return Ok();
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