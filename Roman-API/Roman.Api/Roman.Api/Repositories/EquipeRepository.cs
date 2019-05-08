using Roman.Api.Domains;
using Roman.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Repositories
{
    public class EquipeRepository : IEquipeRepository
    {
        public List<Equipe> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Equipe.ToList();
            }
        }
    }
}
