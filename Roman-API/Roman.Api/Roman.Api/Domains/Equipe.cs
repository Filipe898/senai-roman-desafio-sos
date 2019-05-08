using System;
using System.Collections.Generic;

namespace Roman.Api.Domains
{
    public partial class Equipe
    {
        public Equipe()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdEquipe { get; set; }
        public string DsEquipe { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
