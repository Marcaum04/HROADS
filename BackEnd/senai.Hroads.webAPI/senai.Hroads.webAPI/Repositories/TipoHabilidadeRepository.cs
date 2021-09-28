using senai.Hroads.webAPI.Context;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(TipoHabilidade tipoHabilidadeAtualizada)
        {
            TipoHabilidade tipoHabilidadeBuscada = BuscarPorId(tipoHabilidadeAtualizada.IdTipoHabilidade);

            if (tipoHabilidadeAtualizada.NomeTh != null)
            {
                tipoHabilidadeBuscada.NomeTh = tipoHabilidadeAtualizada.NomeTh;
            }

            ctx.TipoHabilidades.Update(tipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        public TipoHabilidade BuscarPorId(int idTipoHabilidade)
        {
            return ctx.TipoHabilidades.FirstOrDefault(u => u.IdTipoHabilidade == idTipoHabilidade);
        }

        public void Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            ctx.TipoHabilidades.Add(novoTipoHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int idTipoHabilidade)
        {
            TipoHabilidade tipoHabilidadeBuscada = BuscarPorId(idTipoHabilidade);

            ctx.TipoHabilidades.Remove(tipoHabilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
