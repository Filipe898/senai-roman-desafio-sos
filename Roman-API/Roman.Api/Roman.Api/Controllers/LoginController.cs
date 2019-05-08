using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Roman.Api.Domains;
using Roman.Api.Interfaces;
using Roman.Api.Repositories;
using Roman.Api.ViewModels;

namespace Roman.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }
        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            Usuarios usuarioProcurado = UsuarioRepository.BuscarPorEmailESenha(login);

            if (usuarioProcurado == null)
            {
                return BadRequest(new
                {
                    mensagem = "Usuário não encontrado."
                });
            }

            var claims = new[]
               {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioProcurado.DsEMail),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioProcurado.IdUsuarios.ToString()),
                    new Claim(ClaimTypes.Role, usuarioProcurado.IdTipoUsuariosNavigation.NmTipoUsuario),
                    new Claim("tipoUsuario", usuarioProcurado.IdTipoUsuariosNavigation.NmTipoUsuario)
                };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("roman-chave-autenticacao"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "Roman.Api",
                audience: "Roman.Api",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            });
        }
    }
}