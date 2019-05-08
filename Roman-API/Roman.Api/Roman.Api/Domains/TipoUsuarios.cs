using System;
using System.Collections.Generic;

namespace Roman.Api.Domains
{
    public partial class TipoUsuarios
    {
        public TipoUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoUsuario { get; set; }
        public string NmTipoUsuario { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
