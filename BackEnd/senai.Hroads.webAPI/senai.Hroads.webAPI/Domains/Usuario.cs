using System;
using System.Collections.Generic;

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
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
