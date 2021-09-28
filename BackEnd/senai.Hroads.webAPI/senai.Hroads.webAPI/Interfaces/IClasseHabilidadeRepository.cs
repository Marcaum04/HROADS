using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface IClasseHabilidadeRepository
    {

        /// <summary>
        /// Busca a habilidade da classe pelo id
        /// </summary>
        /// <param name="idClasseHabilidade">recebe o id da habilidade classe</param>
        /// <returns></returns>
        ClasseHabilidade BuscarPorId(int idClasseHabilidade);

        /// <summary>
        /// Cadastra uma habilidade da classe
        /// </summary>
        /// <param name="novaClasseHabilidade">Recebe os dados para uma nova habilidade da classe</param>
        void Cadastrar(ClasseHabilidade novaClasseHabilidade);

        /// <summary>
        /// Lista as habilidades das classes
        /// </summary>
        /// <returns>Uma lista de habilidades das classes</returns>
        List<ClasseHabilidade> Listar();

        /// <summary>
        /// Atualiza as habilidades das classes
        /// </summary>
        /// <param name="classeHabilidadeAtualizada">recebe os dados para atualizar a habilidade da classe</param>
        void Atualizar(ClasseHabilidade classeHabilidadeAtualizada);

        /// <summary>
        /// Deleta as classes
        /// </summary>
        /// <param name="idClasseHabilidade">Id a ser deletado</param>
        void Deletar(int idClasseHabilidade);

    }
}
