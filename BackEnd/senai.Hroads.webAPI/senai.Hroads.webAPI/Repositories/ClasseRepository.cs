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
    public class ClasseRepository : IClasseRepository
    {

        HroadsContext ctx = new HroadsContext();
        public void Atualizar(Classe classeAtualizada)
        {
            Classe classeBuscada = BuscarPorId(classeAtualizada.IdClasse);

            if (classeAtualizada.NomeC != null)
            {
                classeBuscada.NomeC = classeAtualizada.NomeC;
            }

            ctx.Classes.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public Classe BuscarPorId(int idClasse)
        {
            return ctx.Classes.FirstOrDefault(u => u.IdClasse == idClasse);
        }

        public void Cadastrar(Classe novaClasse)
        {
            ctx.Classes.Add(novaClasse);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasse)
        {
            Classe classeBuscada = BuscarPorId(idClasse);

            ctx.Classes.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
                return ctx.Classes.ToList();
        }
    }
}
