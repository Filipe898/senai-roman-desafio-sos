using Roman.Api.Domains;
using Roman.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Repositories
{
    public class TemaRepository : ITemaRepository
    {
        public void Atualizar(Tema tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Tema.Update(tema);
                ctx.SaveChanges();
            }
        }

        public Tema BuscarPorId(int id)
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Tema.Find(id);
            }
        }

        public void Cadastrar(Tema tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Tema.Add(tema);
                ctx.SaveChanges();
            }
        }

        public void Deletar(Tema tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                ctx.Tema.Remove(tema);
                ctx.SaveChanges();
            }
        }

        public List<Tema> ListarTemas()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Tema.ToList();
            }
        }
    }
}
