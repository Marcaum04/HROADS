using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface IClasseRepository
    {

        /// <summary>
        /// Busca a classe pelo id
        /// </summary>
        /// <param name="idClasse">recebe o id da classe</param>
        /// <returns></returns>
        Classe BuscarPorId(int idClasse);

        /// <summary>
        /// Cadastra uma classe
        /// </summary>
        /// <param name="novaClasse">Recebe os dados para uma nova classe</param>
        void Cadastrar(Classe novaClasse);

        /// <summary>
        /// Lista as classes
        /// </summary>
        /// <returns>Uma lista de classes</returns>
        List<Classe> Listar();

        /// <summary>
        /// Atualiza as classes
        /// </summary>
        /// <param name="classeAtualizada">recebe os dados para atualizar a classe</param>
        void Atualizar(Classe classeAtualizada);

        /// <summary>
        /// Deleta as classes
        /// </summary>
        /// <param name="idClasse">Id a ser deletado</param>
        void Deletar(int idClasse);

    }
}
