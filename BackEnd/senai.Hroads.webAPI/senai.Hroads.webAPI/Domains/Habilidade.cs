using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Hroads.webAPI.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            Classehabilidades = new HashSet<Classehabilidade>();
        }

        public byte IdHabilidade { get; set; }
        public byte? IdTipoHabilidade { get; set; }
        public string NomeH { get; set; }

        public virtual Tipohabilidade IdTipoHabilidadeNavigation { get; set; }
        public virtual ICollection<Classehabilidade> Classehabilidades { get; set; }
    }
}
