using Roman.Api.Domains;
using Roman.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        public void Atualizar(Projeto projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projeto.Update(projeto);
                ctx.SaveChanges();
            }
        }

        public Projeto BuscarPorId(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.Find(id);
            }
        }

        public void Cadastrar(Projeto projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Projeto.Add(projeto);
                ctx.SaveChanges();
            }
        }

        public List<Projeto> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.ToList();
            }
        }

        public List<Projeto> ListarPorTema(int idTema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.Where(x => x.IdTema == idTema).ToList();
            }
        }
    }
}
