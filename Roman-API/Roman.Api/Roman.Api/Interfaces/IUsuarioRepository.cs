using Roman.Api.Domains;
using Roman.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuarios> ListarUsuarios();

        void Cadastrar(Usuarios usuario);

        void Deletar(Usuarios usuario);

        void Atualizar(Usuarios usuario);

        Usuarios BuscarPorEmailESenha(LoginViewModel login);
    }
}
