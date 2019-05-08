using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Api.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Informe o email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }
    }
}
