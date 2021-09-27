using senai.Hroads.webAPI.Context;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(Tipousuario tipoUsuarioAtualizado)
        {
            Tipousuario tipoUsuarioBuscado = ctx.Tipousuarios.Find(tipoUsuarioAtualizado.IdTipoUsuario);

            if (tipoUsuarioAtualizado.TituloUsuario !=null)
            {
                tipoUsuarioBuscado.TituloUsuario = tipoUsuarioAtualizado.TituloUsuario;
            }

            ctx.Tipousuarios.Update(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public void Cadastrar(Tipousuario novoTipoUsuario)
        {
            ctx.Tipousuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoUsuario)
        {
            Tipousuario tipoUsuarioBuscado = ctx.Tipousuarios.FirstOrDefault(Tu => Tu.IdTipoUsuario == idTipoUsuario);

            ctx.Tipousuarios.Remove(tipoUsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Tipousuario> Listar()
        {
            return ctx.Tipousuarios.ToList();
        }
    }
}
