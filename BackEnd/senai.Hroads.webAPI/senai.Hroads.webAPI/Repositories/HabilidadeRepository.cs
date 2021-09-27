﻿using senai.Hroads.webAPI.Context;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = BuscarPorId(habilidadeAtualizada.IdHabilidade);

            if (habilidadeAtualizada.NomeH != null)
            {
                habilidadeBuscada.IdHabilidade = habilidadeAtualizada.IdHabilidade;
            }

            ctx.Habilidades.Update(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int idHabilidade)
        {
            return ctx.Habilidades.FirstOrDefault(u => u.IdHabilidade == idHabilidade);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idHabilidade)
        {
            Habilidade classeBuscada = BuscarPorId(idHabilidade);

            ctx.Habilidades.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
