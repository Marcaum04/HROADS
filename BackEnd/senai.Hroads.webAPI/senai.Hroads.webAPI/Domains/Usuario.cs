using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.Hroads.webAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Personagems = new HashSet<Personagem>();
        }

        public int IdUsuario { get; set; }
        public byte? IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "A senha deve ter de 3 a 10 caracteres")]
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
