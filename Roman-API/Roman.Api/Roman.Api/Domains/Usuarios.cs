using System;
using System.Collections.Generic;

namespace Roman.Api.Domains
{
    public partial class Usuarios
    {
        public int IdUsuarios { get; set; }
        public string NmUsuarios { get; set; }
        public string DsSenha { get; set; }
        public string NumTelefone { get; set; }
        public string DsEMail { get; set; }
        public int? IdTipoUsuarios { get; set; }
        public int? IdEquipe { get; set; }
        public int? IdProjeto { get; set; }

        public Equipe IdEquipeNavigation { get; set; }
        public Projeto IdProjetoNavigation { get; set; }
        public TipoUsuarios IdTipoUsuariosNavigation { get; set; }
    }
}
