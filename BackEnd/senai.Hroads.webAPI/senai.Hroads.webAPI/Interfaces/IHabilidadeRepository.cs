using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface IHabilidadeRepository
    {

        /// <summary>
        /// Busca a habilidade pelo id
        /// </summary>
        /// <param name="idHabilidade">recebe o id da habilidade</param>
        /// <returns></returns>
        Habilidade BuscarPorId(int idHabilidade);

        /// <summary>
        /// Cadastra uma habilidade
        /// </summary>
        /// <param name="novaHabilidade">Recebe os dados para uma nova habilidade</param>
        void Cadastrar(Habilidade novaHabilidade);

        /// <summary>
        /// Lista as habilidades
        /// </summary>
        /// <returns>Uma lista de habilidades</returns>
        List<Habilidade> Listar();

        /// <summary>
        /// Atualiza as habilidades
        /// </summary>
        /// <param name="habilidadeAtualizada">recebe os dados para atualizar as habilidades</param>
        void Atualizar(Habilidade habilidadeAtualizada);

        /// <summary>
        /// Deleta as habilidades
        /// </summary>
        /// <param name="idHabilidade">Id a ser deletado</param>
        void Deletar(int idHabilidade);
    }
}
