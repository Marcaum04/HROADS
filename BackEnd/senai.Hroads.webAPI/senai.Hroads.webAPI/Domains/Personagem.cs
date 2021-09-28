using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.Hroads.webAPI.Domains
{
    public partial class Personagem
    {
        public byte IdPersonagem { get; set; }
        public byte IdClasse { get; set; }
        public int? IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome do personagem é Obrigatório!")]
        public string NomeP { get; set; }
        public byte? VidaMaxima { get; set; }
        public byte? ManaMaxima { get; set; }
        public DateTime? DataAtuailizacao { get; set; }
        public DateTime? DataCriacao { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
