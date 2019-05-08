using System;
using System.Collections.Generic;

namespace Roman.Api.Domains
{
    public partial class Projeto
    {
        public Projeto()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdProjeto { get; set; }
        public string NmProjeto { get; set; }
        public int? IdTema { get; set; }

        public Tema IdTemaNavigation { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
