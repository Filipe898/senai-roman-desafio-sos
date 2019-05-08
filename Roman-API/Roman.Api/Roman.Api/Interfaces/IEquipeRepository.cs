using Roman.Api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Interfaces
{
    interface IEquipeRepository
    {
        List<Equipe> Listar();
    }
}
