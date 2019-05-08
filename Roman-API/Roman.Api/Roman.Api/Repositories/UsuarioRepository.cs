using Microsoft.EntityFrameworkCore;
using Roman.Api.Domains;
using Roman.Api.Interfaces;
using Roman.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public void Atualizar(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Update(usuario);
                ctx.SaveChanges();
            }
        }

        public Usuarios BuscarPorEmailESenha(LoginViewModel login)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.Include(x => x.IdTipoUsuariosNavigation).FirstOrDefault(x => x.DsEMail == login.Email && x.DsSenha == login.Senha);
            }
        }

        public void Cadastrar(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }

        public void Deletar(Usuarios usuario)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Usuarios.Remove(usuario);
                ctx.SaveChanges();
            }
        }

        public List<Usuarios> ListarUsuarios()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Usuarios.ToList();
            }
        }
    }
}
