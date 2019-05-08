using Roman.Api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Interfaces
{
    interface ITemaRepository
    {
        List<Tema> ListarTemas();

        void Cadastrar(Tema tema);

        void Deletar(Tema tema);

        void Atualizar(Tema tema);

        Tema BuscarPorId(int id);
    }
}
