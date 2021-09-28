using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Hroads.webAPI.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public byte IdTipoHabilidade { get; set; }
        public string NomeTh { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
