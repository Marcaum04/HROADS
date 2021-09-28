using System;
using System.Collections.Generic;

#nullable disable

namespace senai.Hroads.webAPI.Domains
{
    public partial class ClasseHabilidade
    {
        public byte IdClasseHabilidade { get; set; }
        public byte? IdHabilidade { get; set; }
        public byte? IdClasse { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
