using Roman.Api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Interfaces
{
    interface IProjetoRepository
    {
        List<Projeto> Listar();

        List<Projeto> ListarPorTema(int idTema);

        void Atualizar(Projeto projeto);

        void Cadastrar(Projeto projeto);

        Projeto BuscarPorId(int id);
    }
}
