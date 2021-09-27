﻿using senai.Hroads.webAPI.Context;
using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Repositories
{
    public class PersonagemRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(Personagem PersonagemAtualizado)
        {
            Personagem PersonagemBuscado = ctx.Personagems.Find(PersonagemAtualizado.IdPersonagem);

            if (PersonagemAtualizado.NomeP != null)
            {
                PersonagemBuscado.NomeP = PersonagemAtualizado.NomeP;
            }

            ctx.Personagems.Update(PersonagemBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            ctx.Personagems.Add(novoPersonagem);

            ctx.SaveChanges();
        }

        public void Deletar(int idPersonagem)
        {
            Personagem PersonagemBuscado = ctx.Personagems.FirstOrDefault(Tu => Tu.IdPersonagem == idPersonagem);

            ctx.Personagems.Remove(PersonagemBuscado);

            ctx.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            return ctx.Personagems.ToList();
        }
    }
}
