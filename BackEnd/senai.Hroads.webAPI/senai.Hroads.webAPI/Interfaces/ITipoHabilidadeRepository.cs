using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface ITipoHabilidadeRepository
    {

        /// <summary>
        /// Busca o tipo da habilidade pelo id
        /// </summary>
        /// <param name="idTipoHabilidade">recebe o id do tipo habilidade</param>
        /// <returns></returns>
        TipoHabilidade BuscarPorId(int idTipoHabilidade);

        /// <summary>
        /// Cadastra um Tipo de Habilidade
        /// </summary>
        /// <param name="novoTipoHabilidade">Recebe os dados para um novo Tipo de Habilidade</param>
        void Cadastrar(TipoHabilidade novoTipoHabilidade);

        /// <summary>
        /// Lista os Tipo de Habilidade
        /// </summary>
        /// <returns>Uma lista de Tipo de Habilidade</returns>
        List<TipoHabilidade> Listar();

        /// <summary>
        /// Atualiza os Tipo de Habilidade
        /// </summary>
        /// <param name="tipoHabilidadeAtualizada">recebe os dados para atualizar o Tipo de Habilidade</param>
        void Atualizar(TipoHabilidade tipoHabilidadeAtualizada);

        /// <summary>
        /// Deleta as classes
        /// </summary>
        /// <param name="idTipoHabilidade">Id a ser deletado</param>
        void Deletar(int idTipoHabilidade);

    }
}
