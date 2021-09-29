using Microsoft.EntityFrameworkCore;
using senai.Hroads.webAPI.Context;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Repositories
{
    public class ClasseHabilidadeRepository : IClasseHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(ClasseHabilidade classeHabilidadeAtualizada)
        {
            ClasseHabilidade classeHabilidadeBuscada = BuscarPorId(classeHabilidadeAtualizada.IdClasseHabilidade);

            if (classeHabilidadeAtualizada.IdClasse != null)
            {
                classeHabilidadeBuscada.IdClasse = classeHabilidadeAtualizada.IdClasse;
            }

            if (classeHabilidadeAtualizada.IdHabilidade != null)
            {
                classeHabilidadeBuscada.IdHabilidade = classeHabilidadeAtualizada.IdHabilidade;
            }

            ctx.ClasseHabilidades.Update(classeHabilidadeBuscada);

            ctx.SaveChanges();
        }

        public ClasseHabilidade BuscarPorId(int idClasseHabilidade)
        {
            return ctx.ClasseHabilidades.Include(C => C.IdClasseNavigation).Include(H => H.IdHabilidadeNavigation).FirstOrDefault(u => u.IdClasseHabilidade == idClasseHabilidade);
        }

        public void Cadastrar(ClasseHabilidade novaClasseHabilidade)
        {
            ctx.ClasseHabilidades.Add(novaClasseHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasseHabilidade)
        {
            ClasseHabilidade classeBuscada = BuscarPorId(idClasseHabilidade);

            ctx.ClasseHabilidades.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<ClasseHabilidade> Listar()
        {
            return ctx.ClasseHabilidades.Include(C => C.IdClasseNavigation).Include(H => H.IdHabilidadeNavigation).ToList();
        }
    }
}
