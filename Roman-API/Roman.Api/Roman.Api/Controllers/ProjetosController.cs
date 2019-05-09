using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository ProjetoRepository { get; set; }

        public ProjetosController()
        {
            ProjetoRepository = new ProjetoRepository();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Listar()
        {
            try
            {
                return Ok(ProjetoRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensagem = ex
                });
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult ListarPorTema(int id)
        {
            try
            {
                return Ok(ProjetoRepository.ListarPorTema(id));
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
        [Authorize]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                ProjetoRepository.Cadastrar(projeto);

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
        [Authorize]
        public IActionResult Atualizar(Projeto novoProjeto)
        {
            try
            {
                Projeto projetoASerAtualizado = ProjetoRepository.BuscarPorId(novoProjeto.IdProjeto);

                if (projetoASerAtualizado == null)
                {
                    return BadRequest(new
                    {
                        mensagem = "Projeto não encontrado."
                    });
                }

                if (novoProjeto.NmProjeto != null)
                {
                    projetoASerAtualizado.NmProjeto = novoProjeto.NmProjeto;
                }

                if (novoProjeto.IdTema != null)
                {
                    projetoASerAtualizado.IdTema = novoProjeto.IdTema;
                }

                ProjetoRepository.Atualizar(projetoASerAtualizado);

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