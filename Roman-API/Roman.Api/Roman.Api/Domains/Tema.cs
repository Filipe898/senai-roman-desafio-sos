using System;
using System.Collections.Generic;

namespace Roman.Api.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int IdTema { get; set; }
        public string DsTema { get; set; }

        public ICollection<Projeto> Projeto { get; set; }
    }
}
